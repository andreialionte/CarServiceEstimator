using CarServiceEstimator.Helpers;
using CarServiceEstimator.Models;
using System.ComponentModel;

namespace CarServiceEstimator
{
    public partial class ReperForm : Form
    {
        private readonly DataContext _context;
        private BindingList<Reper> _repereList;
        private Reper _selectedReper;

        public ReperForm(DataContext context)
        {
            InitializeComponent();
            _context = context;
            ConfigureDataGridView();
            LoadRepere();
            InitializeControls();
        }

        private void ConfigureDataGridView()
        {
            dgvRepere.AutoGenerateColumns = false;
            dgvRepere.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRepere.MultiSelect = false;
            dgvRepere.AllowUserToAddRows = false;

            // Configure columns
            dgvRepere.Columns.Clear();
            dgvRepere.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50,
                ReadOnly = true
            });

            dgvRepere.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DenumireReper",
                DataPropertyName = "DenumireReper",
                HeaderText = "Denumire Reper",
                Width = 200
            });

            dgvRepere.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PretUnitar",
                DataPropertyName = "PretUnitar",
                HeaderText = "Preț Unitar",
                Width = 100
            });

            dgvRepere.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UM",
                DataPropertyName = "UM",
                HeaderText = "Unitate Măsură",
                Width = 100
            });
        }

        private void InitializeControls()
        {
            // Set initial button states
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            // Clear form fields
            ClearForm();

            // Add validation events
            txtUnitPrice.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            };
        }

        private void LoadRepere()
        {
            try
            {
                var repere = _context.Repere.ToList();
                _repereList = new BindingList<Reper>(repere);
                dgvRepere.DataSource = _repereList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea reperelor: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtReperName.Text))
            {
                MessageBox.Show("Introduceti denumirea reperului!", "Validare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Introduceti un preț valid!", "Validare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbUnitMeasure.Text))
            {
                MessageBox.Show("Selectați unitatea de măsură!", "Validare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtReperName.Clear();
            txtUnitPrice.Clear();
            cmbUnitMeasure.SelectedIndex = -1;
            _selectedReper = null;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;

                var newReper = new Reper
                {
                    DenumireReper = txtReperName.Text.Trim(),
                    PretUnitar = decimal.Parse(txtUnitPrice.Text),
                    UM = cmbUnitMeasure.Text,
                    SpImagine = "imagine_url"
                };

                _context.Repere.Add(newReper);
                _context.SaveChanges();

                _repereList.Add(newReper);
                ClearForm();

                MessageBox.Show("Reper adăugat cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea reperului: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedReper == null)
                {
                    MessageBox.Show("Selectați un reper pentru editare!", "Avertisment",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInputs()) return;

                _selectedReper.DenumireReper = txtReperName.Text.Trim();
                _selectedReper.PretUnitar = decimal.Parse(txtUnitPrice.Text);
                _selectedReper.UM = cmbUnitMeasure.Text;

                _context.Repere.Update(_selectedReper);
                _context.SaveChanges();

                dgvRepere.Refresh();
                ClearForm();

                MessageBox.Show("Reper actualizat cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la actualizarea reperului: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedReper == null)
                {
                    MessageBox.Show("Selectați un reper pentru ștergere!", "Avertisment",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show(
                    $"Sunteți sigur că doriți să ștergeți reperul '{_selectedReper.DenumireReper}'?",
                    "Confirmare ștergere",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _context.Repere.Remove(_selectedReper);
                    _context.SaveChanges();

                    _repereList.Remove(_selectedReper);
                    ClearForm();

                    MessageBox.Show("Reper șters cu succes!", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la ștergerea reperului: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reperform()
        {
            // Implement your Reperform logic here
            MessageBox.Show("Reperform logic executed!");
        }

        private void dgvRepere_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvRepere.SelectedRows.Count > 0)
                {
                    _selectedReper = dgvRepere.SelectedRows[0].DataBoundItem as Reper;
                    if (_selectedReper != null)
                    {
                        txtReperName.Text = _selectedReper.DenumireReper;
                        txtUnitPrice.Text = _selectedReper.PretUnitar.ToString();
                        cmbUnitMeasure.Text = _selectedReper.UM;

                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
                else
                {
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la selectarea reperului: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

