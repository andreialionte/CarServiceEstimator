using CarServiceEstimator.Helpers;
using CarServiceEstimator.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace CarServiceEstimator
{
    public partial class ClientForm : Form
    {
        private readonly DataContext _dbContext;
        private readonly BindingList<Client> _clients;


        public ClientForm(DataContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            // Initialize DbContext
            //var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            // Initialize BindingList for DataGridView
            _clients = new BindingList<Client>();
            dataGridView1.DataSource = _clients;

            // Configure DataGridView
            ConfigureDataGridView();

            // Load data on form load
            this.Load += Form1_Load;
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeClient",
                HeaderText = "Nume Client",
                Width = 200
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NrTelefon",
                HeaderText = "Telefon",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Adresa",
                HeaderText = "Adresa",
                Width = 300
            });
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async void btnLoadData_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                _clients.Clear();
                var clients = await _dbContext.Clienti.ToListAsync();
                foreach (var client in clients)
                {
                    _clients.Add(client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddClient_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    var client = new Client
                    {
                        NumeClient = txtName.Text,
                        NrTelefon = txtPhone.Text,
                        Adresa = txtAddress.Text
                    };

                    _dbContext.Clienti.Add(client);
                    await _dbContext.SaveChangesAsync();

                    // Clear input fields
                    txtName.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();

                    // Reload data
                    await LoadDataAsync();

                    MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _dbContext.Dispose();
        }
    }
}
