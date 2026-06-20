using System.Drawing;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    internal static class FormStilovi
    {
        public static readonly Color Pozadina = Color.FromArgb(245, 245, 245);
        public static readonly Color Dugme = Color.FromArgb(200, 200, 200);

        public static void PrimeniStilListe(Form forma, GroupBox groupBox, params Button[] dugmad)
        {
            forma.BackColor = Pozadina;
            groupBox.BackColor = Pozadina;

            foreach (var dugme in dugmad)
            {
                dugme.BackColor = Dugme;
                dugme.FlatStyle = FlatStyle.Standard;
                dugme.UseVisualStyleBackColor = false;
            }
        }

        public static void PrimeniStilUnosa(Form forma, params Button[] dugmad)
        {
            forma.BackColor = Pozadina;
            forma.FormBorderStyle = FormBorderStyle.FixedDialog;
            forma.MaximizeBox = false;
            forma.MinimizeBox = false;
            forma.StartPosition = FormStartPosition.CenterParent;

            foreach (var dugme in dugmad)
            {
                dugme.BackColor = Dugme;
                dugme.FlatStyle = FlatStyle.Standard;
                dugme.UseVisualStyleBackColor = false;
            }
        }
    }
}
