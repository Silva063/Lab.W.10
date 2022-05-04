using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            //Создание прямоугольников
            Region region1 = new Region(new Rectangle(0, 300, 900, 300));
            Region region2 = new Region(new Rectangle(0, 0, 900, 300));


            //Создание неба (заливка прямоугольника)
            SolidBrush solidBrush2 = new SolidBrush(Color.MidnightBlue);
            e.Graphics.FillRegion(solidBrush2, region2);




            //Создание месяца (круг с заливкой)
            SolidBrush solidBrush3 = new SolidBrush(Color.Gold);
            e.Graphics.FillEllipse(solidBrush3, 600, 50, 150, 150);


            //Создание звёзд
            SolidBrush solidBrush9 = new SolidBrush(Color.MidnightBlue);
            e.Graphics.FillEllipse(solidBrush9, 580, 50, 120, 120);
            Random random = new Random();
            int x = 1; int y = 1; int i = 5;
            for (x = 0; x < 900; x += 20 + i * random.Next(-1, 1))
            {
                for (y = 10; y <= 150; y += 20 + i * random.Next(-1, 1))
                {
                    SolidBrush solidBrush10 = new SolidBrush(Color.Cornsilk);
                    e.Graphics.FillEllipse(solidBrush10, x, y, 2, 2);

                }

            }



            //Создание и заливки cтвола
            PointF point11 = new PointF(340.0F, 300.0F);
            PointF point21 = new PointF(350.0F, 100.0F);
            PointF point31 = new PointF(380.0F, 300.0F);
            PointF[] points1 = { point11, point21, point31 };
            SolidBrush solidBrush5 = new SolidBrush(Color.SaddleBrown);
            e.Graphics.FillClosedCurve(solidBrush5, points1);


            //Создание и заливка кроны

            PointF point12 = new PointF(300.0F, 160.0F);
            PointF point22 = new PointF(350.0F, 100.0F);
            PointF point32 = new PointF(400.0F, 160.0F);
            PointF[] points2 = { point12, point22, point32 };

            SolidBrush solidBrush7 = new SolidBrush(Color.Green);
            e.Graphics.FillClosedCurve(solidBrush7, points2);


            PointF point13 = new PointF(290.0F, 210.0F);
            PointF point23 = new PointF(350.0F, 150.0F);
            PointF point33 = new PointF(410.0F, 210.0F);
            PointF[] points3 = { point13, point23, point33 };

            e.Graphics.FillClosedCurve(solidBrush7, points3);

            PointF point14 = new PointF(270.0F, 260.0F);
            PointF point24 = new PointF(350.0F, 200.0F);
            PointF point34 = new PointF(430.0F, 260.0F);
            PointF[] points4 = { point14, point24, point34 };

            e.Graphics.FillClosedCurve(solidBrush7, points4);

            //Создание травы (заливка прямоугольника)
            SolidBrush solidBrush1 = new SolidBrush(Color.ForestGreen);
            e.Graphics.FillRegion(solidBrush1, region1);



            //Создание холмов (эллипсы с заливкой)
            SolidBrush solidBrush4 = new SolidBrush(Color.ForestGreen);
            e.Graphics.FillEllipse(solidBrush4, 50, 250, 300, 100);
            //  e.Graphics.FillEllipse(solidBrush4, 75, 200, 150, 170);
            e.Graphics.FillEllipse(solidBrush4, 20, 270, 100, 75);
            e.Graphics.FillEllipse(solidBrush4, 450, 250, 300, 120);
            e.Graphics.FillEllipse(solidBrush4, 350, 270, 100, 75);


            //Создание облаков (эллипсы с заливкой)
            SolidBrush solidBrush6 = new SolidBrush(Color.SteelBlue);
            e.Graphics.FillEllipse(solidBrush6, 370, 70, 100, 50);
            e.Graphics.FillEllipse(solidBrush6, 360, 80, 200, 70);
            e.Graphics.FillEllipse(solidBrush6, 420, 70, 100, 80);
            e.Graphics.FillEllipse(solidBrush6, 440, 75, 100, 50);

        }
    }
}
