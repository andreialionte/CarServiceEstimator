using CarServiceEstimator.Helpers;

namespace CarServiceEstimator
{
    public partial class StartForm : Form
    {
        private readonly DataContext _context;

        public StartForm(DataContext context)
        {
            _context = context;
            InitializeComponent();
        }

        // Event handler for the About menu item
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an application created by Author Name.", "About");
        }

        // Event handler for Login button click
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Logic to handle login (validate username and password)
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "password")
            {
                MessageBox.Show("Login successful", "Success");
                this.Hide();

                DashboardForm dashForm = new DashboardForm(_context);
                dashForm.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error");
            }
        }
    }
}