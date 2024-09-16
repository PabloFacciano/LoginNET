using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaVista
{
    internal static class Program
    {


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ShowForm(new FrmLogin());
            Application.Run();
        }


        // Forms
        static List<Form> forms = new List<Form>();
        public static void ShowForm(Form frm, bool showDialog = false)
        {
            frm.FormClosed += Form_Closed;
            forms.Add(frm);
            if (showDialog)
            {
                frm.ShowDialog();
            } else
            {
                frm.Show();
            }
        }
        static void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Form frm = (Form)sender;
            forms.Remove(frm);
            if (forms.Count == 0)
            {
                Application.Exit();
            }
        }


    }
}
