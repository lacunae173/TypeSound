using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeSound
{
    public partial class VolumeForm : Form
    {
        public static float volume = 100;
        public VolumeForm()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Program.sounds.SetVolume(trackBar1.Value);
            volume = 100;
        }
    }
}
