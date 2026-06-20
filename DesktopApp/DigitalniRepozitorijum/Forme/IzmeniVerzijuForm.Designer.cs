namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniVerzijuForm
    {
        private System.ComponentModel.IContainer components = null;

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
            lblBrojVerzije = new Label();
            txtBrojVerzije = new TextBox();
            lblDatumPostavljanja = new Label();
            lblOpisIzmene = new Label();
            txtOpisIzmene = new TextBox();
            lblOdgovornaOsoba = new Label();
            txtOdgovornaOsoba = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // lblBrojVerzije
            // 
            lblBrojVerzije.AutoSize = true;
            lblBrojVerzije.Location = new Point(20, 20);
            lblBrojVerzije.Name = "lblBrojVerzije";
            lblBrojVerzije.Size = new Size(67, 15);
            lblBrojVerzije.TabIndex = 0;
            lblBrojVerzije.Text = "Broj verzije:";
            // 
            // txtBrojVerzije
            // 
            txtBrojVerzije.Location = new Point(160, 17);
            txtBrojVerzije.Name = "txtBrojVerzije";
            txtBrojVerzije.Size = new Size(230, 23);
            txtBrojVerzije.TabIndex = 1;
            // 
            // lblDatumPostavljanja
            // 
            lblDatumPostavljanja.AutoSize = true;
            lblDatumPostavljanja.Location = new Point(20, 55);
            lblDatumPostavljanja.Name = "lblDatumPostavljanja";
            lblDatumPostavljanja.Size = new Size(46, 15);
            lblDatumPostavljanja.TabIndex = 0;
            lblDatumPostavljanja.Text = "Datum:";
            // 
            // lblOpisIzmene
            // 
            lblOpisIzmene.AutoSize = true;
            lblOpisIzmene.Location = new Point(20, 90);
            lblOpisIzmene.Name = "lblOpisIzmene";
            lblOpisIzmene.Size = new Size(75, 15);
            lblOpisIzmene.TabIndex = 0;
            lblOpisIzmene.Text = "Opis izmene:";
            // 
            // txtOpisIzmene
            // 
            txtOpisIzmene.Location = new Point(160, 87);
            txtOpisIzmene.Name = "txtOpisIzmene";
            txtOpisIzmene.Size = new Size(230, 23);
            txtOpisIzmene.TabIndex = 1;
            // 
            // lblOdgovornaOsoba
            // 
            lblOdgovornaOsoba.AutoSize = true;
            lblOdgovornaOsoba.Location = new Point(20, 125);
            lblOdgovornaOsoba.Name = "lblOdgovornaOsoba";
            lblOdgovornaOsoba.Size = new Size(105, 15);
            lblOdgovornaOsoba.TabIndex = 0;
            lblOdgovornaOsoba.Text = "Odgovorna osoba:";
            // 
            // txtOdgovornaOsoba
            // 
            txtOdgovornaOsoba.Location = new Point(160, 122);
            txtOdgovornaOsoba.Name = "txtOdgovornaOsoba";
            txtOdgovornaOsoba.Size = new Size(230, 23);
            txtOdgovornaOsoba.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 170);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(110, 32);
            btnPotvrdi.TabIndex = 50;
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.DialogResult = DialogResult.Cancel;
            btnOdustani.Location = new Point(280, 170);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(160, 53);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 23);
            dateTimePicker1.TabIndex = 52;
            // 
            // IzmeniVerzijuForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 280);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblBrojVerzije);
            Controls.Add(txtBrojVerzije);
            Controls.Add(lblDatumPostavljanja);
            Controls.Add(lblOpisIzmene);
            Controls.Add(txtOpisIzmene);
            Controls.Add(lblOdgovornaOsoba);
            Controls.Add(txtOdgovornaOsoba);
            Name = "IzmeniVerzijuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni verziju";
            Load += IzmeniVerzijuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblBrojVerzije;
        private System.Windows.Forms.TextBox txtBrojVerzije;
        private System.Windows.Forms.Label lblDatumPostavljanja;
        private System.Windows.Forms.Label lblOpisIzmene;
        private System.Windows.Forms.TextBox txtOpisIzmene;
        private System.Windows.Forms.Label lblOdgovornaOsoba;
        private System.Windows.Forms.TextBox txtOdgovornaOsoba;
        private DateTimePicker dateTimePicker1;
    }
}
