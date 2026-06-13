namespace DigitalniRepozitorijum.Forme
{
    partial class DodajAutoraPublikacijeForm
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
            this.SuspendLayout();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(20, 20);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(120, 15);
            this.lblAutor.TabIndex = 0;
            this.lblAutor.Text = "Autor:";
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAutor.Location = new System.Drawing.Point(160, 17);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(230, 23);
            this.txtAutor.TabIndex = 1;
            this.lblRedosled = new System.Windows.Forms.Label();
            this.lblRedosled.AutoSize = true;
            this.lblRedosled.Location = new System.Drawing.Point(20, 55);
            this.lblRedosled.Name = "lblRedosled";
            this.lblRedosled.Size = new System.Drawing.Size(120, 15);
            this.lblRedosled.TabIndex = 0;
            this.lblRedosled.Text = "Redosled:";
            this.txtRedosled = new System.Windows.Forms.TextBox();
            this.txtRedosled.Location = new System.Drawing.Point(160, 52);
            this.txtRedosled.Name = "txtRedosled";
            this.txtRedosled.Size = new System.Drawing.Size(230, 23);
            this.txtRedosled.TabIndex = 1;
            this.lblTipDoprinosa = new System.Windows.Forms.Label();
            this.lblTipDoprinosa.AutoSize = true;
            this.lblTipDoprinosa.Location = new System.Drawing.Point(20, 90);
            this.lblTipDoprinosa.Name = "lblTipDoprinosa";
            this.lblTipDoprinosa.Size = new System.Drawing.Size(120, 15);
            this.lblTipDoprinosa.TabIndex = 0;
            this.lblTipDoprinosa.Text = "Tip doprinosa:";
            this.txtTipDoprinosa = new System.Windows.Forms.TextBox();
            this.txtTipDoprinosa.Location = new System.Drawing.Point(160, 87);
            this.txtTipDoprinosa.Name = "txtTipDoprinosa";
            this.txtTipDoprinosa.Size = new System.Drawing.Size(230, 23);
            this.txtTipDoprinosa.TabIndex = 1;
            this.lblUloga = new System.Windows.Forms.Label();
            this.lblUloga.AutoSize = true;
            this.lblUloga.Location = new System.Drawing.Point(20, 125);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(120, 15);
            this.lblUloga.TabIndex = 0;
            this.lblUloga.Text = "Uloga:";
            this.txtUloga = new System.Windows.Forms.TextBox();
            this.txtUloga.Location = new System.Drawing.Point(160, 122);
            this.txtUloga.Name = "txtUloga";
            this.txtUloga.Size = new System.Drawing.Size(230, 23);
            this.txtUloga.TabIndex = 1;
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnPotvrdi.Location = new System.Drawing.Point(160, 170);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(110, 32);
            this.btnPotvrdi.TabIndex = 50;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(280, 170);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(110, 32);
            this.btnOdustani.TabIndex = 51;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.AcceptButton = this.btnPotvrdi;
            this.CancelButton = this.btnOdustani;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblRedosled);
            this.Controls.Add(this.txtRedosled);
            this.Controls.Add(this.lblTipDoprinosa);
            this.Controls.Add(this.txtTipDoprinosa);
            this.Controls.Add(this.lblUloga);
            this.Controls.Add(this.txtUloga);
            this.Name = "DodajAutoraPublikacijeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj autora";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblRedosled;
        private System.Windows.Forms.TextBox txtRedosled;
        private System.Windows.Forms.Label lblTipDoprinosa;
        private System.Windows.Forms.TextBox txtTipDoprinosa;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.TextBox txtUloga;
    }
}
