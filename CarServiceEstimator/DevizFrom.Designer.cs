namespace CarServiceEstimator
{
    partial class DevizForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewDevize;
        private System.Windows.Forms.DataGridView dataGridViewDevizContinut;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveDevizContinut;
        private System.Windows.Forms.Button btnDeleteDevizContinut;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxReper;
        private System.Windows.Forms.TextBox txtDevizName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeviz;
        private System.Windows.Forms.Label lblDevize;
        private System.Windows.Forms.Label lblDevizContinut;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblReper;
        private System.Windows.Forms.Label lblDevizName;
        private System.Windows.Forms.Label lblDataDeviz;
        private System.Windows.Forms.Button btnAddDeviz;
        private System.Windows.Forms.Panel panelDevizDetails;

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
            this.components = new System.ComponentModel.Container();

            // main controls
            this.dataGridViewDevize = new System.Windows.Forms.DataGridView();
            this.dataGridViewDevizContinut = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddDeviz = new System.Windows.Forms.Button();
            this.btnSaveDevizContinut = new System.Windows.Forms.Button();
            this.btnDeleteDevizContinut = new System.Windows.Forms.Button();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxReper = new System.Windows.Forms.ComboBox();
            this.txtDevizName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDeviz = new System.Windows.Forms.DateTimePicker();
            this.panelDevizDetails = new System.Windows.Forms.Panel();

            // labels
            this.lblDevize = new System.Windows.Forms.Label();
            this.lblDevizContinut = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblReper = new System.Windows.Forms.Label();
            this.lblDevizName = new System.Windows.Forms.Label();
            this.lblDataDeviz = new System.Windows.Forms.Label();

            // DataGridViews
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevizContinut)).BeginInit();

            // Main form layout
            this.SuspendLayout();

            // configure dataGridViewDevize
            this.dataGridViewDevize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDevize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevize.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewDevize.Name = "dataGridViewDevize";
            this.dataGridViewDevize.Size = new System.Drawing.Size(800, 200);
            this.dataGridViewDevize.TabIndex = 0;
            this.dataGridViewDevize.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDevize.MultiSelect = false;
            this.dataGridViewDevize.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDevize.ReadOnly = true;
            this.dataGridViewDevize.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDevize_CellClick);

            // configure action buttons
            this.btnAddDeviz.Location = new System.Drawing.Point(12, 12);
            this.btnAddDeviz.Name = "btnAddDeviz";
            this.btnAddDeviz.Size = new System.Drawing.Size(120, 30);
            this.btnAddDeviz.TabIndex = 1;
            this.btnAddDeviz.Text = "Adaugă Deviz";
            this.btnAddDeviz.Click += new System.EventHandler(this.btnAddDeviz_Click);

            this.btnSave.Location = new System.Drawing.Point(142, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvează";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnDelete.Location = new System.Drawing.Point(272, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Șterge";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnCancel.Location = new System.Drawing.Point(402, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Anulează";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // configure details panel
            this.panelDevizDetails.Location = new System.Drawing.Point(12, 260);
            this.panelDevizDetails.Size = new System.Drawing.Size(800, 200);
            this.panelDevizDetails.BorderStyle = BorderStyle.FixedSingle;

            // configure input controls
            this.lblDevizName.Location = new System.Drawing.Point(20, 10);
            this.lblDevizName.Size = new System.Drawing.Size(100, 23);
            this.lblDevizName.Text = "Nume Deviz:";

            this.txtDevizName.Location = new System.Drawing.Point(120, 10);
            this.txtDevizName.Size = new System.Drawing.Size(200, 23);

            this.lblClient.Location = new System.Drawing.Point(20, 40);
            this.lblClient.Size = new System.Drawing.Size(100, 23);
            this.lblClient.Text = "Client:";

            this.comboBoxClient.Location = new System.Drawing.Point(120, 40);
            this.comboBoxClient.Size = new System.Drawing.Size(200, 23);

            this.lblDataDeviz.Location = new System.Drawing.Point(20, 70);
            this.lblDataDeviz.Size = new System.Drawing.Size(100, 23);
            this.lblDataDeviz.Text = "Data:";

            this.dateTimePickerDeviz.Location = new System.Drawing.Point(120, 70);
            this.dateTimePickerDeviz.Size = new System.Drawing.Size(200, 23);

            // add controls to panel
            this.panelDevizDetails.Controls.Add(this.lblDevizName);
            this.panelDevizDetails.Controls.Add(this.txtDevizName);
            this.panelDevizDetails.Controls.Add(this.lblClient);
            this.panelDevizDetails.Controls.Add(this.comboBoxClient);
            this.panelDevizDetails.Controls.Add(this.lblDataDeviz);
            this.panelDevizDetails.Controls.Add(this.dateTimePickerDeviz);

            // configure form
            this.ClientSize = new System.Drawing.Size(824, 600);
            this.Controls.Add(this.dataGridViewDevize);
            this.Controls.Add(this.btnAddDeviz);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelDevizDetails);
            this.MinimumSize = new System.Drawing.Size(840, 640);
            this.Name = "DevizForm";
            this.Text = "Gestionare Devize";
            this.Load += new System.EventHandler(this.DevizForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevizContinut)).EndInit();
            this.ResumeLayout(false);
        }
    }
}