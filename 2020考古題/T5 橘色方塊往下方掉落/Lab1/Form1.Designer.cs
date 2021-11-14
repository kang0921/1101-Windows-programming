using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    partial class Form1
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
            this.CountLB = new System.Windows.Forms.Label();
            this.hit_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel_poolTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_poolTable
            // 
            this.panel_poolTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_poolTable.Controls.Add(this.CountLB);
            this.panel_poolTable.Controls.Add(this.hit_button);
            this.panel_poolTable.Location = new System.Drawing.Point(-2, -3);
            this.panel_poolTable.Margin = new System.Windows.Forms.Padding(2);
            this.panel_poolTable.Name = "panel_poolTable";
            this.panel_poolTable.Size = new System.Drawing.Size(1200, 700);
            this.panel_poolTable.TabIndex = 2;
            this.panel_poolTable.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_poolTable_Paint);
            this.panel_poolTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_poolTable_MouseDown);
            // 
            // CountLB
            // 
            this.CountLB.AutoSize = true;
            this.CountLB.BackColor = System.Drawing.Color.White;
            this.CountLB.CausesValidation = false;
            this.CountLB.Font = new System.Drawing.Font("源泉圓體 M", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CountLB.Location = new System.Drawing.Point(14, 617);
            this.CountLB.Name = "CountLB";
            this.CountLB.Size = new System.Drawing.Size(112, 27);
            this.CountLB.TabIndex = 4;
            this.CountLB.Text = "擊落數：";
            // 
            // hit_button
            // 
            this.hit_button.BackColor = System.Drawing.Color.White;
            this.hit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hit_button.Font = new System.Drawing.Font("源泉圓體 M", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hit_button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.hit_button.Location = new System.Drawing.Point(1051, 603);
            this.hit_button.Margin = new System.Windows.Forms.Padding(2);
            this.hit_button.Name = "hit_button";
            this.hit_button.Size = new System.Drawing.Size(124, 50);
            this.hit_button.TabIndex = 3;
            this.hit_button.Text = "發射";
            this.hit_button.UseVisualStyleBackColor = false;
            this.hit_button.Click += new System.EventHandler(this.hit_button_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel_poolTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "遊戲頁面";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel_poolTable.ResumeLayout(false);
            this.panel_poolTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_poolTable;
        private Timer timer1;
        private Button hit_button;
        private Timer timer2;
        private Label CountLB;
    }
}
