namespace CarServiceEstimator
{
    partial class ClientForm
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Declare controls as private fields
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAddClient;

        #region Windows Form Designer generated code
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Car Service Estimator";

            // Initialize DataGridView
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Size = new System.Drawing.Size(760, 350);
            this.dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Initialize Load Data button
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.Location = new System.Drawing.Point(13, 380);
            this.btnLoadData.Size = new System.Drawing.Size(100, 30);
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);

            // Initialize TextBoxes
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();

            this.txtName.Location = new System.Drawing.Point(13, 420);
            this.txtName.Size = new System.Drawing.Size(120, 23);
            this.txtName.PlaceholderText = "Name";

            this.txtPhone.Location = new System.Drawing.Point(150, 420);
            this.txtPhone.Size = new System.Drawing.Size(120, 23);
            this.txtPhone.PlaceholderText = "Phone";

            this.txtAddress.Location = new System.Drawing.Point(300, 420);
            this.txtAddress.Size = new System.Drawing.Size(120, 23);
            this.txtAddress.PlaceholderText = "Address";

            // Initialize Add Client button
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.Location = new System.Drawing.Point(450, 420);
            this.btnAddClient.Size = new System.Drawing.Size(100, 30);
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);

            // Add controls to form
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnAddClient);
        }
        #endregion
    }
}
