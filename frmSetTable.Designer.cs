namespace PoolClub
{
    partial class frmSetTable
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
        private void InitializeComponent()
        {
            this.labNamePlayer = new System.Windows.Forms.Label();
            this.textBoxNamePlayer = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.textBoxRatePerHour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitleTable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labNamePlayer
            // 
            this.labNamePlayer.AutoSize = true;
            this.labNamePlayer.Location = new System.Drawing.Point(47, 90);
            this.labNamePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNamePlayer.Name = "labNamePlayer";
            this.labNamePlayer.Size = new System.Drawing.Size(104, 19);
            this.labNamePlayer.TabIndex = 0;
            this.labNamePlayer.Text = "Name Player:";
            // 
            // textBoxNamePlayer
            // 
            this.textBoxNamePlayer.Location = new System.Drawing.Point(197, 87);
            this.textBoxNamePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNamePlayer.MaxLength = 15;
            this.textBoxNamePlayer.Name = "textBoxNamePlayer";
            this.textBoxNamePlayer.Size = new System.Drawing.Size(163, 27);
            this.textBoxNamePlayer.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(157, 222);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 34);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // textBoxRatePerHour
            // 
            this.textBoxRatePerHour.Location = new System.Drawing.Point(197, 146);
            this.textBoxRatePerHour.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRatePerHour.MaxLength = 8;
            this.textBoxRatePerHour.Name = "textBoxRatePerHour";
            this.textBoxRatePerHour.Size = new System.Drawing.Size(163, 27);
            this.textBoxRatePerHour.TabIndex = 2;
            this.textBoxRatePerHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRatePerHour_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rate Per Hour:";
            // 
            // textBoxTitleTable
            // 
            this.textBoxTitleTable.Location = new System.Drawing.Point(197, 39);
            this.textBoxTitleTable.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitleTable.MaxLength = 8;
            this.textBoxTitleTable.Name = "textBoxTitleTable";
            this.textBoxTitleTable.Size = new System.Drawing.Size(163, 27);
            this.textBoxTitleTable.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title Table:";
            // 
            // frmSetTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 308);
            this.Controls.Add(this.textBoxTitleTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRatePerHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBoxNamePlayer);
            this.Controls.Add(this.labNamePlayer);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSetTable";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNamePlayer;
        private System.Windows.Forms.TextBox textBoxNamePlayer;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox textBoxRatePerHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitleTable;
        private System.Windows.Forms.Label label2;
    }
}