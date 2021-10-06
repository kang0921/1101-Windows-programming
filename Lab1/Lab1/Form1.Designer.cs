
namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_tittle = new System.Windows.Forms.Label();
            this.label_account = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_account = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_tittle
            // 
            this.label_tittle.AutoSize = true;
            this.label_tittle.BackColor = System.Drawing.Color.SkyBlue;
            this.label_tittle.Font = new System.Drawing.Font("思源黑體 Medium", 24F, System.Drawing.FontStyle.Bold);
            this.label_tittle.ForeColor = System.Drawing.SystemColors.Control;
            this.label_tittle.Location = new System.Drawing.Point(346, 71);
            this.label_tittle.Name = "label_tittle";
            this.label_tittle.Size = new System.Drawing.Size(226, 70);
            this.label_tittle.TabIndex = 0;
            this.label_tittle.Text = "撞球遊戲";
            this.label_tittle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.BackColor = System.Drawing.Color.SkyBlue;
            this.label_account.Font = new System.Drawing.Font("思源黑體 Medium", 16F);
            this.label_account.ForeColor = System.Drawing.Color.White;
            this.label_account.Location = new System.Drawing.Point(214, 178);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(84, 46);
            this.label_account.TabIndex = 1;
            this.label_account.Text = "帳號";
            this.label_account.Click += new System.EventHandler(this.label_account_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.SkyBlue;
            this.label_password.Font = new System.Drawing.Font("思源黑體 Medium", 16F);
            this.label_password.ForeColor = System.Drawing.SystemColors.Control;
            this.label_password.Location = new System.Drawing.Point(214, 241);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(84, 46);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "密碼";
            // 
            // textBox_account
            // 
            this.textBox_account.Font = new System.Drawing.Font("思源黑體 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_account.Location = new System.Drawing.Point(337, 178);
            this.textBox_account.Name = "textBox_account";
            this.textBox_account.Size = new System.Drawing.Size(235, 42);
            this.textBox_account.TabIndex = 3;
            this.textBox_account.TextChanged += new System.EventHandler(this.textBox_account_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("思源黑體 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_password.Location = new System.Drawing.Point(337, 247);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(235, 42);
            this.textBox_password.TabIndex = 4;
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("思源黑體 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_login.Location = new System.Drawing.Point(376, 328);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(151, 54);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "登入";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 513);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_account);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_account);
            this.Controls.Add(this.label_tittle);
            this.Name = "Form1";
            this.Text = "遊戲首頁";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tittle;
        private System.Windows.Forms.Label label_account;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        public System.Windows.Forms.TextBox textBox_account;
    }
}

