using System;
using System.Windows.Forms;

namespace Forms {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        public new void Invoke(Action method) => base.Invoke(method);
        public static DialogResult MessageBoxShow(string text, string caption = null,
                                        MessageBoxButtons buttons = MessageBoxButtons.OK,
                                        MessageBoxIcon icon = MessageBoxIcon.None,
                                        MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions options = 0) =>
            MessageBox.Show(text, caption, buttons, icon, defaultButton, options);

        private void ApplyTheme(WalkmanLib.Theme theme) {
            ToolStripManager.Renderer = new WalkmanLib.CustomPaint.ToolStripSystemRendererWithDisabled(theme.ToolStripItemDisabledText);
            tabControl.Tag = theme.TabControlTabColors;
            tabControl.DrawItem += WalkmanLib.CustomPaint.TabControl_DrawCustomItem;

            WalkmanLib.ApplyTheme(theme, this, true);
        }

        private void MainForm_Load(object _, EventArgs __) {
            var frameworkName = new System.Runtime.Versioning.FrameworkName(AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName);

            this.Text += " " + frameworkName.Identifier + " v" + frameworkName.Version.ToString();
            txtVersions.Text += frameworkName.Identifier + " v" + frameworkName.Version;
            txtVersions.Text += Environment.NewLine + Environment.OSVersion.ToString();
#if NETCOREAPP || NETFRAMEWORK4_8
            txtVersions.Text += Environment.NewLine + "DPI: " + this.DeviceDpi;
#endif

            ApplyTheme(WalkmanLib.Theme.Dark);

            System.Threading.Tasks.Task.Run(async () => {
                try {
                    while (true) {
                        this.Invoke(() => {
                            if (progressBar.Value >= 100)
                                progressBar.Value = 0;
                            else
                                progressBar.Value += 10;
                        });

                        await System.Threading.Tasks.Task.Delay(1000);
                    }
                } catch (Exception ex) {
                    MessageBoxShow(ex.Message, icon: MessageBoxIcon.Error);
                }
            });
        }

        private void btnMain_Click(object _, EventArgs __) {
            WalkmanLib.ShowProperties(System.IO.Path.Combine(Application.StartupPath, System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe"));
        }

        private void btnGroup_Click(object _, EventArgs __) {
            ApplyTheme(WalkmanLib.Theme.Default);
        }

        private void btnPanel_Click(object _, EventArgs __) {
            WalkmanLib.SaveTheme("dark.json", WalkmanLib.Theme.Dark);
        }

        private void btnSplitContainer_Click(object _, EventArgs __) {
            ApplyTheme(WalkmanLib.LoadTheme("dark.json"));
            System.IO.File.Delete("dark.json");
        }
    }
}
