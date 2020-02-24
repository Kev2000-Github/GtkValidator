using System;
using System.Globalization;
using System.Threading;
using Gtk;

namespace GtkValidation
{

    public class Validacion
    {
        public static void ValidarNro(Entry ent)
        {
            string newStr = "";

            foreach (var c in ent.Text)
            {
                if (char.IsDigit(c))
                    newStr += c;
            }
            ent.Text = newStr;
        }

        public static void ValidarNroDecimal(Entry ent)
        {
            string newStr = "";
            int cont = 0;
            foreach (var c in ent.Text)
            {
                if (char.IsDigit(c) || c == '.' || c == ',')
                {
                    if (c == ',' || c == '.')
                    {
                        if (cont == 0 && newStr != "")
                            newStr += ',';
                        cont++;
                    }
                    else
                        newStr += c;
                }
            }
            ent.Text = newStr;
        }

        public static void ValidarBoton(Button bton, params Entry[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                if (string.IsNullOrEmpty(texts[i].Text))
                {
                    bton.Sensitive = false;
                    return;
                }
            }
            bton.Sensitive = true;
        }

    }

    public class CambioCultura
    {
        public static void ChangeThreadCulture(string cultureName)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
        }
    }
}
