namespace DigitalniRepozitorijum;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        imageList1 = new ImageList(components);
        pictureBox1 = new PictureBox();
        label1 = new Label();
        btnPublikacija = new Button();
        btnIstrazivaci = new Button();
        btnInstitucije = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // imageList1
        // 
        imageList1.ColorDepth = ColorDepth.Depth32Bit;
        imageList1.ImageSize = new Size(16, 16);
        imageList1.TransparentColor = Color.Transparent;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources._2997608;
        pictureBox1.Location = new Point(12, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(335, 137);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Stencil", 18F);
        label1.ForeColor = Color.DarkOrange;
        label1.Location = new Point(16, 161);
        label1.Name = "label1";
        label1.Size = new Size(326, 29);
        label1.TabIndex = 3;
        label1.Text = "DIGITALNI REPOZITORIJUM";
        // 
        // btnPublikacija
        // 
        btnPublikacija.Location = new Point(122, 210);
        btnPublikacija.Name = "btnPublikacija";
        btnPublikacija.Size = new Size(119, 46);
        btnPublikacija.TabIndex = 4;
        btnPublikacija.Text = "Publikacija";
        btnPublikacija.UseVisualStyleBackColor = true;
        btnPublikacija.Click += btnPublikacija_Click;
        // 
        // btnIstrazivaci
        // 
        btnIstrazivaci.Location = new Point(122, 262);
        btnIstrazivaci.Name = "btnIstrazivaci";
        btnIstrazivaci.Size = new Size(119, 46);
        btnIstrazivaci.TabIndex = 5;
        btnIstrazivaci.Text = "Istraživači";
        btnIstrazivaci.UseVisualStyleBackColor = true;
        btnIstrazivaci.Click += btnIstrazivaci_Click;
        // 
        // btnInstitucije
        // 
        btnInstitucije.Location = new Point(122, 314);
        btnInstitucije.Name = "btnInstitucije";
        btnInstitucije.Size = new Size(119, 46);
        btnInstitucije.TabIndex = 6;
        btnInstitucije.Text = "Institucije";
        btnInstitucije.UseVisualStyleBackColor = true;
        btnInstitucije.Click += btnInstitucije_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(359, 380);
        Controls.Add(btnInstitucije);
        Controls.Add(btnIstrazivaci);
        Controls.Add(btnPublikacija);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ImageList imageList1;
    private PictureBox pictureBox1;
    private Label label1;
    private Button btnPublikacija;
    private Button btnIstrazivaci;
    private Button btnInstitucije;
}
