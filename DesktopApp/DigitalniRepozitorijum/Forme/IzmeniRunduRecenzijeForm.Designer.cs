namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniRunduRecenzijeForm
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
            numBrojRunde = new NumericUpDown();
            datumPost = new DateTimePicker();
            btnOdustani = new Button();
            btnPotvrdi = new Button();
            lblBrojRunde = new Label();
            lblDatumPostavljanja = new Label();
            lblOdluka = new Label();
            txtKonacnaOdluka = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numBrojRunde).BeginInit();
            SuspendLayout();
            // 
            // numBrojRunde
            // 
            numBrojRunde.Location = new Point(152, 12);
            numBrojRunde.Name = "numBrojRunde";
            numBrojRunde.Size = new Size(230, 23);
            numBrojRunde.TabIndex = 71;
            // 
            // datumPost
            // 
            datumPost.CustomFormat = "dd/MM/yyyy";
            datumPost.Format = DateTimePickerFormat.Custom;
            datumPost.Location = new Point(152, 48);
            datumPost.Name = "datumPost";
            datumPost.Size = new Size(230, 23);
            datumPost.TabIndex = 70;
            // 
            // btnOdustani
            // 
            btnOdustani.DialogResult = DialogResult.Cancel;
            btnOdustani.Location = new Point(272, 130);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 69;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(152, 130);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(110, 32);
            btnPotvrdi.TabIndex = 68;
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // lblBrojRunde
            // 
            lblBrojRunde.AutoSize = true;
            lblBrojRunde.Location = new Point(12, 15);
            lblBrojRunde.Name = "lblBrojRunde";
            lblBrojRunde.Size = new Size(65, 15);
            lblBrojRunde.TabIndex = 64;
            lblBrojRunde.Text = "Broj runde:";
            // 
            // lblDatumPostavljanja
            // 
            lblDatumPostavljanja.AutoSize = true;
            lblDatumPostavljanja.Location = new Point(12, 50);
            lblDatumPostavljanja.Name = "lblDatumPostavljanja";
            lblDatumPostavljanja.Size = new Size(46, 15);
            lblDatumPostavljanja.TabIndex = 65;
            lblDatumPostavljanja.Text = "Datum:";
            // 
            // lblOdluka
            // 
            lblOdluka.AutoSize = true;
            lblOdluka.Location = new Point(12, 85);
            lblOdluka.Name = "lblOdluka";
            lblOdluka.Size = new Size(95, 15);
            lblOdluka.TabIndex = 66;
            lblOdluka.Text = "Konacna odluka:";
            // 
            // txtKonacnaOdluka
            // 
            txtKonacnaOdluka.Location = new Point(152, 82);
            txtKonacnaOdluka.Name = "txtKonacnaOdluka";
            txtKonacnaOdluka.Size = new Size(230, 23);
            txtKonacnaOdluka.TabIndex = 67;
            // 
            // IzmeniRunduRecenzijeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 182);
            Controls.Add(numBrojRunde);
            Controls.Add(datumPost);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblBrojRunde);
            Controls.Add(lblDatumPostavljanja);
            Controls.Add(lblOdluka);
            Controls.Add(txtKonacnaOdluka);
            Name = "IzmeniRunduRecenzijeForm";
            Text = "IzmeniRunduRecenzijeForm";
            Load += IzmeniRunduRecenzijeForm_Load;
            ((System.ComponentModel.ISupportInitialize)numBrojRunde).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numBrojRunde;
        private DateTimePicker datumPost;
        private Button btnOdustani;
        private Button btnPotvrdi;
        private Label lblBrojRunde;
        private Label lblDatumPostavljanja;
        private Label lblOdluka;
        private TextBox txtKonacnaOdluka;
    }
}