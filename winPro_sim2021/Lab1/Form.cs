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
    public partial class Form : System.Windows.Forms.Form
    {
        static Graphics g;	                        // 繪圖裝置（一個就夠了）
        static int r = 10, r2 = 20;                 // 半徑，直徑
        static double fr = 0;                       // 摩擦力
        static int width = 0, height = 0;           // 球桌寬，高
        static int boxWidth = 300, boxHeight = 80;  // 方塊寬，高
        static int count = 0;                       // 計算掉落的方塊數
        static bool countFlag = true;
        class ball  //球 class(類別)
        {     
            int id;                                 // 球編號
            public double x = 0, y = 0;             // 球心 坐標
            Color c;                                // 球顏色
            SolidBrush br;                          // 刷子（畫球用）
            private double ang = 0;                 // 球 行進角度
            public double cosA, sinA;               // coSine 行進角度, Sine 行進角度
            public double spd = 0;                  // 球 行進速度
            static int count = 0;                   // 計算掉落的方塊數

            public ball(int bx, int by, Color cc, int i)    // 建構者
            {  
                x = bx;                             // 球心 x 坐標
                y = by;                             // 球心 y 坐標
                c = cc;                             // 球顏色    
                br = new SolidBrush(cc);            // 球顏色的刷子
                id = i;                             // 球編號
            }
            public void draw()                      // 畫 球物件 自己
            {      
                g.FillEllipse(br, (int)(x - r), (int)(y - r), r2, r2); // 畫橢圓（球刷子，左上角 坐標，直徑寬，直徑高）
            }
            public void setAng(double _ang)         // 角度 改變
            {    
                ang = _ang;                         // 存 新角度
                cosA = Math.Cos(ang);               // 重算 coSine
                sinA = Math.Sin(ang);               // 重算 Sine
            }
            public void drawStick()                 // 畫砲管
            {    
                double r12 = 12 * r;
                Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);            // 宣告 + new 深藍色  畫筆
                skyBluePen.Width = 25.0F;                                 // 改變 畫筆 寬度
                g.DrawLine(skyBluePen,                                    // 深藍色 畫筆
                     (float)(x + r12 * cosA), (float)(y + r12 * sinA),    //  12 倍大的 同心圓周上的點
                     (float)(x + r * cosA), (float)(y + r * sinA)         //  球 圓周上的點
                );                                                        // - r12   -r , 使球杆 畫在滑鼠點的另一邊
            }

            public void drawOrangeBox(int width, int height)              // 畫方塊
            {
                g.FillRectangle(br, (float)x, (float)y, width, height);   // 畫方塊 (畫筆，x座標，y座標，寬，高)
            }
            
            public void move()                      // 移動 球
            {  
                if (spd > 0)  {                     // 速度 >0 才移動
                    x += spd * cosA;                // x 方向分量
                    y += spd * sinA;                // y 方向分量
                    spd -= fr;                      // 速度 依摩擦力大小 遞減
                }
                else spd = 0;                       // 避免 <0 而反向移動
            }
            
            public void rebound() {                 // 球碰邊反彈，或進洞
                if (x < r || x > width - r) {       // 出左右邊
                    setAng(Math.PI - ang);
                    if (x < r)
                        x = r;                      // 拉回桌 內
                    else
                        x = width - r;
                }
　　　           else if (y < r || y > height - r) { // 出上下邊
                    setAng(-ang);
                    if (y < r)
                        y = r;                      // 拉回桌 內
                    else
                        y = height - r;
                 }
            }
        }	//class ball 結束

        ball[] balls = new ball[10];                // 10 顆球的陣列  宣告，new 

        public Form()                               //Form 建構者：和 class(類別) 同名 的副程式，new時 被自動執行
        {    
            InitializeComponent();                  //系統 預設的 初始化（不要更動）
            g = panel_poolTable.CreateGraphics();   //繪圖裝置 初始化
 
            balls[0] = new ball(600, 600, Color.Gray, 0);       // 子彈
            balls[1] = new ball(600, 675, Color.Blue, 1);       // 砲管
            balls[2] = new ball(500, 100, Color.Orange, 2);     // 方塊

            balls[0].setAng(Math.PI * 3 / 2);                   // 子彈 角度 改變
            balls[1].setAng(Math.PI * 3 / 2);                   // 砲管 角度 改變
            balls[2].setAng(0);                                 // 方塊 角度 改變

            balls[0].x = balls[1].x + 130 * balls[1].cosA;      // 子彈x座標
            balls[0].y = balls[1].y + 130 * balls[1].sinA;      // 子彈y座標

            balls[2].spd = 80;                                  // 方塊速度

            width = panel_poolTable.Width;                      // 球桌的寬
            height = panel_poolTable.Height;                    // 球桌的高

            timer2.Enabled = true;                              // 啟用timer2

        }


        private void panel_poolTable_Paint(object sender, PaintEventArgs e) // Paint(繪圖) 事件
        {    
            balls[0].draw();                                    // 畫子彈
            balls[1].drawStick();                               // 畫砲管
            balls[2].drawOrangeBox(boxWidth, boxHeight);        // 畫方塊(設定方塊的寬，高)

            countLB.Text = "擊落數：" + count + "個";            // 設定擊落數的標籤文字
        }

        private void panel_poolTable_MouseDown(object sender, MouseEventArgs e)
        {
            double a = Math.Atan2(e.Y - balls[0].y, e.X - balls[0].x);  // e:滑鼠 點擊處坐標
            balls[0].setAng(a);                                         // 子彈 行進角度
            balls[1].setAng(a);                                         // 砲管 行進角度

            balls[0].x = balls[1].x + 130 * balls[1].cosA;              // 子彈x座標
            balls[0].y = balls[1].y + 130 * balls[1].sinA;              // 子彈y座標

            panel_poolTable.Refresh();                                  // 重新繪畫轉動過的球桿
            g.DrawRectangle(Pens.HotPink, e.X - 2, e.Y - 2, 10, 10);    // 點擊點 畫小方塊

                                                                        // 每次擊球，重新初始化打擊力，摩擦力
            balls[0].spd = 20;                                          // 子彈速度
            fr = 0;                                                     // 摩擦力
            timer1.Enabled = true;                                      // 開始定時 呼叫timer1_Tick

            countFlag = true;
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            countLB.Text = "擊落數：" + count + "個";                    // 設定擊落數的標籤文字
        }
        private void hit(ball bullet, ball box)
        {
            double dx = bullet.x - box.x;                               // x坐標間差距 
            double dy = bullet.y - box.y;                               // y坐標間差距
            if (bullet.x <= box.x + boxWidth && bullet.x >= box.x &&    // 子彈在方塊的x範圍內
                bullet.y <= box.y + boxHeight && bullet.y >= box.y)     // 子彈在方塊的y範圍內
            {
                double ang = Math.Atan2(dy, dx);                        // 子彈 中心 到 方塊 中心 連線方向
                box.setAng(90);                                         // 方塊 被撞後方向(垂直向下)
                box.cosA = 0;                                           // 設定橘色方塊之後x座標的變化是0
                box.spd = 120;                                          // 方塊 被撞後速度
                bullet.setAng(ang + Math.PI / 2.0);                     // 子彈 碰撞 方塊 後 和 子彈 的夾角 90° 

                double spd_average = (bullet.spd + box.spd) / 5.0;      // 碰撞後先大略平均分配 兩物體的速度
                bullet.spd = spd_average;                               // 子彈速度 == 兩球的速度和 /2

                if (countFlag)
                {
                    count++;                                            // 擊落數 +1
                    countFlag = false;
                }
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_poolTable.Refresh();  //呼叫panel1_Paint 事件處理副程式

            if (balls[0].spd > 0)       // 子彈有移動
            {  
                balls[0].move();        // 移動後偵測碰撞
            }

            hit(balls[0], balls[2]);    // 子彈撞方塊

            if( balls[0].x > width + r || balls[0].x <= 0 - r || balls[0].y >= height + r || balls[0].y <= 0 - r ) // 子彈出界
            {
                balls[0].x = balls[1].x + 130 * balls[1].cosA;      // 子彈回砲管出口(x座標)
                balls[0].y = balls[1].y + 130 * balls[1].sinA;      // 子彈回砲管出口(y座標)
                timer1.Stop();                                      // timer1暫停
                panel_poolTable.Refresh();                          // 重新繪製
            }
            

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (balls[2].spd >= 0)                      // 如果方塊速度>=0
            {
                balls[2].move();                        // 方塊移動
                panel_poolTable.Refresh();              // 重新繪畫移動過的方塊
                if (balls[2].x < 0)                     // 出左邊
                {  
                    balls[2].setAng(0);                 // 角度往右邊
                    balls[2].x = 0;                     // 拉回桌內                    
                }
                else if(balls[2].x > width - boxWidth)  // 出右邊
                {
                    balls[2].setAng(Math.PI);           // 角度往左邊
                    balls[2].x = width - boxWidth;      // 拉回桌內
                }

                if(balls[2].y >= height)                // 方塊往下掉落出界
                {
                    balls[2].x = 500;                   // 方塊回原位(x座標)
                    balls[2].y = 100;                   // 方塊回原位(y座標)
                    balls[2].setAng(0);                 // 方塊角度
                    
                }

                panel_poolTable.Refresh();              // 重新繪製
            }
        }

    }
}
