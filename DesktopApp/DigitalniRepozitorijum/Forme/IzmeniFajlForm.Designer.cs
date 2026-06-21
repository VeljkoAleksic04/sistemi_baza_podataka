namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniFajlForm
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
            btnOdustani.Location = new Point(228, 71);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 59;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(108, 71);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(110, 32);
            btnPotvrdi.TabIndex = 58;
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // lblPutanja
            // 
            lblPutanja.AutoSize = true;
            lblPutanja.Location = new Point(15, 26);
            lblPutanja.Name = "lblPutanja";
            lblPutanja.Size = new Size(50, 15);
            lblPutanja.TabIndex = 56;
            lblPutanja.Text = "Putanja:";
            // 
            // txtPutanja
            // 
            txtPutanja.Location = new Point(108, 23);
            txtPutanja.Name = "txtPutanja";
            txtPutanja.Size = new Size(230, 23);
            txtPutanja.TabIndex = 57;
            // 
            // IzmeniFajlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 147);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblPutanja);
            Controls.Add(txtPutanja);
            Name = "IzmeniFajlForm";
            Text = "IzmeniFajlForm";
            Load += IzmeniFajlForm_Load;
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