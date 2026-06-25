namespace DigitalniRepozitorijum.Forme
{
    partial class RecenzentiForm
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
            groupBox = new GroupBox();
            dataGridView = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            Recenzent = new DataGridViewTextBoxColumn();
            Preporuka = new DataGridViewTextBoxColumn();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnNizOcena = new Button();
            label1 = new Label();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(dataGridView);
            groupBox.Location = new Point(12, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(449, 283);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Lista recenzenata";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colId, Recenzent, Preporuka });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(443, 261);
            dataGridView.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // Recenzent
            // 
            Recenzent.HeaderText = "Recenzent";
            Recenzent.Name = "Recenzent";
            Recenzent.ReadOnly = true;
            // 
            // Preporuka
            // 
            Preporuka.HeaderText = "Preporuka";
            Preporuka.Name = "Preporuka";
            Preporuka.ReadOnly = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(481, 12);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(240, 32);
            btnDodaj.TabIndex = 14;
            btnDodaj.Text = "Dodaj recenzenta";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(481, 50);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(240, 32);
            btnIzmeni.TabIndex = 15;
            btnIzmeni.Text = "Izmeni recenzenta";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(481, 88);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(240, 32);
            btnObrisi.TabIndex = 16;
            btnObrisi.Text = "Obrisi recenzenta";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnNizOcena
            // 
            btnNizOcena.Location = new Point(481, 160);
            btnNizOcena.Name = "btnNizOcena";
            btnNizOcena.Size = new Size(240, 32);
            btnNizOcena.TabIndex = 17;
            btnNizOcena.Text = "Niz ocena u rundi";
            btnNizOcena.UseVisualStyleBackColor = true;
            btnNizOcena.Click += btnNizOcena_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(481, 142);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 18;
            label1.Text = "Povezani podaci";
            // 
            // RecenzentiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 353);
            Controls.Add(label1);
            Controls.Add(btnNizOcena);
            Controls.Add(btnDodaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Controls.Add(groupBox);
            Name = "RecenzentiForm";
            Text = "RecenzentiForm";
            Load += RecenzentiForm_Load;
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private DataGridView dataGridView;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Button btnNizOcena;
        private Label label1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn Recenzent;
        private DataGridViewTextBoxColumn Preporuka;
    }
}