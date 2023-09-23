namespace paintV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 970;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;// me sale error en Image por que no tiene una definicion el panel 


        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen borrador = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            cX = e.X;
            cY = e.Y;

        }



        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX; sY = y - cY;



            if (index == 3)
            {

                g.DrawEllipse(p, cX, cY, sX, sY);



            }
            if (index == 4)
            {

                g.DrawRectangle(p, cX, cY, sX, sY);


            }
            if (index == 5)
            {

                g.DrawLine(p, cX, cY, sX, sY);
            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)

            {
                pic.Refresh();
                if (index == 1)
                {

                    px = e.Location;

                    g.DrawLine(p, px, py);

                    py = px;

                }
                if (index == 2)
                {

                    px = e.Location;

                    g.DrawLine(borrador, px, py);

                    py = px;

                }


                pic.Refresh();

            }
            pic.Refresh();

            x = e.X; y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_borrador_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_elipce_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_rectangulo_Click(object sender, EventArgs e)
        {
            index = 4;

        }

        private void btn_Linea_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            pic.BackgroundImage = bm;

            index = 0;

        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        static Point set_Point(PictureBox pb, Point pt)

        {

            float Px = 1f * pb.Image.Width / pb.Width;

            float pY = 1f * pb.Image.Height / pb.Height;

            return new Point((int)(pt.X * Px), (int)(pt.Y * pY));







        }

        private void Color_box_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_Point(Color_box, e.Location);
            pic_color.BackColor = ((Bitmap)Color_box.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {

            Color cx = bm.GetPixel(x, y);

            if (cx == old_color)

            {

                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);


            }


        }
        public void Fill(Bitmap bm, int x, int y, Color new_clr)

        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);

            if (old_color == new_clr) return;

            while (pixel.Count > 0)
            {

                Point pt = (Point)pixel.Pop();

                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)

                {

                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);

                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_color);
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_color);
                    validate(bm, pixel, pt.X - 1, pt.Y + 1, old_color, new_color);

                }

            }

        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_Point(pic, e.Location); //no se puede convertir un panel en picture box 
                Fill(bm, point.X, point.Y, new_color);

            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }
    }



}