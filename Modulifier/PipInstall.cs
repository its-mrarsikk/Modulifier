using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulifier
{
    public partial class PipInstall : Form
    {
        int manual_nextPkgTbxIndex = 2;

        public PipInstall()
        {
            InitializeComponent();
        }

        List<string> ReadPackageNames()
        {
            throw new NotImplementedException();
        }

        // manual
        private void manual_packages_add_Click(object sender, EventArgs e)
        {
            static Size MulSize(Size sz, Size accord, int percent)
            {
                static float Percent(float n, int p) => n * (p / 100);

                SizeF origF = (SizeF)sz;
                SizeF accordF = (SizeF)accord;
                origF.Height += Percent(accordF.Height, percent);
                return origF.ToSize();
            }

            if (manual_nextPkgTbxIndex == 19)
            {
                MessageBox.Show(this,
                    "There is too much packages to display all of them correctly.\nConsider reducing the number of required packages in your project, or put all these in a dependencies.txt and install from this file.",
                    "Too many packages!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TextBox tbx = new()
            {
                Name = $"manual_packages_pkg{manual_nextPkgTbxIndex++}",
                Size = new(136, 23),
                MaxLength = 34,
                BorderStyle = BorderStyle.Fixed3D,
            };
            manual_packages_list.Controls.Add(tbx);

            // sizing
            Control? container = tbx.Parent;
            bool firstIter = true;
            while (true)
            {
                container = firstIter ? container : container.Parent;
                if (container == null) break;
                container.Size = MulSize(container.Size, tbx.Size, 100);
                firstIter = false;
            }
        }
    }
}
