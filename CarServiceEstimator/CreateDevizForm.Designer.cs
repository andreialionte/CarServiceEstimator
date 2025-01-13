namespace CarServiceEstimator
{
    partial class CreateDevizForm
    {
        private System.ComponentModel.IContainer components = null;

        // TextBox-uri pentru formular
        private System.Windows.Forms.TextBox txtDenumireDeviz;
        private System.Windows.Forms.TextBox txtMarcaModel;
        private System.Windows.Forms.TextBox txtNrInmatriculare;
        private System.Windows.Forms.TextBox txtPretUnitar;
        private System.Windows.Forms.TextBox txtCantitate;

        // ComboBox pentru Client și Reper
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxReper;

        // DateTimePicker pentru DataDeviz
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDeviz;

        // Butoane pentru Save și Cancel
        private System.Windows.Forms.Button btnSaveDeviz;
        private System.Windows.Forms.Button btnCancel;

        // Label-uri
        private System.Windows.Forms.Label lblDenumireDeviz;
        private System.Windows.Forms.Label lblMarcaModel;
        private System.Windows.Forms.Label lblNrInmatriculare;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblDataDeviz;
        private System.Windows.Forms.Label lblReper;
        private System.Windows.Forms.Label lblPretUnitar;
        private System.Windows.Forms.Label lblCantitate;

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
            this.txtDenumireDeviz = new System.Windows.Forms.TextBox();
            this.txtMarcaModel = new System.Windows.Forms.TextBox();
            this.txtNrInmatriculare = new System.Windows.Forms.TextBox();
            this.txtPretUnitar = new System.Windows.Forms.TextBox();
            this.txtCantitate = new System.Windows.Forms.TextBox();

            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxReper = new System.Windows.Forms.ComboBox(); // ComboBox pentru selecția unui singur reper

            this.dateTimePickerDataDeviz = new System.Windows.Forms.DateTimePicker();

            this.btnSaveDeviz = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.lblDenumireDeviz = new System.Windows.Forms.Label();
            this.lblMarcaModel = new System.Windows.Forms.Label();
            this.lblNrInmatriculare = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblDataDeviz = new System.Windows.Forms.Label();
            this.lblReper = new System.Windows.Forms.Label();
            this.lblPretUnitar = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Label-uri
            this.lblDenumireDeviz.Text = "Denumire Deviz:";
            this.lblDenumireDeviz.Location = new System.Drawing.Point(20, 30);
            this.lblMarcaModel.Text = "Marca și Model:";
            this.lblMarcaModel.Location = new System.Drawing.Point(20, 70);
            this.lblNrInmatriculare.Text = "Nr. Inmatriculare:";
            this.lblNrInmatriculare.Location = new System.Drawing.Point(20, 110);
            this.lblClient.Text = "Client:";
            this.lblClient.Location = new System.Drawing.Point(20, 150);
            this.lblDataDeviz.Text = "Data Deviz:";
            this.lblDataDeviz.Location = new System.Drawing.Point(20, 190);
            this.lblReper.Text = "Reper:";
            this.lblReper.Location = new System.Drawing.Point(20, 230);
            this.lblPretUnitar.Text = "Preț Unitar:";
            this.lblPretUnitar.Location = new System.Drawing.Point(20, 340);
            this.lblCantitate.Text = "Cantitate:";
            this.lblCantitate.Location = new System.Drawing.Point(20, 380);

            // TextBox-uri pentru formular
            this.txtDenumireDeviz.Location = new System.Drawing.Point(150, 30);
            this.txtDenumireDeviz.Size = new System.Drawing.Size(200, 20);

            this.txtMarcaModel.Location = new System.Drawing.Point(150, 70);
            this.txtMarcaModel.Size = new System.Drawing.Size(200, 20);

            this.txtNrInmatriculare.Location = new System.Drawing.Point(150, 110);
            this.txtNrInmatriculare.Size = new System.Drawing.Size(200, 20);

            this.comboBoxClient.Location = new System.Drawing.Point(150, 150);
            this.comboBoxClient.Size = new System.Drawing.Size(200, 21);

            this.dateTimePickerDataDeviz.Location = new System.Drawing.Point(150, 190);
            this.dateTimePickerDataDeviz.Size = new System.Drawing.Size(200, 20);

            this.comboBoxReper.Location = new System.Drawing.Point(150, 230); // ComboBox pentru selecția unui reper
            this.comboBoxReper.Size = new System.Drawing.Size(200, 21); // Setează dimensiunea ComboBox-ului

            this.txtPretUnitar.Location = new System.Drawing.Point(150, 340);
            this.txtPretUnitar.Size = new System.Drawing.Size(200, 20);

            this.txtCantitate.Location = new System.Drawing.Point(150, 380);
            this.txtCantitate.Size = new System.Drawing.Size(200, 20);

            // Butoane
            this.btnSaveDeviz.Text = "Salvează";
            this.btnSaveDeviz.Location = new System.Drawing.Point(150, 420);
            this.btnSaveDeviz.Click += new System.EventHandler(this.btnSaveDeviz_Click);

            this.btnCancel.Text = "Anulează";
            this.btnCancel.Location = new System.Drawing.Point(250, 420);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // CreateDevizForm
            this.ClientSize = new System.Drawing.Size(400, 480); // Crește dimensiunea formularului
            this.Controls.Add(this.lblDenumireDeviz);
            this.Controls.Add(this.lblMarcaModel);
            this.Controls.Add(this.lblNrInmatriculare);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblDataDeviz);
            this.Controls.Add(this.lblReper);
            this.Controls.Add(this.lblPretUnitar);
            this.Controls.Add(this.lblCantitate);

            this.Controls.Add(this.txtDenumireDeviz);
            this.Controls.Add(this.txtMarcaModel);
            this.Controls.Add(this.txtNrInmatriculare);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.dateTimePickerDataDeviz);
            this.Controls.Add(this.comboBoxReper); // Adăugăm ComboBox-ul pentru reper
            this.Controls.Add(this.txtPretUnitar);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.btnSaveDeviz);
            this.Controls.Add(this.btnCancel);
            this.Name = "CreateDevizForm";
            this.Text = "Creare Deviz";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
