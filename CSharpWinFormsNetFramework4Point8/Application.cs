using System;
using System.Windows.Forms;

namespace CSharpWinFormsNetFramework4Point8.Properties {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            if (MessageBox.Show("Enable Process DPIAware?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainForm());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
