using DigitalniRepozitorijum.Forme;
using System.Windows.Forms;

namespace DigitalniRepozitorijum;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnPublikacija_Click(object sender, EventArgs e)
    {
        PublikacijeForm form = new PublikacijeForm();
        form.ShowDialog();
    }

    private void btnIstrazivaci_Click(object sender, EventArgs e)
    {
        IstrazivaciForm form = new IstrazivaciForm();
        form.ShowDialog();
    }

    private void btnInstitucije_Click(object sender, EventArgs e)
    {
        InstitucijeForm form = new InstitucijeForm();
        form.ShowDialog();
    }
    
}
