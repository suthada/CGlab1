using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGlab1
{
    public partial class Form1 : Form
    {
        public Form1()
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

            //myGraphic.DrawLine(myPen1, 50, 50, 200, 50); //จุดเร่ิ่ม จุดสิ้นสุด [เส้นตรง]
            //myGraphic.DrawRectangle(myPen1, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของสี่เหลี่ยม  
            //myGraphic.DrawEllipse(myPen2, 45, 95, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของกรอบสี่เหลี่ยม
            //myGraphic.DrawArc(myPen1, 100, 100, 450, 450, 0, 45); //จุดมุมบนซ้าย ความกว้าง ความสูง องศาเริ่ม องศาสิ้นสุด ตามเข็ม 
            
            //ลูกบอล

            myGraphic.DrawEllipse(myPen1, 671, 171, 60, 60); //วงกลม1ได้แล้ว
            myGraphic.DrawLine(myPen1, 700, 160, 700, 40); //เส้น1ได้แล้ว
            myGraphic.DrawRectangle(myPen1, 690, 160, 20, 7); //สี่เหลี่ยมตกแต่ง1ได้แล้ว
            myGraphic.FillEllipse(DarkGreenBrush, 671, 171, 60, 60);
            myGraphic.FillRectangle(BlackBrush, 690, 160, 20, 7);

            myGraphic.DrawEllipse(myPen1, 500, 120, 45, 45); //วงกลม2ได้แล้ว
            myGraphic.DrawLine(myPen1, 523, 110, 523, 30); //เส้น1ได้แล้ว
            myGraphic.DrawRectangle(myPen1, 515, 110, 15, 5); //สี่เหลี่ยมตกแต่ง2ได้แล้ว
            myGraphic.FillEllipse(DarkRedBrush, 500, 120, 45, 45);

            myGraphic.DrawEllipse(myPen1, 300, 141, 60, 60); //วงกลม3ได้แล้ว
            myGraphic.DrawLine(myPen1, 330, 130, 330, 40); //เส้น3ได้แล้ว
            myGraphic.DrawRectangle(myPen1, 320, 130, 20, 7); //สี่เหลี่ยมตกแต่ง3ได้แล้ว
            myGraphic.FillEllipse(DarkGreenBrush, 300, 141, 60, 60);
            myGraphic.FillRectangle(BlackBrush, 320, 130, 20, 7);

            myGraphic.DrawEllipse(myPen1, 130, 171, 60, 60); //วงกลม4ได้แล้ว
            myGraphic.DrawLine(myPen1, 160, 158, 160, 40); //เส้น4ได้แล้ว
            myGraphic.DrawRectangle(myPen1, 150, 160, 20, 7); //สี่เหลี่ยมตกแต่ง4ได้แล้ว
            myGraphic.FillEllipse(DarkRedBrush, 130, 171, 60, 60);
            myGraphic.FillRectangle(BlackBrush, 150, 160, 20, 7);

            myGraphic.DrawEllipse(myPen1, 30, 120, 45, 45); //วงกลม5ได้แล้ว
            myGraphic.DrawLine(myPen1, 52, 110, 52, 30); //เส้น5ได้แล้ว
            myGraphic.DrawRectangle(myPen1, 45, 110, 15, 5); //สี่เหลี่ยมตกแต่ง5ได้แล้ว
            myGraphic.FillEllipse(DarkGreenBrush, 30, 120, 45, 45);
            myGraphic.FillRectangle(BlackBrush, 45, 110, 15, 5);

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


            // พรม

            myGraphic.DrawRectangle(myPen2, 0, 548, 819, 20); 
            myGraphic.FillRectangle(DarkRedBrush, 0, 550, 819, 28);









        }
    }
}
