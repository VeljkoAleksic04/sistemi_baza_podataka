namespace DigitalniRepozitorijum.Forme
{
    partial class DodajUrednikaKnjigeForm
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
            lblUrednik = new Label();
            txtUrednik = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lblUrednik
            // 
            lblUrednik.AutoSize = true;
            lblUrednik.Location = new Point(20, 20);
            lblUrednik.Name = "lblUrednik";
            lblUrednik.Size = new Size(51, 15);
            lblUrednik.TabIndex = 0;
            lblUrednik.Text = "Urednik:";
            // 
            // txtUrednik
            // 
            txtUrednik.Location = new Point(160, 17);
            txtUrednik.Name = "txtUrednik";
            txtUrednik.Size = new Size(230, 23);
            txtUrednik.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 65);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(110, 32);
            btnPotvrdi.TabIndex = 2;
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.DialogResult = DialogResult.Cancel;
            btnOdustani.Location = new Point(280, 65);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 3;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // DodajUrednikaKnjigeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 130);
            Controls.Add(lblUrednik);
            Controls.Add(txtUrednik);
            Controls.Add(btnPotvrdi);
            Controls.Add(btnOdustani);
            Name = "DodajUrednikaKnjigeForm";
            Text = "Dodaj urednika knjige";
            Load += DodajUrednikaKnjigeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        private Label lblUrednik;
        private TextBox txtUrednik;
        private Button btnPotvrdi;
        private Button btnOdustani;
    }
}
