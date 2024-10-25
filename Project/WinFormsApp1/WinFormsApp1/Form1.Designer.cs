namespace WinFormsApp1
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
            button1 = new Button();
            Vegetable = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            fruitText = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox3 = new TextBox();
            button10 = new Button();
            button11 = new Button();
            Vegetables = new Button();
            Spinch = new Button();
            kale_veg = new Button();
            Brocolli_veg = new Button();
            Pea_veg = new Button();
            Sweet_potato_Veg = new Button();
            vegetable_calculation = new TextBox();
            Meat_menu = new TextBox();
            Chicken_Button = new Button();
            Mutton_button = new Button();
            Beef_button = new Button();
            Turkey_button = new Button();
            Fish_button = new Button();
            Meat_section = new Button();
            Meat_calculation = new TextBox();
            Sweet_section = new Button();
            Sweet_menu = new TextBox();
            Cheese_button = new Button();
            Banana_pudding_Button = new Button();
            Brownies_button = new Button();
            Creme_Brulee_button = new Button();
            Gelato_button = new Button();
            Fruit_Tart_button = new Button();
            Sweet_calculation = new TextBox();
            Apple_background = new PictureBox();
            pictureBox1 = new PictureBox();
            Peach_Image = new PictureBox();
            Mango_image = new PictureBox();
            Cherry_image = new PictureBox();
            sweet_potato_pic = new PictureBox();
            Spinach_image = new PictureBox();
            Kale_image = new PictureBox();
            Brocoli_image = new PictureBox();
            Pea_image = new PictureBox();
            beef_image = new PictureBox();
            Mutton_image = new PictureBox();
            chicken_image = new PictureBox();
            Turkey_image = new PictureBox();
            fish_meat_image = new PictureBox();
            cheese_cake_image = new PictureBox();
            banana_pudding_image = new PictureBox();
            brownie_image = new PictureBox();
            creme_brulee_image = new PictureBox();
            gelato_image = new PictureBox();
            fruit_tart_image = new PictureBox();
            listView1 = new ListView();
            Item_Name = new ColumnHeader();
            Quantity = new ColumnHeader();
            Price = new ColumnHeader();
            clear_item = new Button();
            Discount_button = new Button();
            Total_bill_button = new Button();
            Recomended_button = new Button();
            Checking_out = new Button();
            label1 = new Label();
            Recommendation_no = new Button();
            ((System.ComponentModel.ISupportInitialize)Apple_background).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Peach_Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Mango_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cherry_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sweet_potato_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Spinach_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Kale_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Brocoli_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pea_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)beef_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Mutton_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chicken_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Turkey_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fish_meat_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cheese_cake_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)banana_pudding_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brownie_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)creme_brulee_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gelato_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fruit_tart_image).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(-1, 1);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Vegetable
            // 
            Vegetable.Location = new Point(0, 175);
            Vegetable.Multiline = true;
            Vegetable.Name = "Vegetable";
            Vegetable.Size = new Size(207, 92);
            Vegetable.TabIndex = 1;
            Vegetable.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(400, 1);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 124);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(770, 328);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "show cart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(624, 330);
            button3.Name = "button3";
            button3.Size = new Size(59, 23);
            button3.TabIndex = 4;
            button3.Text = "reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(0, 93);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Fruit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // fruitText
            // 
            fruitText.BackColor = SystemColors.ControlLight;
            fruitText.Location = new Point(-1, 175);
            fruitText.Multiline = true;
            fruitText.Name = "fruitText";
            fruitText.Size = new Size(210, 92);
            fruitText.TabIndex = 6;
            fruitText.TextChanged += fruitText_TextChanged;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.BottomCenter;
            button5.Location = new Point(-1, 273);
            button5.Name = "button5";
            button5.Size = new Size(43, 53);
            button5.TabIndex = 7;
            button5.Text = "1";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(39, 273);
            button6.Name = "button6";
            button6.Size = new Size(48, 53);
            button6.TabIndex = 8;
            button6.Text = "2";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.BottomCenter;
            button7.Location = new Point(83, 273);
            button7.Name = "button7";
            button7.Size = new Size(46, 53);
            button7.TabIndex = 9;
            button7.Text = "3";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(128, 273);
            button8.Name = "button8";
            button8.Size = new Size(50, 53);
            button8.TabIndex = 10;
            button8.Text = "4";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(176, 273);
            button9.Name = "button9";
            button9.Size = new Size(49, 53);
            button9.TabIndex = 11;
            button9.Text = "5";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonFace;
            textBox3.Location = new Point(231, 329);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 41);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button10
            // 
            button10.Location = new Point(285, 303);
            button10.Name = "button10";
            button10.Size = new Size(59, 23);
            button10.TabIndex = 13;
            button10.Text = "remove";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(231, 303);
            button11.Name = "button11";
            button11.Size = new Size(48, 23);
            button11.TabIndex = 14;
            button11.Text = "ADD";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Vegetables
            // 
            Vegetables.Location = new Point(-1, 133);
            Vegetables.Name = "Vegetables";
            Vegetables.Size = new Size(97, 27);
            Vegetables.TabIndex = 15;
            Vegetables.Text = "Vegetables";
            Vegetables.UseVisualStyleBackColor = true;
            Vegetables.Click += Vegetables_Click;
            // 
            // Spinch
            // 
            Spinch.Image = (Image)resources.GetObject("Spinch.Image");
            Spinch.Location = new Point(0, 276);
            Spinch.Name = "Spinch";
            Spinch.Size = new Size(42, 49);
            Spinch.TabIndex = 16;
            Spinch.Text = "1";
            Spinch.UseVisualStyleBackColor = true;
            Spinch.Click += Spinch_Click;
            // 
            // kale_veg
            // 
            kale_veg.Image = (Image)resources.GetObject("kale_veg.Image");
            kale_veg.Location = new Point(40, 278);
            kale_veg.Name = "kale_veg";
            kale_veg.Size = new Size(44, 47);
            kale_veg.TabIndex = 17;
            kale_veg.Text = "2";
            kale_veg.UseVisualStyleBackColor = true;
            kale_veg.Click += kale_veg_Click;
            // 
            // Brocolli_veg
            // 
            Brocolli_veg.Image = (Image)resources.GetObject("Brocolli_veg.Image");
            Brocolli_veg.Location = new Point(82, 273);
            Brocolli_veg.Name = "Brocolli_veg";
            Brocolli_veg.Size = new Size(46, 57);
            Brocolli_veg.TabIndex = 18;
            Brocolli_veg.Text = "3";
            Brocolli_veg.UseVisualStyleBackColor = true;
            Brocolli_veg.Click += Brocolli_veg_Click;
            // 
            // Pea_veg
            // 
            Pea_veg.Image = (Image)resources.GetObject("Pea_veg.Image");
            Pea_veg.Location = new Point(127, 275);
            Pea_veg.Name = "Pea_veg";
            Pea_veg.Size = new Size(51, 57);
            Pea_veg.TabIndex = 19;
            Pea_veg.Text = "4";
            Pea_veg.UseVisualStyleBackColor = true;
            Pea_veg.Click += Pea_veg_Click;
            // 
            // Sweet_potato_Veg
            // 
            Sweet_potato_Veg.Image = (Image)resources.GetObject("Sweet_potato_Veg.Image");
            Sweet_potato_Veg.Location = new Point(173, 275);
            Sweet_potato_Veg.Name = "Sweet_potato_Veg";
            Sweet_potato_Veg.Size = new Size(49, 57);
            Sweet_potato_Veg.TabIndex = 20;
            Sweet_potato_Veg.Text = "5";
            Sweet_potato_Veg.UseVisualStyleBackColor = true;
            Sweet_potato_Veg.Click += Sweet_potato_Veg_Click;
            // 
            // vegetable_calculation
            // 
            vegetable_calculation.Location = new Point(231, 331);
            vegetable_calculation.Multiline = true;
            vegetable_calculation.Name = "vegetable_calculation";
            vegetable_calculation.Size = new Size(100, 41);
            vegetable_calculation.TabIndex = 21;
            vegetable_calculation.TextChanged += vegetable_calculation_TextChanged;
            // 
            // Meat_menu
            // 
            Meat_menu.Location = new Point(0, 175);
            Meat_menu.Multiline = true;
            Meat_menu.Name = "Meat_menu";
            Meat_menu.Size = new Size(213, 92);
            Meat_menu.TabIndex = 22;
            Meat_menu.TextChanged += Meat_menu_TextChanged;
            // 
            // Chicken_Button
            // 
            Chicken_Button.Image = (Image)resources.GetObject("Chicken_Button.Image");
            Chicken_Button.Location = new Point(-2, 275);
            Chicken_Button.Name = "Chicken_Button";
            Chicken_Button.Size = new Size(44, 49);
            Chicken_Button.TabIndex = 23;
            Chicken_Button.Text = "1";
            Chicken_Button.UseVisualStyleBackColor = true;
            Chicken_Button.Click += Chicken_Button_Click;
            // 
            // Mutton_button
            // 
            Mutton_button.Image = (Image)resources.GetObject("Mutton_button.Image");
            Mutton_button.Location = new Point(42, 275);
            Mutton_button.Name = "Mutton_button";
            Mutton_button.Size = new Size(41, 49);
            Mutton_button.TabIndex = 24;
            Mutton_button.Text = "2";
            Mutton_button.UseVisualStyleBackColor = true;
            Mutton_button.Click += Mutton_button_Click;
            // 
            // Beef_button
            // 
            Beef_button.Image = (Image)resources.GetObject("Beef_button.Image");
            Beef_button.Location = new Point(83, 273);
            Beef_button.Name = "Beef_button";
            Beef_button.Size = new Size(42, 53);
            Beef_button.TabIndex = 25;
            Beef_button.Text = "3";
            Beef_button.UseVisualStyleBackColor = true;
            Beef_button.Click += Beef_button_Click;
            // 
            // Turkey_button
            // 
            Turkey_button.Image = (Image)resources.GetObject("Turkey_button.Image");
            Turkey_button.Location = new Point(127, 273);
            Turkey_button.Name = "Turkey_button";
            Turkey_button.Size = new Size(49, 49);
            Turkey_button.TabIndex = 26;
            Turkey_button.Text = "4";
            Turkey_button.UseVisualStyleBackColor = true;
            Turkey_button.Click += Turkey_button_Click;
            // 
            // Fish_button
            // 
            Fish_button.Image = (Image)resources.GetObject("Fish_button.Image");
            Fish_button.Location = new Point(178, 275);
            Fish_button.Name = "Fish_button";
            Fish_button.Size = new Size(47, 47);
            Fish_button.TabIndex = 27;
            Fish_button.Text = "5";
            Fish_button.UseVisualStyleBackColor = true;
            Fish_button.Click += Fish_button_Click;
            // 
            // Meat_section
            // 
            Meat_section.Location = new Point(-1, 113);
            Meat_section.Name = "Meat_section";
            Meat_section.Size = new Size(75, 23);
            Meat_section.TabIndex = 28;
            Meat_section.Text = "Meat_";
            Meat_section.UseVisualStyleBackColor = true;
            Meat_section.Click += Meat_section_Click;
            // 
            // Meat_calculation
            // 
            Meat_calculation.Location = new Point(231, 331);
            Meat_calculation.Multiline = true;
            Meat_calculation.Name = "Meat_calculation";
            Meat_calculation.Size = new Size(100, 41);
            Meat_calculation.TabIndex = 29;
            Meat_calculation.TextChanged += Meat_calculation_TextChanged;
            // 
            // Sweet_section
            // 
            Sweet_section.Location = new Point(0, 73);
            Sweet_section.Name = "Sweet_section";
            Sweet_section.Size = new Size(75, 23);
            Sweet_section.TabIndex = 30;
            Sweet_section.Text = "Sweet";
            Sweet_section.UseVisualStyleBackColor = true;
            Sweet_section.Click += Sweet_section_Click;
            // 
            // Sweet_menu
            // 
            Sweet_menu.Location = new Point(-2, 166);
            Sweet_menu.Multiline = true;
            Sweet_menu.Name = "Sweet_menu";
            Sweet_menu.Size = new Size(215, 106);
            Sweet_menu.TabIndex = 31;
            Sweet_menu.TextChanged += Sweet_menu_TextChanged;
            // 
            // Cheese_button
            // 
            Cheese_button.Image = (Image)resources.GetObject("Cheese_button.Image");
            Cheese_button.Location = new Point(-1, 275);
            Cheese_button.Name = "Cheese_button";
            Cheese_button.Size = new Size(43, 49);
            Cheese_button.TabIndex = 32;
            Cheese_button.Text = "1";
            Cheese_button.UseVisualStyleBackColor = true;
            Cheese_button.Click += Cheese_button_Click;
            // 
            // Banana_pudding_Button
            // 
            Banana_pudding_Button.Image = (Image)resources.GetObject("Banana_pudding_Button.Image");
            Banana_pudding_Button.Location = new Point(40, 273);
            Banana_pudding_Button.Name = "Banana_pudding_Button";
            Banana_pudding_Button.Size = new Size(43, 53);
            Banana_pudding_Button.TabIndex = 33;
            Banana_pudding_Button.Text = "2";
            Banana_pudding_Button.UseVisualStyleBackColor = true;
            Banana_pudding_Button.Click += Banana_pudding_Button_Click;
            // 
            // Brownies_button
            // 
            Brownies_button.Image = (Image)resources.GetObject("Brownies_button.Image");
            Brownies_button.Location = new Point(82, 275);
            Brownies_button.Name = "Brownies_button";
            Brownies_button.Size = new Size(43, 51);
            Brownies_button.TabIndex = 34;
            Brownies_button.Text = "3";
            Brownies_button.UseVisualStyleBackColor = true;
            Brownies_button.Click += Brownies_button_Click;
            // 
            // Creme_Brulee_button
            // 
            Creme_Brulee_button.Image = (Image)resources.GetObject("Creme_Brulee_button.Image");
            Creme_Brulee_button.Location = new Point(127, 275);
            Creme_Brulee_button.Name = "Creme_Brulee_button";
            Creme_Brulee_button.Size = new Size(49, 53);
            Creme_Brulee_button.TabIndex = 35;
            Creme_Brulee_button.Text = "4";
            Creme_Brulee_button.UseVisualStyleBackColor = true;
            Creme_Brulee_button.Click += Creme_Brulee_button_Click;
            // 
            // Gelato_button
            // 
            Gelato_button.Image = (Image)resources.GetObject("Gelato_button.Image");
            Gelato_button.Location = new Point(176, 277);
            Gelato_button.Name = "Gelato_button";
            Gelato_button.Size = new Size(46, 51);
            Gelato_button.TabIndex = 36;
            Gelato_button.Text = "5";
            Gelato_button.UseVisualStyleBackColor = true;
            Gelato_button.Click += Gelato_button_Click;
            // 
            // Fruit_Tart_button
            // 
            Fruit_Tart_button.Image = (Image)resources.GetObject("Fruit_Tart_button.Image");
            Fruit_Tart_button.Location = new Point(-2, 323);
            Fruit_Tart_button.Name = "Fruit_Tart_button";
            Fruit_Tart_button.Size = new Size(44, 57);
            Fruit_Tart_button.TabIndex = 37;
            Fruit_Tart_button.Text = "6";
            Fruit_Tart_button.UseVisualStyleBackColor = true;
            Fruit_Tart_button.Click += Fruit_Tart_button_Click;
            // 
            // Sweet_calculation
            // 
            Sweet_calculation.Location = new Point(231, 329);
            Sweet_calculation.Multiline = true;
            Sweet_calculation.Name = "Sweet_calculation";
            Sweet_calculation.Size = new Size(100, 43);
            Sweet_calculation.TabIndex = 38;
            Sweet_calculation.TextChanged += Sweet_calculation_TextChanged;
            // 
            // Apple_background
            // 
            Apple_background.Image = (Image)resources.GetObject("Apple_background.Image");
            Apple_background.Location = new Point(741, 12);
            Apple_background.Name = "Apple_background";
            Apple_background.Size = new Size(100, 50);
            Apple_background.SizeMode = PictureBoxSizeMode.StretchImage;
            Apple_background.TabIndex = 39;
            Apple_background.TabStop = false;
            Apple_background.Click += Apple_background_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(745, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Peach_Image
            // 
            Peach_Image.Image = (Image)resources.GetObject("Peach_Image.Image");
            Peach_Image.Location = new Point(741, 12);
            Peach_Image.Name = "Peach_Image";
            Peach_Image.Size = new Size(100, 50);
            Peach_Image.TabIndex = 41;
            Peach_Image.TabStop = false;
            // 
            // Mango_image
            // 
            Mango_image.Image = (Image)resources.GetObject("Mango_image.Image");
            Mango_image.Location = new Point(745, 12);
            Mango_image.Name = "Mango_image";
            Mango_image.Size = new Size(100, 50);
            Mango_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Mango_image.TabIndex = 42;
            Mango_image.TabStop = false;
            Mango_image.Click += Mango_image_Click;
            // 
            // Cherry_image
            // 
            Cherry_image.Image = (Image)resources.GetObject("Cherry_image.Image");
            Cherry_image.Location = new Point(745, 12);
            Cherry_image.Name = "Cherry_image";
            Cherry_image.Size = new Size(100, 50);
            Cherry_image.TabIndex = 43;
            Cherry_image.TabStop = false;
            // 
            // sweet_potato_pic
            // 
            sweet_potato_pic.Image = (Image)resources.GetObject("sweet_potato_pic.Image");
            sweet_potato_pic.Location = new Point(745, 12);
            sweet_potato_pic.Name = "sweet_potato_pic";
            sweet_potato_pic.Size = new Size(100, 50);
            sweet_potato_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            sweet_potato_pic.TabIndex = 44;
            sweet_potato_pic.TabStop = false;
            sweet_potato_pic.Click += sweet_potato_pic_Click;
            // 
            // Spinach_image
            // 
            Spinach_image.Image = (Image)resources.GetObject("Spinach_image.Image");
            Spinach_image.Location = new Point(741, 12);
            Spinach_image.Name = "Spinach_image";
            Spinach_image.Size = new Size(100, 50);
            Spinach_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Spinach_image.TabIndex = 45;
            Spinach_image.TabStop = false;
            // 
            // Kale_image
            // 
            Kale_image.Image = (Image)resources.GetObject("Kale_image.Image");
            Kale_image.Location = new Point(745, 12);
            Kale_image.Name = "Kale_image";
            Kale_image.Size = new Size(100, 50);
            Kale_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Kale_image.TabIndex = 46;
            Kale_image.TabStop = false;
            // 
            // Brocoli_image
            // 
            Brocoli_image.Image = (Image)resources.GetObject("Brocoli_image.Image");
            Brocoli_image.Location = new Point(741, 12);
            Brocoli_image.Name = "Brocoli_image";
            Brocoli_image.Size = new Size(100, 50);
            Brocoli_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Brocoli_image.TabIndex = 47;
            Brocoli_image.TabStop = false;
            // 
            // Pea_image
            // 
            Pea_image.Image = (Image)resources.GetObject("Pea_image.Image");
            Pea_image.Location = new Point(741, 16);
            Pea_image.Name = "Pea_image";
            Pea_image.Size = new Size(100, 50);
            Pea_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Pea_image.TabIndex = 48;
            Pea_image.TabStop = false;
            // 
            // beef_image
            // 
            beef_image.Image = (Image)resources.GetObject("beef_image.Image");
            beef_image.Location = new Point(741, 12);
            beef_image.Name = "beef_image";
            beef_image.Size = new Size(100, 50);
            beef_image.SizeMode = PictureBoxSizeMode.StretchImage;
            beef_image.TabIndex = 49;
            beef_image.TabStop = false;
            // 
            // Mutton_image
            // 
            Mutton_image.Image = (Image)resources.GetObject("Mutton_image.Image");
            Mutton_image.Location = new Point(745, 12);
            Mutton_image.Name = "Mutton_image";
            Mutton_image.Size = new Size(100, 50);
            Mutton_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Mutton_image.TabIndex = 50;
            Mutton_image.TabStop = false;
            // 
            // chicken_image
            // 
            chicken_image.Image = (Image)resources.GetObject("chicken_image.Image");
            chicken_image.Location = new Point(745, 12);
            chicken_image.Name = "chicken_image";
            chicken_image.Size = new Size(100, 50);
            chicken_image.SizeMode = PictureBoxSizeMode.StretchImage;
            chicken_image.TabIndex = 51;
            chicken_image.TabStop = false;
            // 
            // Turkey_image
            // 
            Turkey_image.Image = (Image)resources.GetObject("Turkey_image.Image");
            Turkey_image.Location = new Point(745, 12);
            Turkey_image.Name = "Turkey_image";
            Turkey_image.Size = new Size(100, 50);
            Turkey_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Turkey_image.TabIndex = 52;
            Turkey_image.TabStop = false;
            // 
            // fish_meat_image
            // 
            fish_meat_image.Image = (Image)resources.GetObject("fish_meat_image.Image");
            fish_meat_image.Location = new Point(741, 12);
            fish_meat_image.Name = "fish_meat_image";
            fish_meat_image.Size = new Size(100, 50);
            fish_meat_image.SizeMode = PictureBoxSizeMode.StretchImage;
            fish_meat_image.TabIndex = 53;
            fish_meat_image.TabStop = false;
            // 
            // cheese_cake_image
            // 
            cheese_cake_image.Image = (Image)resources.GetObject("cheese_cake_image.Image");
            cheese_cake_image.Location = new Point(745, 16);
            cheese_cake_image.Name = "cheese_cake_image";
            cheese_cake_image.Size = new Size(100, 50);
            cheese_cake_image.SizeMode = PictureBoxSizeMode.StretchImage;
            cheese_cake_image.TabIndex = 54;
            cheese_cake_image.TabStop = false;
            // 
            // banana_pudding_image
            // 
            banana_pudding_image.Image = (Image)resources.GetObject("banana_pudding_image.Image");
            banana_pudding_image.Location = new Point(741, 12);
            banana_pudding_image.Name = "banana_pudding_image";
            banana_pudding_image.Size = new Size(100, 50);
            banana_pudding_image.SizeMode = PictureBoxSizeMode.StretchImage;
            banana_pudding_image.TabIndex = 55;
            banana_pudding_image.TabStop = false;
            // 
            // brownie_image
            // 
            brownie_image.Image = (Image)resources.GetObject("brownie_image.Image");
            brownie_image.Location = new Point(741, 12);
            brownie_image.Name = "brownie_image";
            brownie_image.Size = new Size(100, 50);
            brownie_image.SizeMode = PictureBoxSizeMode.StretchImage;
            brownie_image.TabIndex = 56;
            brownie_image.TabStop = false;
            // 
            // creme_brulee_image
            // 
            creme_brulee_image.Image = (Image)resources.GetObject("creme_brulee_image.Image");
            creme_brulee_image.Location = new Point(741, 12);
            creme_brulee_image.Name = "creme_brulee_image";
            creme_brulee_image.Size = new Size(100, 50);
            creme_brulee_image.SizeMode = PictureBoxSizeMode.StretchImage;
            creme_brulee_image.TabIndex = 57;
            creme_brulee_image.TabStop = false;
            // 
            // gelato_image
            // 
            gelato_image.Image = (Image)resources.GetObject("gelato_image.Image");
            gelato_image.Location = new Point(741, 16);
            gelato_image.Name = "gelato_image";
            gelato_image.Size = new Size(100, 50);
            gelato_image.SizeMode = PictureBoxSizeMode.StretchImage;
            gelato_image.TabIndex = 58;
            gelato_image.TabStop = false;
            // 
            // fruit_tart_image
            // 
            fruit_tart_image.Image = (Image)resources.GetObject("fruit_tart_image.Image");
            fruit_tart_image.Location = new Point(741, 16);
            fruit_tart_image.Name = "fruit_tart_image";
            fruit_tart_image.Size = new Size(100, 50);
            fruit_tart_image.SizeMode = PictureBoxSizeMode.StretchImage;
            fruit_tart_image.TabIndex = 59;
            fruit_tart_image.TabStop = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Item_Name, Quantity, Price });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(612, 1);
            listView1.Name = "listView1";
            listView1.Size = new Size(242, 321);
            listView1.TabIndex = 60;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Item_Name
            // 
            Item_Name.Text = "Item_Name";
            Item_Name.Width = 80;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            // 
            // Price
            // 
            Price.Text = "Price";
            // 
            // clear_item
            // 
            clear_item.Location = new Point(689, 328);
            clear_item.Name = "clear_item";
            clear_item.Size = new Size(75, 23);
            clear_item.TabIndex = 62;
            clear_item.Text = "Clear_item";
            clear_item.UseVisualStyleBackColor = true;
            clear_item.Click += clear_item_Click;
            // 
            // Discount_button
            // 
            Discount_button.Location = new Point(319, 30);
            Discount_button.Name = "Discount_button";
            Discount_button.Size = new Size(75, 23);
            Discount_button.TabIndex = 63;
            Discount_button.Text = "Discount";
            Discount_button.UseVisualStyleBackColor = true;
            Discount_button.Click += Discount_button_Click;
            // 
            // Total_bill_button
            // 
            Total_bill_button.Location = new Point(319, 1);
            Total_bill_button.Name = "Total_bill_button";
            Total_bill_button.Size = new Size(75, 23);
            Total_bill_button.TabIndex = 64;
            Total_bill_button.Text = "Total_bill";
            Total_bill_button.UseVisualStyleBackColor = true;
            Total_bill_button.Click += Total_bill_button_Click;
            // 
            // Recomended_button
            // 
            Recomended_button.Location = new Point(109, 79);
            Recomended_button.Name = "Recomended_button";
            Recomended_button.Size = new Size(36, 23);
            Recomended_button.TabIndex = 65;
            Recomended_button.Text = "Yes";
            Recomended_button.UseVisualStyleBackColor = true;
            Recomended_button.Click += Recomended_button_Click;
            // 
            // Checking_out
            // 
            Checking_out.Location = new Point(321, 61);
            Checking_out.Name = "Checking_out";
            Checking_out.Size = new Size(75, 23);
            Checking_out.TabIndex = 66;
            Checking_out.Text = "Check_out";
            Checking_out.UseVisualStyleBackColor = true;
            Checking_out.Click += Checking_out_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 61);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 67;
            label1.Text = "Recommendation";
            // 
            // Recommendation_no
            // 
            Recommendation_no.Location = new Point(160, 79);
            Recommendation_no.Name = "Recommendation_no";
            Recommendation_no.Size = new Size(37, 23);
            Recommendation_no.TabIndex = 68;
            Recommendation_no.Text = "No";
            Recommendation_no.UseVisualStyleBackColor = true;
            Recommendation_no.Click += Recommendation_no_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(853, 398);
            Controls.Add(Recommendation_no);
            Controls.Add(label1);
            Controls.Add(Checking_out);
            Controls.Add(Recomended_button);
            Controls.Add(Total_bill_button);
            Controls.Add(Discount_button);
            Controls.Add(clear_item);
            Controls.Add(listView1);
            Controls.Add(fruit_tart_image);
            Controls.Add(gelato_image);
            Controls.Add(creme_brulee_image);
            Controls.Add(brownie_image);
            Controls.Add(banana_pudding_image);
            Controls.Add(cheese_cake_image);
            Controls.Add(fish_meat_image);
            Controls.Add(Turkey_image);
            Controls.Add(chicken_image);
            Controls.Add(Mutton_image);
            Controls.Add(beef_image);
            Controls.Add(Pea_image);
            Controls.Add(Brocoli_image);
            Controls.Add(Kale_image);
            Controls.Add(Spinach_image);
            Controls.Add(sweet_potato_pic);
            Controls.Add(Cherry_image);
            Controls.Add(Mango_image);
            Controls.Add(Peach_Image);
            Controls.Add(pictureBox1);
            Controls.Add(Apple_background);
            Controls.Add(Sweet_calculation);
            Controls.Add(Fruit_Tart_button);
            Controls.Add(Gelato_button);
            Controls.Add(Creme_Brulee_button);
            Controls.Add(Brownies_button);
            Controls.Add(Banana_pudding_Button);
            Controls.Add(Cheese_button);
            Controls.Add(Sweet_menu);
            Controls.Add(Sweet_section);
            Controls.Add(Meat_calculation);
            Controls.Add(Meat_section);
            Controls.Add(Fish_button);
            Controls.Add(Turkey_button);
            Controls.Add(Beef_button);
            Controls.Add(Mutton_button);
            Controls.Add(Chicken_Button);
            Controls.Add(Meat_menu);
            Controls.Add(vegetable_calculation);
            Controls.Add(Sweet_potato_Veg);
            Controls.Add(Pea_veg);
            Controls.Add(Brocolli_veg);
            Controls.Add(kale_veg);
            Controls.Add(Spinch);
            Controls.Add(Vegetables);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(textBox3);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(fruitText);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(Vegetable);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Apple_background).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Peach_Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)Mango_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cherry_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)sweet_potato_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)Spinach_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)Kale_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)Brocoli_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pea_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)beef_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)Mutton_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)chicken_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)Turkey_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)fish_meat_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)cheese_cake_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)banana_pudding_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)brownie_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)creme_brulee_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)gelato_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)fruit_tart_image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Vegetable;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox fruitText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBox3;
        private Button button10;
        private Button button11;
        private Button Vegetables;
        private Button Spinch;
        private Button kale_veg;
        private Button Brocolli_veg;
        private Button Pea_veg;
        private Button Sweet_potato_Veg;
        private TextBox vegetable_calculation;
        private TextBox Meat_menu;
        private Button Chicken_Button;
        private Button Mutton_button;
        private Button Beef_button;
        private Button Turkey_button;
        private Button Fish_button;
        private Button Meat_section;
        private TextBox Meat_calculation;
        private Button Sweet_section;
        private TextBox Sweet_menu;
        private Button Cheese_button;
        private Button Banana_pudding_Button;
        private Button Brownies_button;
        private Button Creme_Brulee_button;
        private Button Gelato_button;
        private Button Fruit_Tart_button;
        private TextBox Sweet_calculation;
        private PictureBox Apple_background;
        private PictureBox pictureBox1;
        private PictureBox Peach_Image;
        private PictureBox Mango_image;
        private PictureBox Cherry_image;
        private PictureBox sweet_potato_pic;
        private PictureBox Spinach_image;
        private PictureBox Kale_image;
        private PictureBox Brocoli_image;
        private PictureBox Pea_image;
        private PictureBox beef_image;
        private PictureBox Mutton_image;
        private PictureBox chicken_image;
        private PictureBox Turkey_image;
        private PictureBox fish_meat_image;
        private PictureBox cheese_cake_image;
        private PictureBox banana_pudding_image;
        private PictureBox brownie_image;
        private PictureBox creme_brulee_image;
        private PictureBox gelato_image;
        private PictureBox fruit_tart_image;
        private ListView listView1;
        private ColumnHeader Item_Name;
        private ColumnHeader Quantity;
        private ColumnHeader Price;
        private Button clear_item;
        private Button Discount_button;
        private Button Total_bill_button;
        private Button Recomended_button;
        private Button Checking_out;
        private Label label1;
        private Button Recommendation_no;
    }
}
