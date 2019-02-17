using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SaveEyes;
using SaveEyes.Properties;

namespace WindowsFormsApplication1
{
    public partial class RestForm : Form
    {
        // ShortRestDuration is the same
        private TimeSpan _timerResolutionInterval;
        private TimeSpan AutoReenableInterval = TimeSpan.FromHours(1);
        private readonly TimeSpan ShortRestInterval = TimeSpan.FromMinutes(1);
        private TimeSpan _longRestInterval;
        private TimeSpan _longRestDuration;
        private TimeSpan _longRestEndsIn;
        private bool _allowLongRest = true;
        private bool _inLongRest = false;

        private DateTime _lastShortRestTime;
        private DateTime _lastLongRestTime;
        private DateTime _lastDisableTime = DateTime.MaxValue;

        private bool _enabled = true;
        private int _lastIndex;

        private Form _form;
        private HiddenForm _hiddenForm;

        public RestForm()
        {
            InitializeComponent();

            InitializeDefaultTimerInterval();
            SetLongRestParametersFromConfig();
            SetImage();
            ResetLastLongRestTime();
            ResetLastShortRestTime();

            Visible = false;

            _form = this;
            _hiddenForm = new HiddenForm();
        }

        private void InitializeDefaultTimerInterval()
        {
            _timerResolutionInterval = TimeSpan.Parse(ConfigurationManager.AppSettings["ShortRestDuration"]);
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
            _form.Hide();
        }

        private void FinishLongRest()
        {
            InitializeDefaultTimerInterval();

            _inLongRest = false;
            _longRestEndsIn = TimeSpan.Zero;

            lblLongRest.Visible = false;
            timerSeconds.Enabled = false;

            ResetLastLongRestTime();
            ResetLastShortRestTime();

            _form.Hide();
        }

        private void ResetLastLongRestTime()
        {
            _lastLongRestTime = DateTime.Now;
        }

        private void ResetLastShortRestTime()
        {
            _lastShortRestTime = DateTime.Now;
        }

        private void StartRest(bool longRest)  // Either long or short
        {
            if (longRest)
            {
                _inLongRest = true;
                timer.Interval = (int)_longRestDuration.TotalMilliseconds;
                timerSeconds.Enabled = true;
                _longRestEndsIn = _longRestDuration;

                UpdateLongRestEndsInLabel();
            }
            else
            {
                ResetLastShortRestTime();
            }

            lblLongRest.Visible = !mnuiSemiHiddenMode.Checked && longRest;
            lblLongRestEndsIn.Visible = !mnuiSemiHiddenMode.Checked && longRest;
            pictCat.Visible = !mnuiSemiHiddenMode.Checked || !longRest;

            SetImage();

            _form.Show();
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
                ? _lastLongRestTime + _longRestInterval
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
                _form.Show();
            }
            else
            {
                _form.Hide();
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
            Bitmap bmp = (Bitmap)Resources.ResourceManager.GetObject("a" + _lastIndex);
            pictCat.Image = bmp;
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
                _form.Hide();
            }
            
            if (_enabled)
            {
                ResetLastLongRestTime();
                ResetLastShortRestTime();
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
            mnuiLongRestSchemes.Enabled = mnuiAllowLongRest.Checked;
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            if (_inLongRest)
            {
                _longRestEndsIn = _longRestEndsIn - TimeSpan.FromSeconds(1);
                UpdateLongRestEndsInLabel();
            }
        }

        private void UpdateLongRestEndsInLabel()
        {
            lblLongRestEndsIn.Text = _longRestEndsIn.ToString(@"mm\:ss");
            _hiddenForm.UpdateTimerLabel(_longRestEndsIn);
        }

        private void icoTray_MouseMove(object sender, MouseEventArgs e)
        {
            if (_inLongRest)
            {
                icoTray.Text = "LONG REST";
                return;
            }

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

        private void mnuiLongRestScheme_Clicked(object sender, EventArgs e)
        {
            var mnui = (ToolStripMenuItem)sender;

            mnuiLongRestScheme17_3.Checked = false;
            mnuiLongRestScheme25_5.Checked = false;
            mnuiLongRestScheme45_15.Checked = false;
            mnuiLongRestSchemeCustom.Checked = false;

            mnui.Checked = true;
        }

        private void mnuiLongRestScheme45_15_CheckedChanged(object sender, EventArgs e)
        {
            if (mnuiLongRestScheme45_15.Checked)
            {
                SetLongRestParameters(45, 15);
            }
        }

        private void mnuiLongRestScheme25_5_CheckedChanged(object sender, EventArgs e)
        {
            if (mnuiLongRestScheme25_5.Checked)
            {
                SetLongRestParameters(25, 5);
            }
        }

        private void mnuiLongRestScheme17_3_CheckedChanged(object sender, EventArgs e)
        {
            if (mnuiLongRestScheme17_3.Checked)
            {
                SetLongRestParameters(17, 3);
            }
        }

        private void mnuiLongRestSchemeCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (mnuiLongRestSchemeCustom.Checked)
            {
                SetLongRestParametersFromConfig();
            }
        }

        private void SetLongRestParameters(int interval, int duration)
        {
            _longRestDuration = TimeSpan.FromMinutes(duration);
            _longRestInterval = TimeSpan.FromMinutes(interval);
        }

        private void mnuiReenableSwitch_Click(object sender, EventArgs e)
        {
            var mnui = (ToolStripMenuItem)sender;

            mnuiReenableIn1Hour.Checked = false;
            mnuiReenableIn2Hours.Checked = false;
            mnuiReenableNever.Checked = false;

            mnui.Checked = true;
        }

        private void mnuiReenableNever_CheckedChanged(object sender, EventArgs e)
        {
            if (mnuiReenableNever.Checked)
            {
                AutoReenableInterval = TimeSpan.MaxValue;
            }
        }

        private void mnuiReenableIn1Hour_CheckedChanged(object sender, EventArgs e)
        {
            if (mnuiReenableIn1Hour.Checked)
            {
                AutoReenableInterval = TimeSpan.FromHours(1);
            }
        }

        private void mnuiReenableIn2Hours_CheckedChanged(object sender, EventArgs e)
        {
            if (mnuiReenableIn2Hours.Checked)
            {
                AutoReenableInterval = TimeSpan.FromHours(2);
            }
        }

        private void SetLongRestParametersFromConfig()
        {
            _longRestDuration = TimeSpan.Parse(ConfigurationManager.AppSettings["LongRestDuration"]);
            _longRestInterval = TimeSpan.Parse(ConfigurationManager.AppSettings["LongRestInterval"]);
        }

        private void mnuiReset_Click(object sender, EventArgs e)
        {
            FinishShortRest();

            if (_inLongRest)
            {
                FinishLongRest();
            }
            else
            {
                ResetLastLongRestTime();
                ResetLastShortRestTime();
            }
        }

        private void mnuiHiddenMode_CheckedChanged(object sender, EventArgs e)
        {
            if (mnuiHiddenMode.Checked)
            {
                mnuiSemiHiddenMode.Checked = false;
            }

            _form.Hide();

            if (mnuiHiddenMode.Checked)
            {
                _form = _hiddenForm;
            }
            else
            {
                _form = this;
            }
        }

        private void mnuiSemiHiddenMode_Click(object sender, EventArgs e)
        {
            if (mnuiSemiHiddenMode.Checked)
            {
                mnuiHiddenMode.Checked = false;
            }

            if (_inLongRest)
            {
                lblLongRest.Visible = !mnuiSemiHiddenMode.Checked;
                lblLongRestEndsIn.Visible = !mnuiSemiHiddenMode.Checked;
                pictCat.Visible = !mnuiSemiHiddenMode.Checked;
            }
        }

        private void mnuiLongRestNow_Click(object sender, EventArgs e)
        {
            _lastLongRestTime = DateTime.Now - _longRestInterval;
            timer_Tick(null, null);
        }

        private void mnuiLongRestIn5Minutes_Click(object sender, EventArgs e)
        {
            _lastLongRestTime = DateTime.Now - _longRestInterval + TimeSpan.FromMinutes(5);
        }
    }
}