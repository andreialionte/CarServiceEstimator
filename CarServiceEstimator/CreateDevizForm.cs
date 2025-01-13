using CarServiceEstimator.Helpers;
using CarServiceEstimator.Models;

namespace CarServiceEstimator
{
    public partial class CreateDevizForm : Form
    {
        private readonly DataContext _context;

        public CreateDevizForm(DataContext context)
        {
            _context = context;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Încarcă datele pentru ComboBox-ul Client
            comboBoxClient.DataSource = _context.Clienti.ToList();
            comboBoxClient.DisplayMember = "NumeClient";
            comboBoxClient.ValueMember = "IdClient";

            // Încarcă datele pentru ComboBox-ul Reper
            comboBoxReper.DataSource = _context.Repere.ToList();
            comboBoxReper.DisplayMember = "NumeReper";
            comboBoxReper.ValueMember = "IdReper";
        }

        // Butonul pentru salvarea unui deviz
        private void btnSaveDeviz_Click(object sender, EventArgs e)
        {
            try
            {
                var deviz = new Deviz
                {
                    IdDeviz = Guid.NewGuid(),
                    DenumireDeviz = txtDenumireDeviz.Text,
                    DataDeviz = dateTimePickerDataDeviz.Value,
                    IdClient = (Guid)comboBoxClient.SelectedValue,
                    MarcaModel = txtMarcaModel.Text,
                    NrInmatriculare = txtNrInmatriculare.Text
                };

                // Salvăm devizul în baza de date
                _context.Devize.Add(deviz);
                _context.SaveChanges();
                MessageBox.Show("Devizul a fost adăugat cu succes!");

                // Adăugăm DevizContinut pentru reperul selectat
                if (int.TryParse(txtCantitate.Text, out int cantitate) && decimal.TryParse(txtPretUnitar.Text, out decimal pretUnitar))
                {
                    var reperSelectat = (Reper)comboBoxReper.SelectedItem;
                    var devizContinut = new DevizContinut
                    {
                        IdDevizContinut = Guid.NewGuid(),
                        IdDeviz = deviz.IdDeviz,
                        IdReper = reperSelectat.IdReper,
                        PretUnitar = pretUnitar,
                        Cantitate = cantitate
                    };

                    _context.ContinuturiDevize.Add(devizContinut);
                    _context.SaveChanges();
                    MessageBox.Show("Continutul devizului a fost adăugat cu succes!");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}");
            }
        }

        // Butonul pentru anularea acțiunii
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
