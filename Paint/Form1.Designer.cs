namespace Paint
{
    partial class Form1
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
            this.background = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.Panel();
            this.ColorInUse = new System.Windows.Forms.Panel();
            this.ColorUse = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.white = new System.Windows.Forms.PictureBox();
            this.darkGray = new System.Windows.Forms.PictureBox();
            this.black = new System.Windows.Forms.PictureBox();
            this.gray = new System.Windows.Forms.PictureBox();
            this.lightGrey = new System.Windows.Forms.PictureBox();
            this.lightPink = new System.Windows.Forms.PictureBox();
            this.purple = new System.Windows.Forms.PictureBox();
            this.lightCyan = new System.Windows.Forms.PictureBox();
            this.lightGreen = new System.Windows.Forms.PictureBox();
            this.lightYellow = new System.Windows.Forms.PictureBox();
            this.lightOrange = new System.Windows.Forms.PictureBox();
            this.lightRed = new System.Windows.Forms.PictureBox();
            this.darkPink = new System.Windows.Forms.PictureBox();
            this.darkBlue = new System.Windows.Forms.PictureBox();
            this.darkCyan = new System.Windows.Forms.PictureBox();
            this.darkGreen = new System.Windows.Forms.PictureBox();
            this.shit = new System.Windows.Forms.PictureBox();
            this.brown = new System.Windows.Forms.PictureBox();
            this.darkRed = new System.Windows.Forms.PictureBox();
            this.pink = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.cyan = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.orange = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.background.SuspendLayout();
            this.ColorInUse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorUse)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.white)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightGrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightCyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkCyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.Controls.Add(this.canvas);
            this.background.Controls.Add(this.ColorInUse);
            this.background.Controls.Add(this.panel1);
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(855, 450);
            this.background.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas.Location = new System.Drawing.Point(44, 47);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(808, 400);
            this.canvas.TabIndex = 2;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // ColorInUse
            // 
            this.ColorInUse.BackColor = System.Drawing.Color.Silver;
            this.ColorInUse.Controls.Add(this.btn3);
            this.ColorInUse.Controls.Add(this.btn8);
            this.ColorInUse.Controls.Add(this.btn2);
            this.ColorInUse.Controls.Add(this.btn7);
            this.ColorInUse.Controls.Add(this.btn5);
            this.ColorInUse.Controls.Add(this.btn6);
            this.ColorInUse.Controls.Add(this.btn4);
            this.ColorInUse.Controls.Add(this.btn1);
            this.ColorInUse.Controls.Add(this.ColorUse);
            this.ColorInUse.Location = new System.Drawing.Point(0, 0);
            this.ColorInUse.Name = "ColorInUse";
            this.ColorInUse.Size = new System.Drawing.Size(43, 447);
            this.ColorInUse.TabIndex = 1;
            // 
            // ColorUse
            // 
            this.ColorUse.BackColor = System.Drawing.Color.Black;
            this.ColorUse.Location = new System.Drawing.Point(4, 3);
            this.ColorUse.Name = "ColorUse";
            this.ColorUse.Size = new System.Drawing.Size(36, 40);
            this.ColorUse.TabIndex = 1;
            this.ColorUse.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.white);
            this.panel1.Controls.Add(this.darkGray);
            this.panel1.Controls.Add(this.black);
            this.panel1.Controls.Add(this.gray);
            this.panel1.Controls.Add(this.lightGrey);
            this.panel1.Controls.Add(this.lightPink);
            this.panel1.Controls.Add(this.purple);
            this.panel1.Controls.Add(this.lightCyan);
            this.panel1.Controls.Add(this.lightGreen);
            this.panel1.Controls.Add(this.lightYellow);
            this.panel1.Controls.Add(this.lightOrange);
            this.panel1.Controls.Add(this.lightRed);
            this.panel1.Controls.Add(this.darkPink);
            this.panel1.Controls.Add(this.darkBlue);
            this.panel1.Controls.Add(this.darkCyan);
            this.panel1.Controls.Add(this.darkGreen);
            this.panel1.Controls.Add(this.shit);
            this.panel1.Controls.Add(this.brown);
            this.panel1.Controls.Add(this.darkRed);
            this.panel1.Controls.Add(this.pink);
            this.panel1.Controls.Add(this.blue);
            this.panel1.Controls.Add(this.cyan);
            this.panel1.Controls.Add(this.green);
            this.panel1.Controls.Add(this.yellow);
            this.panel1.Controls.Add(this.orange);
            this.panel1.Controls.Add(this.red);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(44, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 46);
            this.panel1.TabIndex = 0;
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(656, 9);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(25, 26);
            this.white.TabIndex = 1;
            this.white.TabStop = false;
            this.white.Click += new System.EventHandler(this.black_Click);
            // 
            // darkGray
            // 
            this.darkGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.darkGray.Location = new System.Drawing.Point(749, 9);
            this.darkGray.Name = "darkGray";
            this.darkGray.Size = new System.Drawing.Size(25, 26);
            this.darkGray.TabIndex = 1;
            this.darkGray.TabStop = false;
            this.darkGray.Click += new System.EventHandler(this.black_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(780, 9);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(25, 26);
            this.black.TabIndex = 1;
            this.black.TabStop = false;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // gray
            // 
            this.gray.BackColor = System.Drawing.Color.Gray;
            this.gray.Location = new System.Drawing.Point(718, 9);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(25, 26);
            this.gray.TabIndex = 1;
            this.gray.TabStop = false;
            this.gray.Click += new System.EventHandler(this.black_Click);
            // 
            // lightGrey
            // 
            this.lightGrey.BackColor = System.Drawing.Color.Silver;
            this.lightGrey.Location = new System.Drawing.Point(687, 9);
            this.lightGrey.Name = "lightGrey";
            this.lightGrey.Size = new System.Drawing.Size(25, 26);
            this.lightGrey.TabIndex = 1;
            this.lightGrey.TabStop = false;
            this.lightGrey.Click += new System.EventHandler(this.black_Click);
            // 
            // lightPink
            // 
            this.lightPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lightPink.Location = new System.Drawing.Point(625, 9);
            this.lightPink.Name = "lightPink";
            this.lightPink.Size = new System.Drawing.Size(25, 26);
            this.lightPink.TabIndex = 1;
            this.lightPink.TabStop = false;
            this.lightPink.Click += new System.EventHandler(this.black_Click);
            // 
            // purple
            // 
            this.purple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.purple.Location = new System.Drawing.Point(594, 9);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(25, 26);
            this.purple.TabIndex = 1;
            this.purple.TabStop = false;
            this.purple.Click += new System.EventHandler(this.black_Click);
            // 
            // lightCyan
            // 
            this.lightCyan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lightCyan.Location = new System.Drawing.Point(563, 9);
            this.lightCyan.Name = "lightCyan";
            this.lightCyan.Size = new System.Drawing.Size(25, 26);
            this.lightCyan.TabIndex = 1;
            this.lightCyan.TabStop = false;
            this.lightCyan.Click += new System.EventHandler(this.black_Click);
            // 
            // lightGreen
            // 
            this.lightGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lightGreen.Location = new System.Drawing.Point(532, 9);
            this.lightGreen.Name = "lightGreen";
            this.lightGreen.Size = new System.Drawing.Size(25, 26);
            this.lightGreen.TabIndex = 1;
            this.lightGreen.TabStop = false;
            this.lightGreen.Click += new System.EventHandler(this.black_Click);
            // 
            // lightYellow
            // 
            this.lightYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lightYellow.Location = new System.Drawing.Point(501, 9);
            this.lightYellow.Name = "lightYellow";
            this.lightYellow.Size = new System.Drawing.Size(25, 26);
            this.lightYellow.TabIndex = 1;
            this.lightYellow.TabStop = false;
            this.lightYellow.Click += new System.EventHandler(this.black_Click);
            // 
            // lightOrange
            // 
            this.lightOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lightOrange.Location = new System.Drawing.Point(470, 9);
            this.lightOrange.Name = "lightOrange";
            this.lightOrange.Size = new System.Drawing.Size(25, 26);
            this.lightOrange.TabIndex = 1;
            this.lightOrange.TabStop = false;
            this.lightOrange.Click += new System.EventHandler(this.black_Click);
            // 
            // lightRed
            // 
            this.lightRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lightRed.Location = new System.Drawing.Point(439, 9);
            this.lightRed.Name = "lightRed";
            this.lightRed.Size = new System.Drawing.Size(25, 26);
            this.lightRed.TabIndex = 1;
            this.lightRed.TabStop = false;
            this.lightRed.Click += new System.EventHandler(this.black_Click);
            // 
            // darkPink
            // 
            this.darkPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.darkPink.Location = new System.Drawing.Point(408, 9);
            this.darkPink.Name = "darkPink";
            this.darkPink.Size = new System.Drawing.Size(25, 26);
            this.darkPink.TabIndex = 1;
            this.darkPink.TabStop = false;
            this.darkPink.Click += new System.EventHandler(this.black_Click);
            // 
            // darkBlue
            // 
            this.darkBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.darkBlue.Location = new System.Drawing.Point(377, 9);
            this.darkBlue.Name = "darkBlue";
            this.darkBlue.Size = new System.Drawing.Size(25, 26);
            this.darkBlue.TabIndex = 1;
            this.darkBlue.TabStop = false;
            this.darkBlue.Click += new System.EventHandler(this.black_Click);
            // 
            // darkCyan
            // 
            this.darkCyan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.darkCyan.Location = new System.Drawing.Point(346, 9);
            this.darkCyan.Name = "darkCyan";
            this.darkCyan.Size = new System.Drawing.Size(25, 26);
            this.darkCyan.TabIndex = 1;
            this.darkCyan.TabStop = false;
            this.darkCyan.Click += new System.EventHandler(this.black_Click);
            // 
            // darkGreen
            // 
            this.darkGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.darkGreen.Location = new System.Drawing.Point(315, 9);
            this.darkGreen.Name = "darkGreen";
            this.darkGreen.Size = new System.Drawing.Size(25, 26);
            this.darkGreen.TabIndex = 1;
            this.darkGreen.TabStop = false;
            this.darkGreen.Click += new System.EventHandler(this.black_Click);
            // 
            // shit
            // 
            this.shit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.shit.Location = new System.Drawing.Point(284, 9);
            this.shit.Name = "shit";
            this.shit.Size = new System.Drawing.Size(25, 26);
            this.shit.TabIndex = 1;
            this.shit.TabStop = false;
            this.shit.Click += new System.EventHandler(this.black_Click);
            // 
            // brown
            // 
            this.brown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.brown.Location = new System.Drawing.Point(253, 9);
            this.brown.Name = "brown";
            this.brown.Size = new System.Drawing.Size(25, 26);
            this.brown.TabIndex = 1;
            this.brown.TabStop = false;
            this.brown.Click += new System.EventHandler(this.black_Click);
            // 
            // darkRed
            // 
            this.darkRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.darkRed.Location = new System.Drawing.Point(222, 9);
            this.darkRed.Name = "darkRed";
            this.darkRed.Size = new System.Drawing.Size(25, 26);
            this.darkRed.TabIndex = 1;
            this.darkRed.TabStop = false;
            this.darkRed.Click += new System.EventHandler(this.black_Click);
            // 
            // pink
            // 
            this.pink.BackColor = System.Drawing.Color.Fuchsia;
            this.pink.Location = new System.Drawing.Point(191, 9);
            this.pink.Name = "pink";
            this.pink.Size = new System.Drawing.Size(25, 26);
            this.pink.TabIndex = 1;
            this.pink.TabStop = false;
            this.pink.Click += new System.EventHandler(this.black_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Location = new System.Drawing.Point(160, 9);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(25, 26);
            this.blue.TabIndex = 1;
            this.blue.TabStop = false;
            this.blue.Click += new System.EventHandler(this.black_Click);
            // 
            // cyan
            // 
            this.cyan.BackColor = System.Drawing.Color.Cyan;
            this.cyan.Location = new System.Drawing.Point(129, 9);
            this.cyan.Name = "cyan";
            this.cyan.Size = new System.Drawing.Size(25, 26);
            this.cyan.TabIndex = 1;
            this.cyan.TabStop = false;
            this.cyan.Click += new System.EventHandler(this.black_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Lime;
            this.green.Location = new System.Drawing.Point(98, 9);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(25, 26);
            this.green.TabIndex = 1;
            this.green.TabStop = false;
            this.green.Click += new System.EventHandler(this.black_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(67, 9);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(25, 26);
            this.yellow.TabIndex = 1;
            this.yellow.TabStop = false;
            this.yellow.Click += new System.EventHandler(this.black_Click);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orange.Location = new System.Drawing.Point(36, 9);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(25, 26);
            this.orange.TabIndex = 1;
            this.orange.TabStop = false;
            this.orange.Click += new System.EventHandler(this.black_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(5, 9);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(25, 26);
            this.red.TabIndex = 1;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.black_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderSize = 16;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(4, 49);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(36, 36);
            this.btn1.TabIndex = 2;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderSize = 15;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(4, 100);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(36, 36);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderSize = 14;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(4, 150);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(36, 36);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderSize = 12;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(4, 201);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(36, 36);
            this.btn4.TabIndex = 2;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderSize = 5;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(4, 408);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(36, 36);
            this.btn8.TabIndex = 2;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderSize = 6;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(4, 356);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(36, 36);
            this.btn7.TabIndex = 2;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderSize = 8;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(4, 305);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(36, 36);
            this.btn6.TabIndex = 2;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderSize = 10;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(4, 252);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(36, 36);
            this.btn5.TabIndex = 2;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Paint";
            this.background.ResumeLayout(false);
            this.ColorInUse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColorUse)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.white)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightGrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightCyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkCyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox white;
        private System.Windows.Forms.PictureBox lightGrey;
        private System.Windows.Forms.PictureBox gray;
        private System.Windows.Forms.PictureBox darkGray;
        private System.Windows.Forms.PictureBox black;
        private System.Windows.Forms.PictureBox lightPink;
        private System.Windows.Forms.PictureBox purple;
        private System.Windows.Forms.PictureBox lightCyan;
        private System.Windows.Forms.PictureBox lightGreen;
        private System.Windows.Forms.PictureBox lightYellow;
        private System.Windows.Forms.PictureBox lightOrange;
        private System.Windows.Forms.PictureBox lightRed;
        private System.Windows.Forms.PictureBox darkPink;
        private System.Windows.Forms.PictureBox darkBlue;
        private System.Windows.Forms.PictureBox darkCyan;
        private System.Windows.Forms.PictureBox darkGreen;
        private System.Windows.Forms.PictureBox shit;
        private System.Windows.Forms.PictureBox brown;
        private System.Windows.Forms.PictureBox darkRed;
        private System.Windows.Forms.PictureBox pink;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox cyan;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.PictureBox orange;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.Panel ColorInUse;
        private System.Windows.Forms.PictureBox ColorUse;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
    }
}

