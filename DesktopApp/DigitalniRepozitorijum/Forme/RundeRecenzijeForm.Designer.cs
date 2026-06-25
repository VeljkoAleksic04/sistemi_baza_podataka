namespace DigitalniRepozitorijum.Forme
{
    partial class RundeRecenzijeForm
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
            BrojRunde = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            KonacnaOdluka = new DataGridViewTextBoxColumn();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnUrednik = new Button();
            label1 = new Label();
            btnRecenzenti = new Button();
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
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Lista rundi recenzije";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colId, BrojRunde, Datum, KonacnaOdluka });
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
            // BrojRunde
            // 
            BrojRunde.HeaderText = "Broj Runde";
            BrojRunde.Name = "BrojRunde";
            BrojRunde.ReadOnly = true;
            // 
            // Datum
            // 
            Datum.HeaderText = "Datum";
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // KonacnaOdluka
            // 
            KonacnaOdluka.HeaderText = "Konacna Odluka";
            KonacnaOdluka.Name = "KonacnaOdluka";
            KonacnaOdluka.ReadOnly = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(489, 12);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(240, 32);
            btnDodaj.TabIndex = 11;
            btnDodaj.Text = "Dodaj rundu recenzije";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(489, 50);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(240, 32);
            btnIzmeni.TabIndex = 12;
            btnIzmeni.Text = "Izmeni rundu recenzije";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(489, 88);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(240, 32);
            btnObrisi.TabIndex = 13;
            btnObrisi.Text = "Obrisi rundu recenzije";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnUrednik
            // 
            btnUrednik.Location = new Point(489, 154);
            btnUrednik.Name = "btnUrednik";
            btnUrednik.Size = new Size(240, 32);
            btnUrednik.TabIndex = 14;
            btnUrednik.Text = "Urednik";
            btnUrednik.UseVisualStyleBackColor = true;
            btnUrednik.Click += btnUrednik_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(489, 136);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 15;
            label1.Text = "Povezani podaci";
            // 
            // btnRecenzenti
            // 
            btnRecenzenti.Location = new Point(489, 192);
            btnRecenzenti.Name = "btnRecenzenti";
            btnRecenzenti.Size = new Size(240, 32);
            btnRecenzenti.TabIndex = 16;
            btnRecenzenti.Text = "Recenzenti";
            btnRecenzenti.UseVisualStyleBackColor = true;
            btnRecenzenti.Click += btnRecenzenti_Click;
            // 
            // RundeRecenzijeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 333);
            Controls.Add(btnRecenzenti);
            Controls.Add(label1);
            Controls.Add(btnUrednik);
            Controls.Add(btnDodaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Controls.Add(groupBox);
            Name = "RundeRecenzijeForm";
            Text = "RundeRecenzijeForm";
            Load += RundeRecenzijeForm_Load;
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn BrojRunde;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn KonacnaOdluka;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Button btnUrednik;
        private Label label1;
        private Button btnRecenzenti;
    }
}