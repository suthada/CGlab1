using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGlab1
{
    public partial class HNYtext : Form
    {
        public HNYtext()
        {
            InitializeComponent();
        }


        private void btnShow_Click_1(object sender, EventArgs e)
        {
            System.Drawing.Graphics myGraphic;
            myGraphic = this.CreateGraphics();

            Pen myPen1 = new Pen(System.Drawing.Color.Black, 5);
            Pen myPen2 = new Pen(System.Drawing.Color.Black, 3);
            Pen myPen3 = new Pen(System.Drawing.Color.Black, 10);

            SolidBrush DarkGreenBrush = new SolidBrush(Color.DarkGreen); //ระบายสีข้างใน
            SolidBrush DarkRedBrush = new SolidBrush(Color.DarkRed);
            SolidBrush BlackBrush = new SolidBrush(Color.Black);
            SolidBrush FloralWhiteBrush = new SolidBrush(Color.FloralWhite); //สีที่จมูก
            SolidBrush MistyRoseBrush = new SolidBrush(Color.MistyRose); //สีที่แก้ม
            SolidBrush LightPinkBrush = new SolidBrush(Color.LightPink); //สีที่ปาก
            SolidBrush SaddleBrownBrush = new SolidBrush(Color.SaddleBrown); //สีน้ำตาลเข้ม

            //myGraphic.DrawLine(myPen1, 50, 50, 200, 50); //จุดเร่ิ่ม จุดสิ้นสุด [เส้นตรง]
            //myGraphic.DrawRectangle(myPen1, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของสี่เหลี่ยม  
            //myGraphic.DrawEllipse(myPen2, 45, 95, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของกรอบสี่เหลี่ยม
            //myGraphic.DrawArc(myPen1, 100, 100, 450, 450, 0, 45); //จุดมุมบนซ้าย ความกว้าง ความสูง องศาเริ่ม องศาสิ้นสุด ตามเข็ม 

            //ลูกบอล
            
            myGraphic.DrawEllipse(myPen1, 671, 105, 60, 60); //วงกลม1ได้แล้ว
            myGraphic.DrawLine(myPen1, 700, 0, 700, 100); //เส้น1ได้แล้ว
            myGraphic.DrawRectangle(myPen1, 690, 100, 20, 7); //สี่เหลี่ยมตกแต่ง1ได้แล้ว
            myGraphic.FillEllipse(DarkGreenBrush, 671, 105, 60, 60);
            myGraphic.FillRectangle(BlackBrush, 690, 100, 20, 7);

            myGraphic.DrawEllipse(myPen1, 500, 66, 45, 45); //วงกลม2ได้แล้ว
            myGraphic.DrawLine(myPen1, 523, 0, 523, 60); //เส้น1ได้แล้ว
            myGraphic.DrawRectangle(myPen1, 515, 62, 15, 5); //สี่เหลี่ยมตกแต่ง2ได้แล้ว
            myGraphic.FillEllipse(DarkRedBrush, 500, 66, 45, 45);

            myGraphic.DrawEllipse(myPen1, 300, 85, 60, 60); //วงกลม3ได้แล้ว
            myGraphic.DrawLine(myPen1, 330, 0, 330, 80); //เส้น3ได้แล้ว
            myGraphic.DrawRectangle(myPen1, 320, 80, 20, 7); //สี่เหลี่ยมตกแต่ง3ได้แล้ว
            myGraphic.FillEllipse(DarkGreenBrush, 300, 85, 60, 60);
            myGraphic.FillRectangle(BlackBrush, 320, 80, 20, 7);

            myGraphic.DrawEllipse(myPen1, 130, 66, 60, 60); //วงกลม4ได้แล้ว
            myGraphic.DrawLine(myPen1, 160, 0, 160, 60); //เส้น4ได้แล้ว
            myGraphic.DrawRectangle(myPen1, 150, 62, 20, 7); //สี่เหลี่ยมตกแต่ง4ได้แล้ว
            myGraphic.FillEllipse(DarkRedBrush, 130, 66, 60, 60);
            myGraphic.FillRectangle(BlackBrush, 150, 62, 20, 7);

            myGraphic.DrawEllipse(myPen1, 30, 105, 45, 45); //วงกลม5ได้แล้ว
            myGraphic.DrawLine(myPen1, 52, 0, 52, 100); //เส้น5ได้แล้ว
            myGraphic.DrawRectangle(myPen1, 45, 102, 15, 5); //สี่เหลี่ยมตกแต่ง5ได้แล้ว
            myGraphic.FillEllipse(DarkGreenBrush, 30, 105, 45, 45);
            myGraphic.FillRectangle(BlackBrush, 45, 102, 15, 5);

            //น้องหมา

            myGraphic.DrawRectangle(myPen1, 40, 420, 100, 100); //ตัว
            myGraphic.DrawRectangle(myPen1, 60, 520, 20, 30); //ขาซ้าย
            myGraphic.DrawRectangle(myPen1, 100, 520, 20, 30); //ขาขวา

            myGraphic.DrawRectangle(myPen1, 50, 410, 30, 10); //หูซ้าย
            myGraphic.FillRectangle(MistyRoseBrush, 50, 410, 30, 10);

            myGraphic.DrawRectangle(myPen1, 100, 410, 30, 10); //หูขวา
            myGraphic.FillRectangle(MistyRoseBrush, 100, 410, 30, 10);

            myGraphic.DrawRectangle(myPen2, 50, 470, 15, 5); //แก้มซ้าย
            myGraphic.FillRectangle(MistyRoseBrush, 50, 470, 15, 5);

            myGraphic.DrawRectangle(myPen2, 115, 470, 15, 5); //แก้มขวา
            myGraphic.FillRectangle(MistyRoseBrush, 115, 470, 15, 5);

            myGraphic.DrawRectangle(myPen2, 80, 470, 20, 15); //จมูก
            myGraphic.FillRectangle(FloralWhiteBrush, 81, 472, 19, 11);


            myGraphic.DrawRectangle(myPen2, 83, 485, 15, 9); //ปาก
            myGraphic.FillRectangle(LightPinkBrush, 85, 487, 13, 7);



            myGraphic.DrawRectangle(myPen3, 57, 440, 20, 15); //ตาซ้าย

            myGraphic.DrawRectangle(myPen3, 102, 440, 20, 15); //ตาขวา

            myGraphic.DrawRectangle(myPen2, 60, 520, 10, 15); //ลายขาซ้ายบน1
            myGraphic.FillRectangle(BlackBrush, 60, 520, 10, 15);

            myGraphic.DrawRectangle(myPen2, 70, 538, 8, 10); //ลายขาซ้ายล่าง2
            myGraphic.FillRectangle(BlackBrush, 70, 538, 8, 10);

            myGraphic.DrawRectangle(myPen2, 100, 530, 8, 10); //ลายขาขวาบน1
            myGraphic.FillRectangle(BlackBrush, 100, 530, 8, 10);

            myGraphic.DrawRectangle(myPen2, 110, 540, 8, 10); //ลายขาขวาล่าง2
            myGraphic.FillRectangle(BlackBrush, 110, 540, 8, 10);

            myGraphic.DrawRectangle(myPen2, 42, 422, 15, 10); //ลายตัว1
            myGraphic.FillRectangle(BlackBrush, 42, 422, 15, 10);

            myGraphic.DrawRectangle(myPen2, 112, 492, 25, 25); //ลายตัว2
            myGraphic.FillRectangle(BlackBrush, 112, 492, 25, 25);

            //กล่อง
            myGraphic.DrawRectangle(myPen1, 600, 490, 70, 60); //กล่อง1
            myGraphic.FillRectangle(MistyRoseBrush, 602, 492, 67, 57);

            myGraphic.DrawRectangle(myPen1, 590, 469, 90, 20); //ฝากล่อง1
            myGraphic.FillRectangle(DarkRedBrush, 592, 470, 87, 17);

            myGraphic.DrawRectangle(myPen1, 627, 469, 15, 75); //โบว์1
            myGraphic.FillRectangle(DarkRedBrush, 628, 472, 14, 74);

            // พรม

            myGraphic.DrawRectangle(myPen2, 0, 548, 819, 20);
            myGraphic.FillRectangle(DarkRedBrush, 0, 550, 819, 28);


            /*
             //สีไล่ระดับ
            Rectangle rect = new Rectangle(50, 30, 200, 200);
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red,Color.Green, LinearGradientMode.BackwardDiagonal);
            myGraphic.FillRectangle(lBrush, rect);
            myGraphic.DrawRectangle(myPen1, 40, 420, 100, 100);
            */
            //Vertical แนวตั้ง
            //BackwardDiagonal แนวเฉียง

            
            Rectangle rect4 = new Rectangle(175, 297, 400, 250); //ตัวบ้าน
            LinearGradientBrush LGBrush4 = new LinearGradientBrush(rect4, Color.Sienna, Color.BurlyWood, LinearGradientMode.Vertical);
            myGraphic.FillRectangle(LGBrush4, rect4);

            Rectangle rect1 = new Rectangle(200, 350, 45, 70); //หน้าต่างซ้าย
            LinearGradientBrush LGBrush1 = new LinearGradientBrush(rect1, Color.BurlyWood, Color.Ivory, LinearGradientMode.Vertical);
            myGraphic.FillRectangle(LGBrush1, rect1);

            Rectangle rect2 = new Rectangle(502, 350, 45, 70); //หน้าต่างขวา
            LinearGradientBrush LGBrush2 = new LinearGradientBrush(rect2, Color.BurlyWood, Color.Ivory, LinearGradientMode.Vertical);
            myGraphic.FillRectangle(LGBrush2, rect2);

            Rectangle rect5 = new Rectangle(195, 145, 90, 90); //ปล่องไฟ
            LinearGradientBrush LGBrush5 = new LinearGradientBrush(rect5, Color.BurlyWood, Color.Peru, LinearGradientMode.Vertical);
            myGraphic.FillRectangle(LGBrush5, rect5);




            //บ้านขนม
            myGraphic.DrawRectangle(myPen2, 195, 145, 90, 90); //ปล่องไฟ
            myGraphic.DrawRectangle(myPen2, 175, 297, 400, 250); //ตัวบ้าน ไล่สีน้ำตา
            myGraphic.DrawRectangle(myPen2, 200, 350, 45, 70); //หน้าต่างซ้าย 
            myGraphic.DrawRectangle(myPen2, 502, 350, 45, 70); //หน้าต่างขวา

            myGraphic.DrawRectangle(myPen2, 332, 443, 90, 105); //ประตู
            myGraphic.FillRectangle(SaddleBrownBrush, 334, 445, 87, 103);

            myGraphic.DrawRectangle(myPen2, 127, 217, 500, 80); //หลังคา สีน้ำตาลเข้ม
            myGraphic.FillRectangle(SaddleBrownBrush, 129, 219, 497, 77);

            myGraphic.DrawLine(myPen2, 223, 422, 223, 350); // เส้นหน้าต่างซ้ายแนวตั้ง
            myGraphic.DrawLine(myPen2, 525, 422, 525, 350); // เส้นหน้าต่างขวาแนวตั้ง

            
        }
    }
}
