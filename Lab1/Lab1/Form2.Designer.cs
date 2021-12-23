using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_returnForm1 = new System.Windows.Forms.Button();
            this.panel_poolTable = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hit_button = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pullBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.label_welcome.Font = new System.Drawing.Font("思源黑體 Medium", 24F, System.Drawing.FontStyle.Bold);
            this.label_welcome.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_welcome.Location = new System.Drawing.Point(488, 105);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(246, 70);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome";
            // 
            // button_returnForm1
            // 
            this.button_returnForm1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_returnForm1.Font = new System.Drawing.Font("思源黑體 Medium", 18F, System.Drawing.FontStyle.Bold);
            this.button_returnForm1.Location = new System.Drawing.Point(352, 765);
            this.button_returnForm1.Name = "button_returnForm1";
            this.button_returnForm1.Size = new System.Drawing.Size(166, 69);
            this.button_returnForm1.TabIndex = 1;
            this.button_returnForm1.Text = "回首頁";
            this.button_returnForm1.UseVisualStyleBackColor = false;
            this.button_returnForm1.Click += new System.EventHandler(this.button_returnForm2_Click);
            // 
            // panel_poolTable
            // 
            this.panel_poolTable.BackColor = System.Drawing.Color.Green;
            this.panel_poolTable.Location = new System.Drawing.Point(352, 213);
            this.panel_poolTable.Name = "panel_poolTable";
            this.panel_poolTable.Size = new System.Drawing.Size(938, 528);
            this.panel_poolTable.TabIndex = 2;
            this.panel_poolTable.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_poolTable_Paint);
            this.panel_poolTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_poolTable_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 36;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hit_button
            // 
            this.hit_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hit_button.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hit_button.Location = new System.Drawing.Point(1358, 765);
            this.hit_button.Name = "hit_button";
            this.hit_button.Size = new System.Drawing.Size(155, 69);
            this.hit_button.TabIndex = 3;
            this.hit_button.Text = "Hit";
            this.hit_button.UseVisualStyleBackColor = false;
            this.hit_button.Click += new System.EventHandler(this.hit_button_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1338, 334);
            this.vScrollBar1.Maximum = 80;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(60, 340);
            this.vScrollBar1.TabIndex = 4;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(1476, 334);
            this.vScrollBar2.Maximum = 50;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(60, 340);
            this.vScrollBar2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(1330, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "打擊力";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(1464, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "摩擦力";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(1364, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "大";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(1498, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "大";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(1364, 705);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "小";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(1500, 705);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "小";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.checkBox1.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkBox1.Location = new System.Drawing.Point(915, 765);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 60);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "暫停";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pullBackButton
            // 
            this.pullBackButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pullBackButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.pullBackButton.Location = new System.Drawing.Point(1138, 765);
            this.pullBackButton.Name = "pullBackButton";
            this.pullBackButton.Size = new System.Drawing.Size(152, 69);
            this.pullBackButton.TabIndex = 13;
            this.pullBackButton.Text = "拉回";
            this.pullBackButton.UseVisualStyleBackColor = false;
            this.pullBackButton.Click += new System.EventHandler(this.pullBackButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1923, 1050);
            this.Controls.Add(this.pullBackButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hit_button);
            this.Controls.Add(this.panel_poolTable);
            this.Controls.Add(this.button_returnForm1);
            this.Controls.Add(this.label_welcome);
            this.Name = "Form2";
            this.Text = "遊戲頁面";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_returnForm1;
        private System.Windows.Forms.Panel panel_poolTable;
        private Timer timer1;
        private Button hit_button;
        private VScrollBar vScrollBar1;
        private VScrollBar vScrollBar2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private Button pullBackButton;
    }
}
