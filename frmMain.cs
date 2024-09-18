using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolClub
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            InitializeComponent();

            stopwatch.Stop();
            MessageBox.Show((stopwatch.ElapsedMilliseconds).ToString());
        }

        private void ctrlPool1_OnTableComplete(object sender, ctrlPool.TableComplatedEvetArgs e)
        {
            if (e.TimeInSeconds == 0) return;
            MessageBox.Show($"Total Seconds: [{e.TimeInSeconds}] Total Fees is: [{e.TotalFees}]", "Informations");
        }

        private void ctrlPool_OnTableStart(object sender, ctrlPool.TableStartButton e)
        {
            //If Time Don't Running Go Our This Function.
            if (e.TimeInSeconds != 0) return;

            ctrlPool ctrlPool = (ctrlPool) sender;
            frmSetTable frm = new frmSetTable(ctrlPool.NamePlayer, ctrlPool.TitleTable, ctrlPool.RatePerHour);
            frm.ShowDialog();

            ctrlPool.TitleTable = frm.TitleTable;
            ctrlPool.NamePlayer = frm.NamePlayer;
            ctrlPool.RatePerHour = frm.RatePerHour;
        }
    }
}
