namespace CarServiceEstimator
{
    partial class ReperForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtReperName;
        private TextBox txtUnitPrice;
        private ComboBox cmbUnitMeasure;
        private PictureBox pbReperImage;
        private Button btnSave;
        private Button btnCancel;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblReperName;
        private Label lblUnitPrice;
        private Label lblUnitMeasure;
        private Label lblReperImage;
        private DataGridView dgvRepere; // Adăugat DataGridView pentru repere

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
            this.dgvRepere = new System.Windows.Forms.DataGridView();
            this.txtReperName = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.cmbUnitMeasure = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvRepere)).BeginInit();
            this.SuspendLayout();

            // dgvRepere
            this.dgvRepere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepere.Location = new System.Drawing.Point(12, 12);
            this.dgvRepere.Name = "dgvRepere";
            this.dgvRepere.Size = new System.Drawing.Size(776, 300);
            this.dgvRepere.TabIndex = 0;
            this.dgvRepere.SelectionChanged += new System.EventHandler(this.dgvRepere_SelectionChanged);

            // txtReperName
            this.txtReperName.Location = new System.Drawing.Point(12, 330);
            this.txtReperName.Name = "txtReperName";
            this.txtReperName.Size = new System.Drawing.Size(200, 20);
            this.txtReperName.TabIndex = 1;

            // txtUnitPrice
            this.txtUnitPrice.Location = new System.Drawing.Point(230, 330);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 2;

            // cmbUnitMeasure
            this.cmbUnitMeasure.FormattingEnabled = true;
            this.cmbUnitMeasure.Items.AddRange(new object[] { "buc", "kg", "litri" });
            this.cmbUnitMeasure.Location = new System.Drawing.Point(350, 330);
            this.cmbUnitMeasure.Name = "cmbUnitMeasure";
            this.cmbUnitMeasure.Size = new System.Drawing.Size(100, 21);
            this.cmbUnitMeasure.TabIndex = 3;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(12, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Salvează";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnEdit
            this.btnEdit.Location = new System.Drawing.Point(93, 370);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Editează";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(174, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Șterge";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // ReperForm
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbUnitMeasure);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtReperName);
            this.Controls.Add(this.dgvRepere);
            this.Name = "ReperForm";
            this.Text = "Gestionare Reper";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
