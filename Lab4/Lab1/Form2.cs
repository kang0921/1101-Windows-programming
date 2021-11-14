﻿using System;
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
        static double fr = 0;  // 摩擦力
        BufferedGraphicsContext currentContext;
        BufferedGraphics gBuffer;
        static int width = 0, height = 0;  //球桌  寬，高
        class ball  //球 class(類別)
        {     
            int id;                        //球編號
            public double x = 0, y = 0;    //球心 坐標
            Color c;                       //球顏色
            SolidBrush br;                 //刷子（畫球用）
            private double ang = 0;       //ex4：球 行進角度
            public double cosA, sinA;   //ex4：coSine 行進角度, Sine 行進角度
            public double spd = 0;    // 球 行進速度

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
            public void setAng(double _ang)
            {    //ex4：角度 改變
                ang = _ang;                       // 存 新角度
                cosA = Math.Cos(ang);     //  重算 coSine
                sinA = Math.Sin(ang);       //  重算 Sine
            }
            public void drawStick()
            {    //ex4：畫球桿
                double r12 = 12 * r;
                Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);    // 宣告 + new 深藍色  畫筆
                skyBluePen.Width = 3.0F;   // 改變 畫筆 寬度
                g.DrawLine(skyBluePen,      // 深藍色  畫筆
                     (float)(x - r12 * cosA), (float)(y - r12 * sinA),    //  12 倍大的 同心圓周上的點
                     (float)(x - r * cosA), (float)(y - r * sinA)        //  球 圓周上的點
                );                                                        // - r12   -r , 使球杆 畫在滑鼠點的另一邊
            }
            
            public void move() 
            {  //  移動 球
                if (spd > 0)  {  //  速度 >0 才移動
                    x += spd * cosA;   //  x 方向分量
                    y += spd * sinA;    //  y 方向分量
                    spd -= fr;              //  速度 依摩擦力大小 遞減
                }
                else spd = 0;  //  避免 <0 而反向移動
            }
            
            public void rebound() {  //球碰邊反彈，或進洞
                if (x < r || x > width - r) {  //出左右邊
                    setAng(Math.PI - ang);
                    if (x < r)
                        x = r;    // 拉回桌 內
                    else
                        x = width - r;
                }
　　　           else if (y < r || y > height - r) { //出上下邊
                    setAng(-ang);
                    if (y < r)
                        y = r;    //拉回桌 內
                    else
                        y = height - r;
                 }
            }
        }	//class ball 結束

        ball[] balls = new ball[10];  // 10 顆球的陣列  宣告，new 

        public Form2()
        {    //Form2 建構者：和 class(類別) 同名 的副程式，new時 被自動執行
            InitializeComponent();               //系統 預設的 初始化（不要更動）
            g = panel_poolTable.CreateGraphics();//繪圖裝置 初始化
            for (int i = 1; i < 5; i++) //new 每個球，ball 建構者參數 見 work_note3 說明
                balls[i] = new ball(110, i * (r2 + 5)+100, Color.FromArgb(255, (i * 100) % 256, (i * 50) % 256, (i * 25) % 256), i);
            for (int i = 5; i < 8; i++) //new 每個球，ball 建構者參數 見 work_note3 說明
                balls[i] = new ball(135, i * (r2 + 5)+20, Color.FromArgb(255, (i * 100) % 256, (i * 50) % 256, (i * 25) % 256), i);
            for (int i = 8; i < 10; i++) //new 每個球，ball 建構者參數 見 work_note3 說明
                balls[i] = new ball(160, i * (r2 + 5)-40, Color.FromArgb(255, (i * 100) % 256, (i * 50) % 256, (i * 25) % 256), i);

            balls[0] = new ball(460, 170, Color.FromArgb(255, 255, 255, 255), 0);   // 0號球(母球)， 白色，放右邊中間
            balls[0].setAng(Math.PI / 4);    //ex4： 0號球(母球) 角度 改變 為 45 度
            width = panel_poolTable.Width;
            height = panel_poolTable.Height;
        }

        private void panel_poolTable_Paint(object sender, PaintEventArgs e)
        {    // panel1  Paint(繪圖) 事件
            for (int i = 0; i < 10; i++)     //10 顆球
                balls[i].draw();     //每個球 畫自己

            if (balls[0].spd < 0.0001) balls[0].drawStick();     //  ex5：0號球停止時 才畫指向 0號球(母球) 的球桿
        }

        private void panel_poolTable_MouseDown(object sender, MouseEventArgs e)
        {
            double a = Math.Atan2(e.Y - balls[0].y, e.X - balls[0].x); // e:滑鼠 點擊處坐標
            balls[0].setAng(a); // 存入母球 行進角度
            panel_poolTable.Refresh(); // 重新繪畫轉動過的球桿
            g.DrawRectangle(Pens.HotPink, e.X - 2, e.Y - 2, 4, 4); // 點擊點 畫小方塊
        }

        

        // form2 關閉 事件
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {   
            Owner.Show();     // form1（首視窗）出現
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label_welcome.Text = "歡迎" + ((Form1)Owner).textBox_account.Text;

        }
        private void hit(ball b0, ball b1)
        {
            if (b0.spd < b1.spd)
            {   // b1 hit  b0  速度快的 撞 慢的
                ball t = b0;     //  交換球，讓速度快的球 成為 b0
                b0 = b1;
                b1 = t;
            }
            double dx = b1.x - b0.x, dy = b1.y - b0.y;
            if (Math.Abs(dx) <= r2 && Math.Abs(dy) <= r2)
            { //  x坐標間差距 < 球直徑
              // 而且　　y坐標間差距 < 球直徑
                double ang = Math.Atan2(dy, dx);   //  球b0 中心 到 球b1 中心 連線方向
                b1.setAng(ang);     //  球b1 被撞后方向
                b0.setAng(ang + Math.PI / 2.0);   //  球b0  碰撞 b1 后 和 b1 的夾角 90° 

                double spd_average = (b0.spd + b1.spd) / 2.0;
                b0.spd = b1.spd = spd_average;    //  碰撞 後 先大略平均分配 兩球的速度
                                                  // 白球速度 == 紅球速度 == 兩球的速度 和 /2
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double sum_spd = 0;  // 球速度 加總
            panel_poolTable.Refresh();  //呼叫panel1_Paint 事件處理副程式

            for (int i = 0; i < 10; i++)
            {
                if (balls[i].spd > 0)
                {  // 有速度，才有可能移動，碰撞 。。。
                    balls[i].move(); //移動後偵測碰撞
                    sum_spd += balls[i].spd;
                    balls[i].rebound(); //  + 拉回桌上

                    for (int j = i + 1; j < 10; j++)  // j > i 兩球間不重複碰撞偵測
                        hit(balls[i], balls[j]);

                }
            }

            if (sum_spd <= 0.001)
            {  //  所有球 都停了
                timer1.Stop();		//  停止 計時器
                panel_poolTable.Refresh();
            }        
            
        }

        private void hit_button_Click(object sender, EventArgs e)
        {
            // 每次擊球，重新初始化打擊力，摩擦力
            balls[0].spd = vScrollBar1.Maximum - vScrollBar1.Value; // 母球 加 速度
            fr = (vScrollBar2.Maximum - vScrollBar2.Value) / 50.0;  // 摩擦力
            timer1.Enabled = true;  // 開始定時 呼叫timer1_Tick
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_returnForm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

    }
}