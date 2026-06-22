namespace DigitalniRepozitorijum.Forme
{
    partial class DodajUrednikaPoglavljaForm
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
            btnPotvrdi.TabIndex = 50;
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
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // DodajUrednikaPoglavljaForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 175);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblUrednik);
            Controls.Add(txtUrednik);
            Name = "DodajUrednikaPoglavljaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj urednika poglavlja";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblUrednik;
        private System.Windows.Forms.TextBox txtUrednik;
    }
}
