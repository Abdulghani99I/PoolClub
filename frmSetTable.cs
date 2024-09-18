using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolClub
{
    public partial class frmSetTable : Form
    {
        private string _NamePlayer = "";
        private string _TitleTable = "";
        private float _RatePerHour = 0;


        public frmSetTable()
        {
            InitializeComponent();
        }

        public frmSetTable(string NamePlayer, string TitleTable, float RatePerHour)
        {
            InitializeComponent();

            this.NamePlayer = NamePlayer;
            this.TitleTable = TitleTable;
            this.RatePerHour = RatePerHour;   
        }

        public string TitleTable
        {
            set
            {
                _TitleTable = value;
                textBoxTitleTable.Text = _TitleTable;
            }
            get
            {
                return _TitleTable;
            }
        }
        
        public string NamePlayer
        {
            set
            {
                _NamePlayer = value;
                textBoxNamePlayer.Text = _NamePlayer;
            }
            get
            {
                return _NamePlayer;
            }
        }

        public float RatePerHour
        {
            set
            {
                _RatePerHour = value;
                textBoxRatePerHour.Text = _RatePerHour.ToString();
            }
            get
            {
                return _RatePerHour;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TitleTable = textBoxTitleTable.Text;
            NamePlayer = textBoxNamePlayer.Text;
            RatePerHour = float.Parse(textBoxRatePerHour.Text);

            this.Close();
        }

        private void textBoxRatePerHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters like backspace (char 8)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If the input is not a digit, handle the event and prevent it from being entered
                e.Handled = true;
            }
        }
    }
}
