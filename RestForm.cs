using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SaveEyes.Properties;

namespace WindowsFormsApplication1
{
    public partial class RestForm : Form
    {
        private readonly TimeSpan AutoReenableInterval = TimeSpan.FromHours(1);
        private readonly TimeSpan ShortRestInterval = TimeSpan.FromMinutes(5);
        private readonly TimeSpan LongRestInterval = TimeSpan.FromMinutes(30);
        // ShortRestDuration is the same
        private readonly TimeSpan _timerResolutionInterval;
        private readonly TimeSpan _longRestDuration;

        private TimeSpan _longRestEndsIn;

        private DateTime _lastShortRestTime = DateTime.Now;
        private DateTime _lastLongRestTime = DateTime.Now;
        private DateTime _lastDisableTime = DateTime.MaxValue;

        private bool _enabled = true;
        private bool _allowLongRest = true;
        private bool _inLongRest = false;
        private int _lastIndex;

        public RestForm()
        {
            _timerResolutionInterval = TimeSpan.Parse(ConfigurationManager.AppSettings["ShortRestDuration"]);
            _longRestDuration = TimeSpan.Parse(ConfigurationManager.AppSettings["LongRestDuration"]);

            InitializeComponent();

            InitializeDefaultTimerInterval();

            SetImage();

            Visible = false;
        }

        private void InitializeDefaultTimerInterval()
        {
            timer.Interval = (int)_timerResolutionInterval.TotalMilliseconds;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Trace.WriteLine($"Tick {DateTime.Now}");

            ReenableIfNeeded();

            if (!_enabled)
            {
                return;
            }

            if (_inLongRest)
            {
                FinishLongRest();
                return;
            }

            if (IsTimeToShortRest() || IsTimeToLongRest())
            {
                StartRest(IsTimeToLongRest());
                return;
            }

            FinishShortRest();
        }

        private void FinishShortRest()
        {
            Hide();
        }

        private void FinishLongRest()
        {
            InitializeDefaultTimerInterval();

            _inLongRest = false;
            _lastLongRestTime = _lastShortRestTime = DateTime.Now;
            lblLongRest.Visible = false;
            timerSeconds.Enabled = false;
            _longRestEndsIn = TimeSpan.Zero;

            Hide();
        }

        private void StartRest(bool longRest)
        {
            if (longRest)
            {
                _inLongRest = true;
                timer.Interval = (int)_longRestDuration.TotalMilliseconds;
                timerSeconds.Enabled = true;
                lblLongRest.Visible = true;
                _longRestEndsIn = _longRestDuration;
                lblLongRestEndsIn.Text = _longRestEndsIn.ToString(@"mm\:ss");
            }
            else
            {
                _lastShortRestTime = DateTime.Now;
            }

            lblLongRestEndsIn.Visible = _inLongRest;

            SetImage();
            Show();
        }

        private bool IsTimeToLongRest()
        {
            DateTime nextLongRest = GetNextLongRestStart();

            Trace.WriteLine($"Next long rest {nextLongRest}");

            return !Visible &&
                _allowLongRest &&
                nextLongRest < DateTime.Now;
        }

        private DateTime GetNextLongRestStart()
        {
            return _allowLongRest 
                ? _lastLongRestTime + LongRestInterval
                : DateTime.MaxValue;
        }

        private bool IsTimeToShortRest()
        {
            Trace.WriteLine($"Next short rest {_lastShortRestTime + ShortRestInterval}");

            return !Visible &&
                _lastShortRestTime + ShortRestInterval < DateTime.Now;
        }

        private void ToggleVisibility()
        {
            if (!Visible)
            {
                SetImage();
                Show();
            }
            else
            {
                Hide();
            }
        }

        private void ReenableIfNeeded()
        {
            if (_lastDisableTime != DateTime.MaxValue &&
                    _lastDisableTime + AutoReenableInterval < DateTime.Now)
            {
                ToggleDisable();
            }
        }

        private void SetImage()
        {
            Bitmap bmp =
                (Bitmap)Resources.ResourceManager.GetObject("a" + _lastIndex);
            pictureBox1.Image = bmp;
            _lastIndex = (_lastIndex + 1) % 6;
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleDisable();
        }

        private void ToggleDisable()
        {
            _enabled = !_enabled;
            mnuiDisable.Text = _enabled ? "Disable" : "Enable";
            _lastDisableTime = _enabled ? DateTime.MaxValue : DateTime.Now;

            if (!_enabled)
            {
                Hide();
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            Console.Beep(1000, 100);

            base.OnVisibleChanged(e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuiAllowLongRest_Click(object sender, EventArgs e)
        {
            _allowLongRest = mnuiAllowLongRest.Checked;
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            if (_inLongRest)
            {
                _longRestEndsIn = _longRestEndsIn - TimeSpan.FromSeconds(1);
                lblLongRestEndsIn.Text = _longRestEndsIn.ToString(@"mm\:ss");
            }
        }

        private void icoTray_MouseMove(object sender, MouseEventArgs e)
        {
            if (_allowLongRest)
            {
                var timeToNextLongRest = GetNextLongRestStart() - DateTime.Now;
                icoTray.Text = "Next long rest in:\r\n " + timeToNextLongRest.ToString(@"mm\:ss");
            }
            else
            {
                icoTray.Text = "DISABLED";
            }
        }
    }
}