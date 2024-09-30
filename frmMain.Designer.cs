using System;
using System.Threading.Tasks;

namespace PoolClub
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

            private void InitializeComponent()
            {
            this.ctrlPool6 = new PoolClub.ctrlPool();
            this.ctrlPool5 = new PoolClub.ctrlPool();
            this.ctrlPool4 = new PoolClub.ctrlPool();
            this.ctrlPool3 = new PoolClub.ctrlPool();
            this.ctrlPool2 = new PoolClub.ctrlPool();
            this.ctrlPool1 = new PoolClub.ctrlPool();
            this.SuspendLayout();
            // 
            // ctrlPool6
            // 
            this.ctrlPool6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlPool6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ctrlPool6.Location = new System.Drawing.Point(778, 343);
            this.ctrlPool6.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPool6.Name = "ctrlPool6";
            this.ctrlPool6.NamePlayer = "Player6";
            this.ctrlPool6.RatePerHour = 10F;
            this.ctrlPool6.Size = new System.Drawing.Size(376, 275);
            this.ctrlPool6.TabIndex = 5;
            this.ctrlPool6.TitleTable = "Table6";
            this.ctrlPool6.OnTableComplete += new System.EventHandler<PoolClub.ctrlPool.TableComplatedEvetArgs>(this.ctrlPool1_OnTableComplete);
            this.ctrlPool6.OnTableStart += new System.EventHandler<PoolClub.ctrlPool.TableStartButton>(this.ctrlPool_OnTableStart);
            // 
            // ctrlPool5
            // 
            this.ctrlPool5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlPool5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ctrlPool5.Location = new System.Drawing.Point(393, 343);
            this.ctrlPool5.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPool5.Name = "ctrlPool5";
            this.ctrlPool5.NamePlayer = "Player5";
            this.ctrlPool5.RatePerHour = 10F;
            this.ctrlPool5.Size = new System.Drawing.Size(376, 275);
            this.ctrlPool5.TabIndex = 4;
            this.ctrlPool5.TitleTable = "Table5";
            this.ctrlPool5.OnTableComplete += new System.EventHandler<PoolClub.ctrlPool.TableComplatedEvetArgs>(this.ctrlPool1_OnTableComplete);
            this.ctrlPool5.OnTableStart += new System.EventHandler<PoolClub.ctrlPool.TableStartButton>(this.ctrlPool_OnTableStart);
            // 
            // ctrlPool4
            // 
            this.ctrlPool4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlPool4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ctrlPool4.Location = new System.Drawing.Point(8, 343);
            this.ctrlPool4.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPool4.Name = "ctrlPool4";
            this.ctrlPool4.NamePlayer = "Player4";
            this.ctrlPool4.RatePerHour = 10F;
            this.ctrlPool4.Size = new System.Drawing.Size(376, 275);
            this.ctrlPool4.TabIndex = 3;
            this.ctrlPool4.TitleTable = "Table4";
            this.ctrlPool4.OnTableComplete += new System.EventHandler<PoolClub.ctrlPool.TableComplatedEvetArgs>(this.ctrlPool1_OnTableComplete);
            this.ctrlPool4.OnTableStart += new System.EventHandler<PoolClub.ctrlPool.TableStartButton>(this.ctrlPool_OnTableStart);
            // 
            // ctrlPool3
            // 
            this.ctrlPool3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlPool3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ctrlPool3.Location = new System.Drawing.Point(778, 26);
            this.ctrlPool3.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPool3.Name = "ctrlPool3";
            this.ctrlPool3.NamePlayer = "Player3";
            this.ctrlPool3.RatePerHour = 10F;
            this.ctrlPool3.Size = new System.Drawing.Size(376, 275);
            this.ctrlPool3.TabIndex = 2;
            this.ctrlPool3.TitleTable = "Table3";
            this.ctrlPool3.OnTableComplete += new System.EventHandler<PoolClub.ctrlPool.TableComplatedEvetArgs>(this.ctrlPool1_OnTableComplete);
            this.ctrlPool3.OnTableStart += new System.EventHandler<PoolClub.ctrlPool.TableStartButton>(this.ctrlPool_OnTableStart);
            // 
            // ctrlPool2
            // 
            this.ctrlPool2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlPool2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ctrlPool2.Location = new System.Drawing.Point(392, 26);
            this.ctrlPool2.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPool2.Name = "ctrlPool2";
            this.ctrlPool2.NamePlayer = "Player2";
            this.ctrlPool2.RatePerHour = 10F;
            this.ctrlPool2.Size = new System.Drawing.Size(376, 275);
            this.ctrlPool2.TabIndex = 1;
            this.ctrlPool2.TitleTable = "Table2";
            this.ctrlPool2.OnTableComplete += new System.EventHandler<PoolClub.ctrlPool.TableComplatedEvetArgs>(this.ctrlPool1_OnTableComplete);
            this.ctrlPool2.OnTableStart += new System.EventHandler<PoolClub.ctrlPool.TableStartButton>(this.ctrlPool_OnTableStart);
            // 
            // ctrlPool1
            // 
            this.ctrlPool1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlPool1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ctrlPool1.Location = new System.Drawing.Point(6, 26);
            this.ctrlPool1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPool1.Name = "ctrlPool1";
            this.ctrlPool1.NamePlayer = "Player1";
            this.ctrlPool1.RatePerHour = 10F;
            this.ctrlPool1.Size = new System.Drawing.Size(376, 275);
            this.ctrlPool1.TabIndex = 0;
            this.ctrlPool1.TitleTable = "Table1";
            this.ctrlPool1.OnTableComplete += new System.EventHandler<PoolClub.ctrlPool.TableComplatedEvetArgs>(this.ctrlPool1_OnTableComplete);
            this.ctrlPool1.OnTableStart += new System.EventHandler<PoolClub.ctrlPool.TableStartButton>(this.ctrlPool_OnTableStart);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1161, 643);
            this.Controls.Add(this.ctrlPool6);
            this.Controls.Add(this.ctrlPool5);
            this.Controls.Add(this.ctrlPool4);
            this.Controls.Add(this.ctrlPool3);
            this.Controls.Add(this.ctrlPool2);
            this.Controls.Add(this.ctrlPool1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

            }

        #endregion

        private ctrlPool ctrlPool1;
        private ctrlPool ctrlPool2;
        private ctrlPool ctrlPool3;
        private ctrlPool ctrlPool4;
        private ctrlPool ctrlPool5;
        private ctrlPool ctrlPool6;
    }
}

