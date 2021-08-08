using System;
using System.Windows.Forms;
using System.Media;

namespace TypeSound
{
    public partial class Form1 : Form
    {
        Form volumeForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (volumeForm != null) 
                volumeForm.Dispose();
            volumeForm = new VolumeForm();
            volumeForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
