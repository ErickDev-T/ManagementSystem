using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Forms;


namespace UIUtilities
{
    public static class LanguageManager
    {
        private static Dictionary<string, Dictionary<string, string>> textos;

        // NO se recibe ruta, ya usamos la predeterminada
        public static void CargarIdiomas()
        {
            try
            {
                // Ruta automática al archivo junto al .exe
                string ruta = Path.Combine(Application.StartupPath, "languages.json");
                string json = File.ReadAllText(ruta);

                textos = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar archivo de idiomas: " + ex.Message);
                textos = new Dictionary<string, Dictionary<string, string>>();
            }
        }

        public static string Traducir(string clave, string idioma)
        {
            if (textos == null)
                return clave;

            if (textos.ContainsKey(idioma) && textos[idioma].ContainsKey(clave))
                return textos[idioma][clave];

            return clave; // fallback si no encuentra la clave o idioma
        }

        public static void MostrarTraducciones(string idioma)
        {
            if (textos == null || !textos.ContainsKey(idioma))
            {
                MessageBox.Show("Idioma no encontrado.");
                return;
            }

            string salida = $"Idioma: {idioma}\n\n";

            foreach (var par in textos[idioma])
            {
                salida += $"{par.Key}: {par.Value}\n";
            }

            //MessageBox.Show(salida, "Traducciones");
        }
    }
}
