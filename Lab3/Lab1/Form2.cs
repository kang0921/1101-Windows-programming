using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1
{
    public partial class Form2 : Form
    {
        static Graphics g;	        //繪圖裝置（一個就夠了）
        static int r = 10, r2 = 20; //半徑，直徑
        class ball  //球 class(類別)
        {     
            int id;                        //球編號
            public double x = 0, y = 0;    //球心 坐標
            Color c;                       //球顏色
            SolidBrush br;                 //刷子（畫球用）
            public ball(int bx, int by, Color cc, int i)    //建構者
            {  
                x = bx;                     //球心 x 坐標
                y = by;                     //球心 y 坐標
                c = cc;                     //球顏色    
                br = new SolidBrush(cc);    //球顏色的刷子
                id = i;                     //球編號
            }
            public void draw()               //畫 球物件 自己
            {      
                g.FillEllipse(br, (int)(x - r), (int)(y - r), r2, r2); //畫橢圓（球刷子，左上角 坐標，直徑寬，直徑高）
            }
        }	//class ball 結束

        ball[] balls = new ball[10];  // 10 顆球的陣列  宣告，new 

        public Form2()
        {    //Form2 建構者：和 class(類別) 同名 的副程式，new時 被自動執行
            InitializeComponent();               //系統 預設的 初始化（不要更動）
            g = panel_poolTable.CreateGraphics();//繪圖裝置 初始化
            for (int i = 1; i < 5; i++) //new 每個球，ball 建構者參數 見 work_note3 說明
                balls[i] = new ball(110, i * (r2 + 5)+40, Color.FromArgb(255, (i * 100) % 256, (i * 50) % 256, (i * 25) % 256), i);
            for (int i = 5; i < 8; i++) //new 每個球，ball 建構者參數 見 work_note3 說明
                balls[i] = new ball(135, i * (r2 + 5)-45, Color.FromArgb(255, (i * 100) % 256, (i * 50) % 256, (i * 25) % 256), i);
            for (int i = 8; i < 10; i++) //new 每個球，ball 建構者參數 見 work_note3 說明
                balls[i] = new ball(160, i * (r2 + 5)-105, Color.FromArgb(255, (i * 100) % 256, (i * 50) % 256, (i * 25) % 256), i);

            balls[0] = new ball(400, 110, Color.FromArgb(255, 255, 255, 255), 0);   // 0號球(母球)， 白色，放右邊中間
        }


        // form2 關閉 事件
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {   
            Owner.Show();     // form1（首視窗）出現
        }

        private void panel_poolTable_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)     // 10 顆球
                balls[i].draw();     //每個球 畫自己
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label_welcome.Text = "歡迎" + ((Form1)Owner).textBox_account.Text;

        }

        private void button_returnForm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

    }
}