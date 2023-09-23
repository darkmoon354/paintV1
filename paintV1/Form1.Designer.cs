namespace paintV1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btn_limpiar = new Button();
            button1 = new Button();
            Color_box = new PictureBox();
            pic_color = new Button();
            panel3 = new Panel();
            btn_borrador = new Button();
            btn_Linea = new Button();
            btn_pincel = new Button();
            btn_rectangulo = new Button();
            btn_color = new Button();
            btn_elipce = new Button();
            btn_fill = new Button();
            pic = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Color_box).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btn_limpiar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Color_box);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 124);
            panel1.TabIndex = 0;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Location = new Point(870, 55);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(75, 46);
            btn_limpiar.TabIndex = 13;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(870, 5);
            button1.Name = "button1";
            button1.Size = new Size(76, 44);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // Color_box
            // 
            Color_box.BackColor = Color.White;
            Color_box.Cursor = Cursors.Hand;
            Color_box.Image = (Image)resources.GetObject("Color_box.Image");
            Color_box.Location = new Point(1, 1);
            Color_box.Name = "Color_box";
            Color_box.Size = new Size(211, 121);
            Color_box.SizeMode = PictureBoxSizeMode.StretchImage;
            Color_box.TabIndex = 11;
            Color_box.TabStop = false;
            Color_box.MouseClick += Color_box_MouseClick;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(218, 3);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(46, 23);
            pic_color.TabIndex = 2;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btn_borrador);
            panel3.Controls.Add(btn_Linea);
            panel3.Controls.Add(btn_pincel);
            panel3.Controls.Add(btn_rectangulo);
            panel3.Controls.Add(btn_color);
            panel3.Controls.Add(btn_elipce);
            panel3.Controls.Add(btn_fill);
            panel3.Location = new Point(270, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(594, 106);
            panel3.TabIndex = 10;
            // 
            // btn_borrador
            // 
            btn_borrador.BackColor = SystemColors.Window;
            btn_borrador.Cursor = Cursors.Hand;
            btn_borrador.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn_borrador.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_borrador.FlatStyle = FlatStyle.Flat;
            btn_borrador.Image = (Image)resources.GetObject("btn_borrador.Image");
            btn_borrador.Location = new Point(257, 9);
            btn_borrador.Name = "btn_borrador";
            btn_borrador.Size = new Size(74, 79);
            btn_borrador.TabIndex = 6;
            btn_borrador.Text = "Borrador ";
            btn_borrador.TextAlign = ContentAlignment.BottomCenter;
            btn_borrador.UseVisualStyleBackColor = false;
            btn_borrador.Click += btn_borrador_Click;
            // 
            // btn_Linea
            // 
            btn_Linea.BackColor = SystemColors.Window;
            btn_Linea.Cursor = Cursors.Hand;
            btn_Linea.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn_Linea.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_Linea.FlatStyle = FlatStyle.Flat;
            btn_Linea.Image = (Image)resources.GetObject("btn_Linea.Image");
            btn_Linea.ImageAlign = ContentAlignment.TopCenter;
            btn_Linea.Location = new Point(503, 9);
            btn_Linea.Name = "btn_Linea";
            btn_Linea.Size = new Size(82, 79);
            btn_Linea.TabIndex = 9;
            btn_Linea.Text = "Linea ";
            btn_Linea.TextAlign = ContentAlignment.BottomCenter;
            btn_Linea.UseVisualStyleBackColor = false;
            btn_Linea.Click += btn_Linea_Click;
            // 
            // btn_pincel
            // 
            btn_pincel.BackColor = SystemColors.Window;
            btn_pincel.Cursor = Cursors.Hand;
            btn_pincel.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn_pincel.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_pincel.FlatStyle = FlatStyle.Flat;
            btn_pincel.Image = (Image)resources.GetObject("btn_pincel.Image");
            btn_pincel.Location = new Point(177, 9);
            btn_pincel.Name = "btn_pincel";
            btn_pincel.Size = new Size(74, 79);
            btn_pincel.TabIndex = 5;
            btn_pincel.Text = "Pincel";
            btn_pincel.TextAlign = ContentAlignment.BottomCenter;
            btn_pincel.UseVisualStyleBackColor = false;
            btn_pincel.Click += button1_Click;
            // 
            // btn_rectangulo
            // 
            btn_rectangulo.BackColor = SystemColors.Window;
            btn_rectangulo.Cursor = Cursors.Hand;
            btn_rectangulo.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn_rectangulo.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_rectangulo.FlatStyle = FlatStyle.Flat;
            btn_rectangulo.Image = (Image)resources.GetObject("btn_rectangulo.Image");
            btn_rectangulo.ImageAlign = ContentAlignment.TopCenter;
            btn_rectangulo.Location = new Point(415, 9);
            btn_rectangulo.Name = "btn_rectangulo";
            btn_rectangulo.Size = new Size(82, 79);
            btn_rectangulo.TabIndex = 8;
            btn_rectangulo.Text = "Rectangulo";
            btn_rectangulo.TextAlign = ContentAlignment.BottomCenter;
            btn_rectangulo.UseVisualStyleBackColor = false;
            btn_rectangulo.Click += btn_rectangulo_Click;
            // 
            // btn_color
            // 
            btn_color.BackColor = SystemColors.Window;
            btn_color.Cursor = Cursors.Hand;
            btn_color.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn_color.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.Image = (Image)resources.GetObject("btn_color.Image");
            btn_color.Location = new Point(18, 9);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(72, 79);
            btn_color.TabIndex = 3;
            btn_color.Text = "Color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = false;
            btn_color.Click += btn_color_Click;
            // 
            // btn_elipce
            // 
            btn_elipce.BackColor = SystemColors.Window;
            btn_elipce.Cursor = Cursors.Hand;
            btn_elipce.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn_elipce.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_elipce.FlatStyle = FlatStyle.Flat;
            btn_elipce.Image = (Image)resources.GetObject("btn_elipce.Image");
            btn_elipce.ImageAlign = ContentAlignment.TopCenter;
            btn_elipce.Location = new Point(337, 9);
            btn_elipce.Name = "btn_elipce";
            btn_elipce.Size = new Size(72, 79);
            btn_elipce.TabIndex = 7;
            btn_elipce.Text = "Circulo";
            btn_elipce.TextAlign = ContentAlignment.BottomCenter;
            btn_elipce.UseVisualStyleBackColor = false;
            btn_elipce.Click += btn_elipce_Click;
            // 
            // btn_fill
            // 
            btn_fill.BackColor = SystemColors.Window;
            btn_fill.Cursor = Cursors.Hand;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn_fill.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.Image = (Image)resources.GetObject("btn_fill.Image");
            btn_fill.Location = new Point(96, 9);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(75, 79);
            btn_fill.TabIndex = 4;
            btn_fill.Text = "Rellenar ";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = false;
            btn_fill.Click += btn_fill_Click;
            // 
            // pic
            // 
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(954, 661);
            pic.TabIndex = 1;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 661);
            Controls.Add(panel1);
            Controls.Add(pic);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Color_box).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_color;
        private Button pic_color;
        private PictureBox Color_box;
        private Button btn_Linea;
        private Button btn_rectangulo;
        private Button btn_elipce;
        private Panel panel3;
        private Button btn_borrador;
        private Button btn_pincel;
        private Button btn_fill;
        private Button btn_limpiar;
        private Button button1;
        private Panel pic;
    }
}