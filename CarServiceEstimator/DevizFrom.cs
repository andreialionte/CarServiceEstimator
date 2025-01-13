using CarServiceEstimator.Helpers;
using CarServiceEstimator.Models;
using Microsoft.EntityFrameworkCore;


namespace CarServiceEstimator
{
    public partial class DevizForm : Form
    {
        private readonly DataContext _context;
        private Deviz _selectedDeviz;
        private DevizContinut _selectedDevizContinut;

        public DevizForm(DataContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void DevizForm_Load(object sender, EventArgs e)
        {
            LoadData();
            InitializeButtonStates();
        }

        private void LoadData()
        {
            // Load ComboBox data
            comboBoxClient.DataSource = _context.Clienti.ToList();
            comboBoxClient.DisplayMember = "NumeClient";
            comboBoxClient.ValueMember = "IdClient";

            comboBoxReper.DataSource = _context.Repere.ToList();
            comboBoxReper.DisplayMember = "NumeReper";
            comboBoxReper.ValueMember = "IdReper";

            RefreshDevizeList();
        }

        private void InitializeButtonStates()
        {
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnAddDeviz.Enabled = true;
        }

        private void RefreshDevizeList()
        {
            var devize = _context.Devize
                .Include(d => d.Client)
                .Select(d => new
                {
                    d.IdDeviz,
                    d.DenumireDeviz,
                    Client = d.Client.NumeClient,
                    d.DataDeviz
                })
                .ToList();

            dataGridViewDevize.DataSource = devize;

            if (dataGridViewDevize.Columns["IdDeviz"] != null)
                dataGridViewDevize.Columns["IdDeviz"].Visible = false;
        }

        private void ClearSelection()
        {
            _selectedDeviz = null;
            dataGridViewDevize.ClearSelection();
            txtDevizName.Clear();
            dateTimePickerDeviz.Value = DateTime.Now;
            comboBoxClient.SelectedIndex = -1;
            InitializeButtonStates();
        }

        private void dataGridViewDevize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewDevize.Rows[e.RowIndex];
                var selectedId = (Guid)row.Cells["IdDeviz"].Value;
                _selectedDeviz = _context.Devize
                    .Include(d => d.Client)
                    .FirstOrDefault(d => d.IdDeviz == selectedId);

                if (_selectedDeviz != null)
                {
                    txtDevizName.Text = _selectedDeviz.DenumireDeviz;
                    dateTimePickerDeviz.Value = _selectedDeviz.DataDeviz;
                    comboBoxClient.SelectedValue = _selectedDeviz.IdClient;

                    btnDelete.Enabled = true;
                    btnSave.Enabled = true;
                }
            }
        }

        private void btnAddDeviz_Click(object sender, EventArgs e)
        {
            var createForm = new CreateDevizForm(_context);
            createForm.StartPosition = FormStartPosition.CenterParent;
            createForm.ShowDialog(this);

            RefreshDevizeList();
            ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedDeviz == null)
                {
                    var deviz = new Deviz
                    {
                        IdDeviz = Guid.NewGuid(),
                        DenumireDeviz = txtDevizName.Text,
                        DataDeviz = dateTimePickerDeviz.Value,
                        IdClient = (Guid)comboBoxClient.SelectedValue,
                        MarcaModel = "MarcaModelDefault",
                        NrInmatriculare = "NR123ABC"
                    };

                    _context.Devize.Add(deviz);
                }
                else
                {
                    _selectedDeviz.DenumireDeviz = txtDevizName.Text;
                    _selectedDeviz.DataDeviz = dateTimePickerDeviz.Value;
                    _selectedDeviz.IdClient = (Guid)comboBoxClient.SelectedValue;

                    _context.Devize.Update(_selectedDeviz);
                }

                _context.SaveChanges();
                MessageBox.Show("Deviz salvat cu succes!");

                RefreshDevizeList();
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvare: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedDeviz != null)
            {
                var result = MessageBox.Show(
                    "Sigur doriți să ștergeți acest deviz?",
                    "Confirmare ștergere",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _context.Devize.Remove(_selectedDeviz);
                        _context.SaveChanges();
                        MessageBox.Show("Deviz șters cu succes!");

                        RefreshDevizeList();
                        ClearSelection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Eroare la ștergere: {ex.Message}");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }
    }
}