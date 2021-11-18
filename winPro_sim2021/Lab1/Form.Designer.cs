using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.panel_poolTable = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.countLB = new System.Windows.Forms.Label();
            this.panel_poolTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_poolTable
            // 
            this.panel_poolTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_poolTable.Controls.Add(this.countLB);
            this.panel_poolTable.Location = new System.Drawing.Point(0, 0);
            this.panel_poolTable.Margin = new System.Windows.Forms.Padding(2);
            this.panel_poolTable.Name = "panel_poolTable";
            this.panel_poolTable.Size = new System.Drawing.Size(1200, 700);
            this.panel_poolTable.TabIndex = 2;
            this.panel_poolTable.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_poolTable_Paint);
            this.panel_poolTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_poolTable_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // countLB
            // 
            this.countLB.AutoSize = true;
            this.countLB.Font = new System.Drawing.Font("思源黑體 Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countLB.Location = new System.Drawing.Point(21, 598);
            this.countLB.Name = "countLB";
            this.countLB.Size = new System.Drawing.Size(117, 35);
            this.countLB.TabIndex = 0;
            this.countLB.Text = "countLB";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel_poolTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form";
            this.Text = "遊戲頁面";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel_poolTable.ResumeLayout(false);
            this.panel_poolTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_poolTable;
        private Timer timer1;
        private Timer timer2;
        private Label countLB;
    }
}
