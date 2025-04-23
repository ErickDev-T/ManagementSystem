using System.Text.Json;
using System.Windows.Forms; // ← para usar MessageBox

namespace UIUtilities
{
    public class Traductor
    {
        public static void AplicarIdioma(Control control, string idioma)
        {
            foreach (Control c in control.Controls)
            {
                if (!string.IsNullOrEmpty(c.Name))
                {
                    string clave = c.Name;
                    c.Text = LanguageManager.Traducir(clave, idioma);
                }

                if (c.HasChildren)
                    AplicarIdioma(c, idioma);
            }
        }
    }

}
