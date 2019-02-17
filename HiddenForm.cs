using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveEyes
{
    public partial class HiddenForm : Form
    {
        public HiddenForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ClientSize = new Size(200, 20);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            Console.Beep(1000, 500);
            Thread.Sleep(500);
            Console.Beep(1000, 500);
            Thread.Sleep(500);
            Console.Beep(1000, 500);

            base.OnVisibleChanged(e);
        }

        public void UpdateTimerLabel(TimeSpan value)
        {
            lblLongRestEndsIn.Text = value.ToString(@"mss");
        }
    }
}
