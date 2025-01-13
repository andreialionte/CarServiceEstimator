using CarServiceEstimator.Helpers;
using Microsoft.EntityFrameworkCore;

namespace CarServiceEstimator
{
    public partial class DashboardForm : Form
    {
        private readonly DataContext _context;

        public DashboardForm(DataContext context)
        {
            InitializeComponent();
            _context = context;

            // Eveniment pentru popularea datelor la încărcarea formularului
            this.Load += DashboardForm_Load;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Populează lista de devize la încărcarea formularului
            PopulateDevizeList(devizeListView);
        }

        private void DevizeMenu_Click(object sender, EventArgs e)
        {
            // Deschide formularul pentru devize
            DevizForm devizeForm = new DevizForm(_context);
            devizeForm.Show();
        }

        private void ClientiMenu_Click(object sender, EventArgs e)
        {
            // Deschide formularul pentru clienți
            ClientForm clientiForm = new ClientForm(_context);
            clientiForm.Show();
        }

        private void AddDevizButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Creează și afișează formularul pentru adăugarea unui deviz
                CreateDevizForm addDevizForm = new CreateDevizForm(_context);
                addDevizForm.ShowDialog();  // Folosește ShowDialog() pentru a aștepta închidearea formularului înainte de a reveni la Dashboard
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}");
            }
        }



        private void PopulateDevizeList(ListView listView)
        {
            try
            {
                // Obține primele 10 devize cu relațiile necesare
                var devize = _context.Devize
                    .Include(d => d.Client) // Include relația cu tabela Client
                    .Take(10)
                    .ToList();

                // Curăță lista înainte de a adăuga elemente noi
                listView.Items.Clear();

                // Adaugă fiecare deviz în ListView
                foreach (var deviz in devize)
                {
                    ListViewItem item = new ListViewItem(deviz.IdDeviz.ToString());
                    item.SubItems.Add(deviz.DataDeviz.ToShortDateString());
                    item.SubItems.Add(deviz.Client?.NumeClient ?? "Fără client");
                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Afișează un mesaj de eroare dacă ceva nu merge bine
                MessageBox.Show($"Eroare la încărcarea devizelor: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
