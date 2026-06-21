namespace DigitalniRepozitorijum.Forme
{
    partial class DodajFajlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOdustani = new Button();
            btnPotvrdi = new Button();
            lblPutanja = new Label();
            txtPutanja = new TextBox();
            SuspendLayout();
            // 
            // btnOdustani
            // 
            btnOdustani.DialogResult = DialogResult.Cancel;
            btnOdustani.Location = new Point(229, 67);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 55;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(109, 67);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(110, 32);
            btnPotvrdi.TabIndex = 54;
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // lblPutanja
            // 
            lblPutanja.AutoSize = true;
            lblPutanja.Location = new Point(16, 22);
            lblPutanja.Name = "lblPutanja";
            lblPutanja.Size = new Size(50, 15);
            lblPutanja.TabIndex = 52;
            lblPutanja.Text = "Putanja:";
            // 
            // txtPutanja
            // 
            txtPutanja.Location = new Point(109, 19);
            txtPutanja.Name = "txtPutanja";
            txtPutanja.Size = new Size(230, 23);
            txtPutanja.TabIndex = 53;
            // 
            // DodajFajlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 142);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblPutanja);
            Controls.Add(txtPutanja);
            Name = "DodajFajlForm";
            Text = "DodajFajlForm";
            Load += DodajFajlForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOdustani;
        private Button btnPotvrdi;
        private Label lblPutanja;
        private TextBox txtPutanja;
    }
}