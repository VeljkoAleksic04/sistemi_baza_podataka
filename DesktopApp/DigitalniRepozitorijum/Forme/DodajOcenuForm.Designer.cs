namespace DigitalniRepozitorijum.Forme
{
    partial class DodajOcenuForm
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
            lbOcena = new Label();
            txtOcena = new TextBox();
            lblKriterijum = new Label();
            txtKriterijum = new TextBox();
            SuspendLayout();
            // 
            // btnOdustani
            // 
            btnOdustani.DialogResult = DialogResult.Cancel;
            btnOdustani.Location = new Point(270, 92);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 55;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(150, 92);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(110, 32);
            btnPotvrdi.TabIndex = 54;
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // lbOcena
            // 
            lbOcena.AutoSize = true;
            lbOcena.Location = new Point(10, 15);
            lbOcena.Name = "lbOcena";
            lbOcena.Size = new Size(44, 15);
            lbOcena.TabIndex = 52;
            lbOcena.Text = "Ocena:";
            // 
            // txtOcena
            // 
            txtOcena.Location = new Point(150, 12);
            txtOcena.Name = "txtOcena";
            txtOcena.Size = new Size(230, 23);
            txtOcena.TabIndex = 53;
            // 
            // lblKriterijum
            // 
            lblKriterijum.AutoSize = true;
            lblKriterijum.Location = new Point(10, 52);
            lblKriterijum.Name = "lblKriterijum";
            lblKriterijum.Size = new Size(62, 15);
            lblKriterijum.TabIndex = 56;
            lblKriterijum.Text = "Kriterijum:";
            // 
            // txtKriterijum
            // 
            txtKriterijum.Location = new Point(150, 49);
            txtKriterijum.Name = "txtKriterijum";
            txtKriterijum.Size = new Size(230, 23);
            txtKriterijum.TabIndex = 57;
            // 
            // DodajOcenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 139);
            Controls.Add(lblKriterijum);
            Controls.Add(txtKriterijum);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lbOcena);
            Controls.Add(txtOcena);
            Name = "DodajOcenuForm";
            Text = "DodajOcenuForm";
            Load += DodajOcenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOdustani;
        private Button btnPotvrdi;
        private Label lbOcena;
        private TextBox txtOcena;
        private Label lblKriterijum;
        private TextBox txtKriterijum;
    }
}