namespace CarServiceEstimator
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem devizeMenu;
        private System.Windows.Forms.ToolStripMenuItem clientiMenu;
        private System.Windows.Forms.ToolStripMenuItem reperMenu;  // Adăugat noul meniu pentru "Reper"
        private System.Windows.Forms.Label statisticsLabel;
        private System.Windows.Forms.ListView devizeListView;
        private System.Windows.Forms.Button addDevizButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.devizeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reperMenu = new System.Windows.Forms.ToolStripMenuItem();  // Crearea meniului "Reper"
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.devizeListView = new System.Windows.Forms.ListView();
            this.addDevizButton = new System.Windows.Forms.Button();

            // MenuStrip
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.devizeMenu,
                this.clientiMenu,
                this.reperMenu // Adăugarea "Reper" în meniu
            });

            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;

            // Devize Menu
            this.devizeMenu.Text = "Devize";
            this.devizeMenu.Click += new EventHandler(this.DevizeMenu_Click);

            // Clienti Menu
            this.clientiMenu.Text = "Clienți";
            this.clientiMenu.Click += new EventHandler(this.ClientiMenu_Click);

            // Reper Menu (nou adăugat)
            this.reperMenu.Text = "Reper";
            this.reperMenu.Click += new EventHandler(this.ReperMenu_Click); // Adăugăm evenimentul pentru click pe "Reper"

            // Statistics Label
            this.statisticsLabel.Text = "Statistici generale:";
            this.statisticsLabel.Location = new System.Drawing.Point(20, 40);
            this.statisticsLabel.Size = new System.Drawing.Size(200, 30);

            // Devize ListView
            this.devizeListView.Location = new System.Drawing.Point(20, 80);
            this.devizeListView.Size = new System.Drawing.Size(300, 200);
            this.devizeListView.View = System.Windows.Forms.View.Details;
            this.devizeListView.Columns.Add("ID Deviz", 100);
            this.devizeListView.Columns.Add("Data", 100);
            this.devizeListView.Columns.Add("Client", 100);

            // Add Deviz Button
            this.addDevizButton.Text = "Adaugă Deviz";
            this.addDevizButton.Location = new System.Drawing.Point(350, 100);
            this.addDevizButton.Size = new System.Drawing.Size(150, 30);
            this.addDevizButton.Click += new EventHandler(this.AddDevizButton_Click);

            // DashboardForm
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statisticsLabel);
            this.Controls.Add(this.devizeListView);
            this.Controls.Add(this.addDevizButton);
            this.MainMenuStrip = this.menuStrip;
            this.Text = "Dashboard";
        }

        private void ReperMenu_Click(object sender, EventArgs e)
        {
            ReperForm reperForm = new ReperForm(_context);
            reperForm.Reperform(); // Call the method that handles "Reperform" logic

            // Show the ReperForm
            reperForm.Show();
        }
    }
}
