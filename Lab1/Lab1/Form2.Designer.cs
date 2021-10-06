
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
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_returnForm2 = new System.Windows.Forms.Button();
            this.panel_poolTable = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("思源黑體 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_welcome.Location = new System.Drawing.Point(241, 32);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(127, 35);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome";
            this.label_welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_returnForm2
            // 
            this.button_returnForm2.Font = new System.Drawing.Font("思源黑體 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_returnForm2.Location = new System.Drawing.Point(657, 421);
            this.button_returnForm2.Name = "button_returnForm2";
            this.button_returnForm2.Size = new System.Drawing.Size(108, 46);
            this.button_returnForm2.TabIndex = 1;
            this.button_returnForm2.Text = "回首頁";
            this.button_returnForm2.UseVisualStyleBackColor = true;
            this.button_returnForm2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_poolTable
            // 
            this.panel_poolTable.BackColor = System.Drawing.Color.Green;
            this.panel_poolTable.Location = new System.Drawing.Point(26, 82);
            this.panel_poolTable.Name = "panel_poolTable";
            this.panel_poolTable.Size = new System.Drawing.Size(643, 306);
            this.panel_poolTable.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 479);
            this.Controls.Add(this.panel_poolTable);
            this.Controls.Add(this.button_returnForm2);
            this.Controls.Add(this.label_welcome);
            this.Name = "Form2";
            this.Text = "遊戲頁面";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_returnForm2;
        private System.Windows.Forms.Panel panel_poolTable;
    }
}