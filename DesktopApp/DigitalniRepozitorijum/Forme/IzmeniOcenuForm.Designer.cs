namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniOcenuForm
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
            lblKriterijum = new Label();
            txtKriterijum = new TextBox();
            btnOdustani = new Button();
            btnPotvrdi = new Button();
            lbOcena = new Label();
            txtOcena = new TextBox();
            SuspendLayout();
            // 
            // lblKriterijum
            // 
            lblKriterijum.AutoSize = true;
            lblKriterijum.Location = new Point(19, 52);
            lblKriterijum.Name = "lblKriterijum";
            lblKriterijum.Size = new Size(62, 15);
            lblKriterijum.TabIndex = 62;
            lblKriterijum.Text = "Kriterijum:";
            // 
            // txtKriterijum
            // 
            txtKriterijum.Location = new Point(159, 49);
            txtKriterijum.Name = "txtKriterijum";
            txtKriterijum.Size = new Size(230, 23);
            txtKriterijum.TabIndex = 63;
            // 
            // btnOdustani
            // 
            btnOdustani.DialogResult = DialogResult.Cancel;
            btnOdustani.Location = new Point(279, 92);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 61;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(159, 92);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(110, 32);
            btnPotvrdi.TabIndex = 60;
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // lbOcena
            // 
            lbOcena.AutoSize = true;
            lbOcena.Location = new Point(19, 15);
            lbOcena.Name = "lbOcena";
            lbOcena.Size = new Size(44, 15);
            lbOcena.TabIndex = 58;
            lbOcena.Text = "Ocena:";
            // 
            // txtOcena
            // 
            txtOcena.Location = new Point(159, 12);
            txtOcena.Name = "txtOcena";
            txtOcena.Size = new Size(230, 23);
            txtOcena.TabIndex = 59;
            // 
            // IzmeniOcenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 145);
            Controls.Add(lblKriterijum);
            Controls.Add(txtKriterijum);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lbOcena);
            Controls.Add(txtOcena);
            Name = "IzmeniOcenuForm";
            Text = "IzmeniOcenuForm";
            Load += IzmeniOcenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKriterijum;
        private TextBox txtKriterijum;
        private Button btnOdustani;
        private Button btnPotvrdi;
        private Label lbOcena;
        private TextBox txtOcena;
    }
}