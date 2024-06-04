using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYv4.Utilities
{
    public static class PageChange
    {
        static public void Change(Panel panel, Form main, Form childForm)
        {
            childForm.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(childForm);
            childForm.Show();

            #region Resize components
            foreach (Form activeForm in panel.Controls)
            {
                activeForm.Size = panel.Size;
            }
            #endregion

            #region Simulation Page Control
            if (childForm.Name == "SimulationPage")
            {
                main.WindowState = FormWindowState.Normal;
                main.MaximumSize = new Size(1280, 720);

                main.MaximizeBox = false;
            }
            else
            {
                main.MaximumSize = new Size(0, 0);

                main.MaximizeBox = true;
            }
            #endregion
        }
    }
}
