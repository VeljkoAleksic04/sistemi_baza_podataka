namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniPovezanuPublikacijuForm
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
            lblTipPovezanosti = new Label();
            txtTipPovezanosti = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lblTipPovezanosti
            // 
            lblTipPovezanosti.AutoSize = true;
            lblTipPovezanosti.Location = new Point(20, 20);
            lblTipPovezanosti.Name = "lblTipPovezanosti";
            lblTipPovezanosti.Size = new Size(92, 15);
            lblTipPovezanosti.TabIndex = 0;
            lblTipPovezanosti.Text = "Tip povezanosti:";
            // 
            // txtTipPovezanosti
            // 
            txtTipPovezanosti.Location = new Point(160, 17);
            txtTipPovezanosti.Name = "txtTipPovezanosti";
            txtTipPovezanosti.Size = new Size(230, 23);
            txtTipPovezanosti.TabIndex = 1;
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
            // 
            // IzmeniPovezanuPublikacijuForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 175);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblTipPovezanosti);
            Controls.Add(txtTipPovezanosti);
            Name = "IzmeniPovezanuPublikacijuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni povezanu publikaciju";
            Load += IzmeniPovezanuPublikacijuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblTipPovezanosti;
        private System.Windows.Forms.TextBox txtTipPovezanosti;
    }
}
