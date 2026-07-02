namespace DigitalniRepozitorijum.Forme
{
    partial class DodajPublikacijuForm
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
            btnOdustani = new Button();
            btnNaucniRad = new Button();
            btnPrezentacija = new Button();
            btnKnjiga = new Button();
            btnObrazovni = new Button();
            btnPoglavlje = new Button();
            btnTehnicki = new Button();
            btnSoftverski = new Button();
            btnDataset = new Button();
            btnDoktorska = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnOdustani
            // 
            btnOdustani.DialogResult = DialogResult.Cancel;
            btnOdustani.Location = new Point(360, 276);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnNaucniRad
            // 
            btnNaucniRad.DialogResult = DialogResult.Cancel;
            btnNaucniRad.Location = new Point(12, 44);
            btnNaucniRad.Name = "btnNaucniRad";
            btnNaucniRad.Size = new Size(113, 45);
            btnNaucniRad.TabIndex = 52;
            btnNaucniRad.Text = "Naucni Rad";
            btnNaucniRad.UseVisualStyleBackColor = true;
            btnNaucniRad.Click += btnNaucniRad_Click;
            // 
            // btnPrezentacija
            // 
            btnPrezentacija.DialogResult = DialogResult.Cancel;
            btnPrezentacija.Location = new Point(360, 44);
            btnPrezentacija.Name = "btnPrezentacija";
            btnPrezentacija.Size = new Size(113, 45);
            btnPrezentacija.TabIndex = 53;
            btnPrezentacija.Text = "Prezentacija";
            btnPrezentacija.UseVisualStyleBackColor = true;
            btnPrezentacija.Click += btnPrezentacija_Click;
            // 
            // btnKnjiga
            // 
            btnKnjiga.DialogResult = DialogResult.Cancel;
            btnKnjiga.Location = new Point(244, 44);
            btnKnjiga.Name = "btnKnjiga";
            btnKnjiga.Size = new Size(113, 45);
            btnKnjiga.TabIndex = 54;
            btnKnjiga.Text = "Knjiga";
            btnKnjiga.UseVisualStyleBackColor = true;
            btnKnjiga.Click += btnKnjiga_Click;
            // 
            // btnObrazovni
            // 
            btnObrazovni.DialogResult = DialogResult.Cancel;
            btnObrazovni.Location = new Point(128, 44);
            btnObrazovni.Name = "btnObrazovni";
            btnObrazovni.Size = new Size(113, 45);
            btnObrazovni.TabIndex = 55;
            btnObrazovni.Text = "Obrazovni Materijal";
            btnObrazovni.UseVisualStyleBackColor = true;
            btnObrazovni.Click += btnObrazovni_Click;
            // 
            // btnPoglavlje
            // 
            btnPoglavlje.DialogResult = DialogResult.Cancel;
            btnPoglavlje.Location = new Point(12, 96);
            btnPoglavlje.Name = "btnPoglavlje";
            btnPoglavlje.Size = new Size(113, 45);
            btnPoglavlje.TabIndex = 56;
            btnPoglavlje.Text = "Poglavlje u Knjizi";
            btnPoglavlje.UseVisualStyleBackColor = true;
            btnPoglavlje.Click += btnPoglavlje_Click;
            // 
            // btnTehnicki
            // 
            btnTehnicki.DialogResult = DialogResult.Cancel;
            btnTehnicki.Location = new Point(128, 96);
            btnTehnicki.Name = "btnTehnicki";
            btnTehnicki.Size = new Size(113, 45);
            btnTehnicki.TabIndex = 57;
            btnTehnicki.Text = "Tehnicki Izvestaj";
            btnTehnicki.UseVisualStyleBackColor = true;
            btnTehnicki.Click += btnTehnicki_Click;
            // 
            // btnSoftverski
            // 
            btnSoftverski.DialogResult = DialogResult.Cancel;
            btnSoftverski.Location = new Point(244, 96);
            btnSoftverski.Name = "btnSoftverski";
            btnSoftverski.Size = new Size(113, 45);
            btnSoftverski.TabIndex = 58;
            btnSoftverski.Text = "Softverski Artefakt";
            btnSoftverski.UseVisualStyleBackColor = true;
            btnSoftverski.Click += btnSoftverski_Click;
            // 
            // btnDataset
            // 
            btnDataset.DialogResult = DialogResult.Cancel;
            btnDataset.Location = new Point(360, 96);
            btnDataset.Name = "btnDataset";
            btnDataset.Size = new Size(113, 45);
            btnDataset.TabIndex = 59;
            btnDataset.Text = "Dataset";
            btnDataset.UseVisualStyleBackColor = true;
            btnDataset.Click += btnDataset_Click;
            // 
            // btnDoktorska
            // 
            btnDoktorska.DialogResult = DialogResult.Cancel;
            btnDoktorska.Location = new Point(12, 146);
            btnDoktorska.Name = "btnDoktorska";
            btnDoktorska.Size = new Size(113, 45);
            btnDoktorska.TabIndex = 60;
            btnDoktorska.Text = "Doktorska Disertacija";
            btnDoktorska.UseVisualStyleBackColor = true;
            btnDoktorska.Click += btnDoktorska_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 61;
            label1.Text = "Odaberite tip publikacije:";
            // 
            // DodajPublikacijuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(484, 320);
            Controls.Add(label1);
            Controls.Add(btnDoktorska);
            Controls.Add(btnDataset);
            Controls.Add(btnSoftverski);
            Controls.Add(btnTehnicki);
            Controls.Add(btnPoglavlje);
            Controls.Add(btnObrazovni);
            Controls.Add(btnKnjiga);
            Controls.Add(btnPrezentacija);
            Controls.Add(btnNaucniRad);
            Controls.Add(btnOdustani);
            Name = "DodajPublikacijuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj publikaciju";
            Load += DodajPublikacijuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.Button btnOdustani;
        private Button btnNaucniRad;
        private Button btnPrezentacija;
        private Button btnKnjiga;
        private Button btnObrazovni;
        private Button btnPoglavlje;
        private Button btnTehnicki;
        private Button btnSoftverski;
        private Button btnDataset;
        private Button btnDoktorska;
        private Label label1;
    }
}
