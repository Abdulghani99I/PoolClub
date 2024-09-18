using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolClub
{
    public partial class ctrlPool : UserControl
    {
        
        private TimeSpan _timeElapsed = new TimeSpan(0, 0, 0);  // TimeSpan to track the time
        bool _isTimeRunning = false;

        private string _NamePlayer = "";
        private string _TitleTable = "";
        private int _TimeInSeconds = 0;
        private float _RatePerHour = 0;

        public ctrlPool()
        {
            InitializeComponent();
        }

        [
        Category("Pool Config"),
        Description("Name Player.")
        ]
        public string NamePlayer
        {
            set
            {
                _NamePlayer = value;
                lblNamePlayer.Text = _NamePlayer;
            }

            get
            {
                return _NamePlayer;
            }
        }

        [
       Category("Pool Config"),
       Description("Title Table.")
        ]
        public string TitleTable
        {
            set
            {
                _TitleTable = value;
                groupBox1.Text = _TitleTable;
            }

            get
            {
                return _TitleTable;
            }
        }

        //[
        //Category("Pool Config"),
        //Description("Time In Seconds.")
        //]
        private int TimeInSeconds
        {
            set
            {
                _TimeInSeconds = value;
            }

            get
            {
                return _TimeInSeconds;
            }
        }

        [
        Category("Pool Config"),
        Description("Rate Per Hour.")
        ]
        public float RatePerHour
        {
            set
            {
                _RatePerHour = value;
            }
            get
            {
                return _RatePerHour;
            }
        }

        public class TableComplatedEvetArgs : EventArgs
        {
            public string TimeText { get; }
            public int TimeInSeconds { get; }
            public float RatePerHour { get; set; }
            public float TotalFees { get; }

            public TableComplatedEvetArgs(string timeText, int timeInSeconds, float ratePerHour, float totalFees)
            {
                TimeText = timeText;
                TimeInSeconds = timeInSeconds;
                RatePerHour = ratePerHour;
                TotalFees = totalFees;
            }
        }

        

        public event EventHandler<TableComplatedEvetArgs> OnTableComplete;

        public void RaiseOnTableComplate(string TimeText, int TimeInSeconds, float RatePerHour, float TotalFees)
        {
            RaiseOnTableComplate(new TableComplatedEvetArgs(TimeText, TimeInSeconds, RatePerHour, TotalFees));
        }

        protected virtual void RaiseOnTableComplate(TableComplatedEvetArgs e)
        {
            OnTableComplete?.Invoke(this, e);
        }

        public class TableStartButton : EventArgs
        {
            public int TimeInSeconds { set; get; }

            public TableStartButton(int timeInSeconds)
            {
                TimeInSeconds = timeInSeconds;
            }
        }

        public event EventHandler<TableStartButton> OnTableStart;

        public void RaiseOnTableStartButton(int TimeInSeconds)
        {
            RaiseOnTableStartButton(new TableStartButton(TimeInSeconds));
        }

        protected virtual void RaiseOnTableStartButton(TableStartButton e)
        {
            OnTableStart?.Invoke(this, e);
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_isTimeRunning)
            {
                timer1.Stop();
                btnStartStop.Text = "Start";
                _isTimeRunning = false;
            }
            else
            {
                RaiseOnTableStartButton(TimeInSeconds);
                timer1.Start();
                btnStartStop.Text = "Stop";
                _isTimeRunning = true;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            // When Click Button End Should Stop Timer And Reset TimeSpan And Handel Other Property.

            int _Seconds = (int) _timeElapsed.TotalSeconds;
            float _TotalFees = ((float) _Seconds / (60 * 60)) * _RatePerHour;
            timer1.Stop();
            _isTimeRunning = false;
            _timeElapsed = TimeSpan.Zero;
            TimeInSeconds = 0;
            lblTimer.Text = "00:00:00";
            btnStartStop.Text = "Start";


            RaiseOnTableComplate(lblTimer.Text, _Seconds, RatePerHour, _TotalFees);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment the elapsed time by one second
            _timeElapsed = _timeElapsed.Add(TimeSpan.FromSeconds(1));

            // Update the label to display the elapsed time in HH:mm:ss format
            lblTimer.Text = _timeElapsed.ToString(@"hh\:mm\:ss");

            // Set Current Seconds For This Property.
            TimeInSeconds = _timeElapsed.Seconds;
        }
    }
}
