using System;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        int index = 0;
        bool reset = false; bool remove_item = false;
        int click = 0;
        bool recomended_item = false;
        /// <summary>
        /// Section Fruit
        /// </summary>
        int Price_mango = 50; int Quantity_mango = 0; bool mango = false; int Mango_bill = 0;
        int Price_orange = 45; int Quantity_orange = 0; bool orange = false; int Orange_bill = 0;
        int Price_peaches = 60; int Quantity_peaches = 0; bool peaches = false; int Peaches_bill = 0;
        int Price_apples = 40; int Quantity_apples = 0; bool apples = false; int Apples_bill = 0;
        int Price_cherry = 25; int Quantity_cherry = 0; bool cherry = false; int Cherry_bill = 0;
        int total_fruit_price = 0;
        bool add = false;
        bool show_cart = false;
        /// <summary>
        /// Section Vegetables
        /// </summary>

        int Price_spinach = 120; int Quantity_spinach = 0; bool spinach = false; int Spinach_bill = 0;
        int Price_kale = 90; int Quantity_kale = 0; bool kale = false; int Kale_bill = 0;
        int Price_brocolli = 130; int Quantity_brocolli = 0; bool brocolli = false; int Brocolli_bill = 0;
        int Price_peas = 140; int Quantity_peas = 0; bool peas = false; int Peas_bill = 0;
        int Price_sweet_potatos = 125; int Quantity_sweet_potatos = 0; bool sweet_potatos = false; int Sweet_Potatos_bill = 0;
        int total_Veg_price = 0;

        /// <summary>
        /// Section Meat
        /// </summary>
        int Price_chicken = 250; int Quantity_chicken = 0; bool chicken = false; int Chicken_bill = 0;
        int Price_beef = 350; int Quantity_beef = 0; bool beef = false; int Beef_bill = 0;
        int Price_mutton = 450; int Quantity_mutton = 0; bool mutton = false; int Mutton_bill = 0;
        int Price_turkey = 750; int Quantity_turkey = 0; bool turkey = false; int Turkey_bill = 0;
        int Price_fish = 250; int Quantity_fish = 0; bool fish = false; int Fish_bill = 0;
        int total_meat_price = 0;
        /// <summary>
        /// Section Sweets
        /// </summary>
        int Price_cheesecake = 200; int Quantity_cheesecake = 0; bool cheesecake = false; int Cheesecake_bill = 0;
        int Price_bananapudding = 100; int Quantity_bananapudding = 0; bool bananapudding = false; int Bananapudding_bill = 0;
        int Price_brownies = 300; int Quantity_brownies = 0; bool brownies = false; int Brownies_bill = 0;
        int Price_cremebrulee = 350; int Quantity_cremebrulee = 0; bool cremebrulee = false; int Cremebrulee_bill = 0;
        int Price_gelato = 400; int Quantity_gelato = 0; bool gelato = false; int Gelato_bill = 0;
        int Price_fruittart = 450; int Quantity_fruittart = 0; bool fruittart = false; int Fruittart_bill = 0;
        int total_sweet_price = 0;




        bool Clear_items = false;
        //Discounting and viewing Total bill

        bool discount = false;
        bool view_total_bill = false;
        double Total_amount_bill = 0;
        public Form1()
        {
            InitializeComponent();
            /*Section fruit button*/   /*section vegetable button*/     /*section Meat button*/
            fruitText.Visible = false; button4.Visible = false; Meat_calculation.Visible = false;
            button5.Visible = false; Vegetables.Visible = false; Chicken_Button.Visible = false;
            button6.Visible = false; Spinch.Visible = false; Beef_button.Visible = false;
            button7.Visible = false; kale_veg.Visible = false; Mutton_button.Visible = false;
            button8.Visible = false; Brocolli_veg.Visible = false; Turkey_button.Visible = false;
            button9.Visible = false; Pea_veg.Visible = false; Fish_button.Visible = false;
            button10.Visible = false; Sweet_potato_Veg.Visible = false; Meat_menu.Visible = false;
            button11.Visible = false; Meat_section.Visible = false;
            //textBox3.Visible = true;
            textBox3.Visible = false;
            Vegetable.Visible = false;   //Vegetable menu text box
            vegetable_calculation.Visible = false;  //calculating total veg bill


            //Sweet
            Sweet_section.Visible = false;
            Sweet_menu.Visible = false;
            Cheese_button.Visible = false;
            Banana_pudding_Button.Visible = false;
            Brownies_button.Visible = false;
            Creme_Brulee_button.Visible = false;
            Gelato_button.Visible = false;
            Sweet_calculation.Visible = false;
            Fruit_Tart_button.Visible = false;

            //Images 
            Mango_image.Visible = false;
            Peach_Image.Visible = false;
            pictureBox1.Visible = false;
            Apple_background.Visible = false;
            Cherry_image.Visible = false;
            sweet_potato_pic.Visible = false;
            Spinach_image.Visible = false;
            Kale_image.Visible = false;
            Brocoli_image.Visible = false;
            Pea_image.Visible = false;
            beef_image.Visible = false;
            Mutton_image.Visible = false;
            chicken_image.Visible = false;
            Turkey_image.Visible = false;
            fish_meat_image.Visible = false;
            cheese_cake_image.Visible = false;
            banana_pudding_image.Visible = false;
            brownie_image.Visible = false;
            creme_brulee_image.Visible = false;
            gelato_image.Visible = false;
            fruit_tart_image.Visible = false;

            //Viewing Cart through List box
            // this.listBox1 = new ListBox();
            //this.listBox1.Location = new System.Drawing.Point(12, 12);
            //this.listBox1.Size = new System.Drawing.Size(200, 150);
            // this.Controls.Add(this.listBox1);
            listView1.Visible = false;
            textBox2.Visible = false;
            Recomended_button.Visible = false;
            label1.Height = 55;
            label1.Width = 30;
            label1.Visible = false;
            Recommendation_no.Visible = false ;
        }

        private void Recomended_button_Click(object sender, EventArgs e)
        {
            recomended_item = true;
        }
        private void Recommendation_no_Click(object sender, EventArgs e)
        {
            recomended_item = false;
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            Vegetable.Text = "Press 1 for Spinach \r\nPress 2 for Kale\r\nPress 3 for Brocolli \r\nPress 4 for Peas \r\nPress 5 for Sweet Potatos \r\n ";
            Vegetable.Show();
            Spinch.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            kale_veg.Visible = true;
            Brocolli_veg.Visible = true;
            Pea_veg.Visible = true;
            Sweet_potato_Veg.Visible = true;

        }

        public void button3_Click(object sender, EventArgs e)   //reset button
        {
            listView1.Clear();
        }
        public void button1_Click(object sender, EventArgs e)  //its name is Menu
        {
            label1.Visible = true;
            Recommendation_no.Visible = true;
            button4.Visible = true;
            Vegetables.Visible = true;
            Meat_section.Visible = true;
            Sweet_section.Visible = true;
            Recomended_button.Visible = true;

        }
        public void button4_Click(object sender, EventArgs e)
        {
            fruitText.Visible = true;
            //Hide Veg
            Vegetable.Visible = false;
            Spinch.Visible = false;
            kale_veg.Visible = false;
            Brocolli_veg.Visible = false;
            Pea_veg.Visible = false;
            Sweet_potato_Veg.Visible = false;
            vegetable_calculation.Visible = false;  // to hide the vegetable  calculation box
            //Hide Meat
            Meat_menu.Visible = false;
            Chicken_Button.Visible = false;
            Mutton_button.Visible = false;
            Beef_button.Visible = false;
            Turkey_button.Visible = false;
            Fish_button.Visible = false;
            Meat_calculation.Visible = false;
            //Hide sweets
            Sweet_menu.Visible = false;
            Cheese_button.Visible = false;
            Banana_pudding_Button.Visible = false;
            Brownies_button.Visible = false;
            Creme_Brulee_button.Visible = false;
            Gelato_button.Visible = false;
            Sweet_calculation.Visible = false;
            Fruit_Tart_button.Visible = false;
            //setting bool of Veg to false so that they dont get added in cart when i am adding Veg in cart
            spinach = false;
            kale = false;
            brocolli = false;
            peas = false;
            sweet_potatos = false;
            //setting bool of Meat to false so that they dont get added in cart when i am adding Veg in cart
            chicken = false;
            mutton = false;
            beef = false;
            turkey = false;
            fish = false;
            //setting bool of sweets to false so that they dont get added in cart when i am adding Veg in cart
            cheesecake = false;
            bananapudding = false;
            brownies = false;
            cremebrulee = false;
            gelato = false;
            fruittart = false;
            if (recomended_item == true)
            {
                MessageBox.Show("Mango", "Recommended Item");
            }

        }

        public void fruitText_TextChanged(object sender, EventArgs e)
        {
            if (recomended_item == true)
            {
                MessageBox.Show("Mango", "Recommended Item");
            }
            fruitText.Text = "Press 1 for apples \r\nPress 2 for Oranges\r\nPress 3 for Mangos \r\nPress 4 for cherry \r\nPress 5 for Peaches \r\n ";

            fruitText.Show();
            textBox3.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;

        }
        public void button5_Click(object sender, EventArgs e)
        {
            //button6.Visible = false; 
            //button7.Visible = false;
            //button8.Visible = false;
            //button9.Visible = false;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            textBox3.Visible = true;
            apples = true;
            orange = false;
            mango = false;
            cherry = false;
            peaches = false;
            BackgroundImage = Apple_background.Image;
        }

        public void button6_Click(object sender, EventArgs e)
        {
            BackgroundImage = pictureBox1.Image;
            Mango_image.Visible = false;
            orange = true;
            mango = false;
            cherry = false;
            peaches = false;
            apples = false;
            textBox3.Visible = true;
            //button5.Visible = false;
            //button7.Visible = false;
            //button8.Visible = false;
            //button9.Visible = false;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
        }
        public void button7_Click(object sender, EventArgs e)
        {
            BackgroundImage = Mango_image.Image;

            orange = false;
            mango = true;
            cherry = false;
            peaches = false;
            apples = false;
            textBox3.Visible = true;
            //button5.Visible = false;
            //button6.Visible = false;
            //button8.Visible = false;
            //button9.Visible = false;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
        }
        public void button8_Click(object sender, EventArgs e)
        {
            BackgroundImage = Cherry_image.Image;
            orange = false;
            mango = false;
            cherry = true;
            peaches = false;
            apples = false;
            textBox3.Visible = true;
            //button5.Visible = false;
            //button6.Visible = false;
            //button7.Visible = false;
            //button8.Visible = true;
            //button9.Visible = false;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
        }
        public void button9_Click(object sender, EventArgs e)
        {
            BackgroundImage = Peach_Image.Image;
            orange = false;
            mango = false;
            cherry = false;
            peaches = true;
            apples = false;
            textBox3.Visible = true;
            //button5.Visible = false;
            //button6.Visible = false;
            //button7.Visible = false;
            //button8.Visible = false;
            //button9.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
        }


        public void textBox3_TextChanged(object sender, EventArgs e)
        {
            listView1.Visible = true;
            if (remove_item == false || add == true)
            {
                if (int.TryParse(textBox3.Text, out int number))  //for calculating apple charges
                {
                    int price = 0;
                    if (apples == true)
                    {
                        if (add == true) //click event
                        {
                            Quantity_apples += number;
                            price = Quantity_apples * Price_apples;
                            Apples_bill = price;
                        }

                    }
                    else if (mango == true)
                    {
                        if (add == true) //click event
                        {
                            Quantity_mango += number;
                            price = Quantity_mango * Price_mango;
                            Mango_bill = price;
                        }

                    }
                    else if (orange == true)
                    {
                        if (add == true) //click event
                        {
                            Quantity_orange += number;
                            price = Quantity_orange * Price_orange;
                            Orange_bill = price;
                        }

                    }
                    else if (cherry == true)
                    {
                        if (add == true) //click event
                        {
                            Quantity_cherry += number;
                            price = Quantity_cherry * Price_cherry;
                            Cherry_bill = price;
                        }

                    }
                    else if (peaches == true)
                    {
                        if (add == true) //click event
                        {
                            Quantity_peaches += number;
                            price = Quantity_peaches * Price_peaches;
                            Peaches_bill = price;
                        }
                    }

                    total_fruit_price = Orange_bill + Mango_bill + Apples_bill + Cherry_bill + Peaches_bill;

                }
                else
                {

                }
            }
            else
            {
                if (int.TryParse(textBox3.Text, out int R_Number))  //for calculating removing apple
                {

                    if (apples == true)
                    {
                        int Actual_remove_value = 0;
                        int cutting_value = 0; //yeh wo value jo total value ma sa nikal 
                        Actual_remove_value = R_Number * Price_apples;
                        if (R_Number > Quantity_apples)
                        {
                            R_Number = Quantity_apples;
                            cutting_value = R_Number * Price_apples;

                        }
                        else
                        {
                            cutting_value = R_Number * Price_apples;
                        }
                        Quantity_apples -= R_Number;
                        Apples_bill = Quantity_apples * Price_apples;
                        ////////////////////////////////////////////////////////
                        total_fruit_price = total_fruit_price - cutting_value;


                    }
                    else if (orange == true)
                    {
                        int Actual_remove_value = 0;
                        int cutting_value = 0; //yeh wo value jo total value ma sa nikal 
                        Actual_remove_value = R_Number * Price_orange;
                        if (R_Number > Quantity_orange)
                        {
                            R_Number = Quantity_orange;
                            cutting_value = R_Number * Price_orange;

                        }
                        else
                        {
                            cutting_value = R_Number * Price_orange;
                        }
                        Quantity_orange -= R_Number;
                        Orange_bill = Quantity_orange * Price_orange;
                        ////////////////////////////////////////////////////////
                        total_fruit_price = total_fruit_price - cutting_value;

                    }
                    else if (mango == true)
                    {

                        int Actual_remove_value = 0;
                        int cutting_value = 0; //yeh wo value jo total value ma sa nikal 
                        Actual_remove_value = R_Number * Price_mango;
                        if (R_Number > Quantity_mango)
                        {
                            R_Number = Quantity_mango;
                            cutting_value = R_Number * Price_mango;

                        }
                        else
                        {
                            cutting_value = R_Number * Price_mango;
                        }
                        Quantity_mango -= R_Number;
                        Mango_bill = Quantity_mango * Price_mango;
                        ////////////////////////////////////////////////////////
                        total_fruit_price = total_fruit_price - cutting_value;

                    }
                    else if (cherry == true)
                    {

                        int Actual_remove_value = 0;
                        int cutting_value = 0; //yeh wo value jo total value ma sa nikal 
                        Actual_remove_value = R_Number * Price_cherry;
                        if (R_Number > Quantity_cherry)
                        {
                            R_Number = Quantity_cherry;
                            cutting_value = R_Number * Price_cherry;

                        }
                        else
                        {
                            cutting_value = R_Number * Price_cherry;
                        }
                        Quantity_cherry -= R_Number;
                        Cherry_bill = Quantity_cherry * Price_cherry;
                        ////////////////////////////////////////////////////////
                        total_fruit_price = total_fruit_price - cutting_value;


                    }
                    else if (peaches == true)
                    {
                        int Actual_remove_value = 0;
                        int cutting_value = 0; //yeh wo value jo total value ma sa nikal 
                        Actual_remove_value = R_Number * Price_peaches;
                        if (R_Number > Quantity_peaches)
                        {
                            R_Number = Quantity_peaches;
                            cutting_value = R_Number * Price_peaches;

                        }
                        else
                        {
                            cutting_value = R_Number * Price_peaches;
                        }
                        Quantity_peaches -= R_Number;
                        Peaches_bill = Quantity_peaches * Price_peaches;
                        ////////////////////////////////////////////////////////
                        total_fruit_price = total_fruit_price - cutting_value;


                    }
                }
                else
                {

                }

            }
        }
        public void button10_Click(object sender, EventArgs e) //remove button
        {
            remove_item = true;
            add = false;
        }



        public void button11_Click(object sender, EventArgs e)   //my Add button
        {
            add = true;
            remove_item = false;
            // textBox3.Hide();
        }

        private void Vegetables_Click(object sender, EventArgs e)
        {
            if (recomended_item == true)
            {
                MessageBox.Show("Kale", "Recommended Item");
            }

            Vegetable.Visible = true;
            fruitText.Visible = false;
            vegetable_calculation.Visible = true;
            button11.Visible = true;
            button10.Visible = true;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            textBox3.Visible = false; //to hide the fruit calculation

            //Hide Meat
            Meat_menu.Visible = false;
            Chicken_Button.Visible = false;
            Mutton_button.Visible = false;
            Beef_button.Visible = false;
            Turkey_button.Visible = false;
            Fish_button.Visible = false;
            Meat_calculation.Visible = false;
            //Hide Sweets
            Sweet_menu.Visible = false;
            Cheese_button.Visible = false;
            Banana_pudding_Button.Visible = false;
            Brownies_button.Visible = false;
            Creme_Brulee_button.Visible = false;
            Gelato_button.Visible = false;
            Sweet_calculation.Visible = false;
            Fruit_Tart_button.Visible = false;

            //setting bool of Fruit to false so that they dont get added in cart when i am adding Veg in cart
            apples = false;
            orange = false;
            mango = false;
            cherry = false;
            peaches = false;
            //setting bool of Meat to false so that they dont get added in cart when i am adding Veg in cart
            chicken = false;
            mutton = false;
            beef = false;
            turkey = false;
            fish = false;
            //setting bool of sweets to false so that they dont get added in cart when i am adding Veg in cart
            cheesecake = false;
            bananapudding = false;
            brownies = false;
            cremebrulee = false;
            gelato = false;
            fruittart = false;
        }

        private void Spinch_Click(object sender, EventArgs e)
        {
            BackgroundImage = Spinach_image.Image;
            spinach = true;
            kale = false;
            brocolli = false;
            peas = false;
            sweet_potatos = false;
        }

        private void kale_veg_Click(object sender, EventArgs e)
        {
            BackgroundImage = Kale_image.Image;
            spinach = false;
            kale = true;
            brocolli = false;
            peas = false;
            sweet_potatos = false;
        }

        private void Brocolli_veg_Click(object sender, EventArgs e)
        {
            BackgroundImage = Brocoli_image.Image;
            spinach = false;
            kale = false;
            brocolli = true;
            peas = false;
            sweet_potatos = false;
        }

        private void Pea_veg_Click(object sender, EventArgs e)
        {
            BackgroundImage = Pea_image.Image;
            spinach = false;
            kale = false;
            brocolli = false;
            peas = true;
            sweet_potatos = false;
        }

        private void Sweet_potato_Veg_Click(object sender, EventArgs e)
        {
            BackgroundImage = sweet_potato_pic.Image;
            spinach = false;
            kale = false;
            brocolli = false;
            peas = false;
            sweet_potatos = true;

        }

        private void vegetable_calculation_TextChanged(object sender, EventArgs e)
        {
            if (remove_item == false || add == true)
            {
                if (int.TryParse(vegetable_calculation.Text, out int number))  //for calculating apple charges
                {
                    int price = 0;
                    if (spinach == true)
                    {
                        if (add == true) //click event
                        {
                            Quantity_spinach += number;
                            price = Quantity_spinach * Price_spinach;
                            Spinach_bill = price;

                        }

                    }
                    else if (kale == true)
                    {
                        if (add == true) //click event
                        {
                            Quantity_kale += number;
                            price = Quantity_kale * Price_kale;
                            Kale_bill = price;

                        }

                    }
                    else if (brocolli == true)
                    {
                        if (add == true) //click event
                        {
                            Quantity_brocolli += number;
                            price = Quantity_brocolli * Price_brocolli;
                            Brocolli_bill = price;

                        }

                    }
                    else if (peas == true)
                    {
                        if (add == true) //click event
                        {
                            Quantity_peas += number;
                            price = Quantity_peas * Price_peas;
                            Peas_bill = price;

                        }

                    }
                    else if (sweet_potatos == true)
                    {
                        if (add == true) //click event
                        {
                            Quantity_sweet_potatos += number;
                            price = Quantity_sweet_potatos * Price_sweet_potatos;
                            Sweet_Potatos_bill = price;

                        }
                    }

                    total_Veg_price = Spinach_bill + Kale_bill + Brocolli_bill + Peas_bill + Sweet_Potatos_bill;

                }
                else
                {

                }
            }
            else
            {
                if (int.TryParse(vegetable_calculation.Text, out int R_Number))  //for calculating removing apple
                {

                    if (spinach == true)
                    {
                        int Actual_remove_value = 0;
                        int cutting_value = 0; //yeh wo value jo total value ma sa nikal 
                        Actual_remove_value = R_Number * Price_spinach;
                        if (R_Number > Quantity_spinach)
                        {
                            R_Number = Quantity_spinach;
                            cutting_value = R_Number * Price_spinach;

                        }
                        else
                        {
                            cutting_value = R_Number * Price_spinach;
                        }
                        Quantity_spinach -= R_Number;
                        Spinach_bill = Quantity_spinach * Price_spinach;
                        ////////////////////////////////////////////////////////
                        total_Veg_price = total_Veg_price - cutting_value;


                    }
                    else if (kale == true)
                    {
                        int Actual_remove_value = 0;
                        int cutting_value = 0; //yeh wo value jo total value ma sa nikal 
                        Actual_remove_value = R_Number * Price_kale;
                        if (R_Number > Quantity_kale)
                        {
                            R_Number = Quantity_kale;
                            cutting_value = R_Number * Price_kale;

                        }
                        else
                        {
                            cutting_value = R_Number * Price_kale;
                        }
                        Quantity_kale -= R_Number;
                        Kale_bill = Quantity_kale * Price_kale;
                        ////////////////////////////////////////////////////////
                        total_Veg_price = total_Veg_price - cutting_value;


                    }
                    else if (brocolli == true)
                    {

                        int Actual_remove_value = 0;
                        int cutting_value = 0; //yeh wo value jo total value ma sa nikal 
                        Actual_remove_value = R_Number * Price_brocolli;
                        if (R_Number > Quantity_brocolli)
                        {
                            R_Number = Quantity_brocolli;
                            cutting_value = R_Number * Price_brocolli;

                        }
                        else
                        {
                            cutting_value = R_Number * Price_brocolli;
                        }
                        Quantity_brocolli -= R_Number;
                        Brocolli_bill = Quantity_brocolli * Price_brocolli;
                        ////////////////////////////////////////////////////////
                        total_Veg_price = total_Veg_price - cutting_value;



                    }
                    else if (peas == true)
                    {

                        int Actual_remove_value = 0;
                        int cutting_value = 0; //yeh wo value jo total value ma sa nikal 
                        Actual_remove_value = R_Number * Price_peas;
                        if (R_Number > Quantity_peas)
                        {
                            R_Number = Quantity_peas;
                            cutting_value = R_Number * Price_peas;

                        }
                        else
                        {
                            cutting_value = R_Number * Price_peas;
                        }
                        Quantity_peas -= R_Number;
                        Peas_bill = Quantity_peas * Price_peas;
                        ////////////////////////////////////////////////////////
                        total_Veg_price = total_Veg_price - cutting_value;

                    }
                    else if (sweet_potatos == true)
                    {
                        int Actual_remove_value = 0;
                        int cutting_value = 0; //yeh wo value jo total value ma sa nikal 
                        Actual_remove_value = R_Number * Price_sweet_potatos;
                        if (R_Number > Quantity_peaches)
                        {
                            R_Number = Quantity_peaches;
                            cutting_value = R_Number * Price_sweet_potatos;

                        }
                        else
                        {
                            cutting_value = R_Number * Price_sweet_potatos;
                        }
                        Quantity_sweet_potatos -= R_Number;
                        Sweet_Potatos_bill = Quantity_sweet_potatos * Price_sweet_potatos;
                        ////////////////////////////////////////////////////////
                        total_Veg_price = total_Veg_price - cutting_value;


                    }
                }
                else
                {

                }
            }
        }

        private void Meat_menu_TextChanged(object sender, EventArgs e)
        {
            Chicken_Button.Visible = true;
            Mutton_button.Visible = true;
            Beef_button.Visible = true;
            Turkey_button.Visible = true;
            Fish_button.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            Meat_menu.Text = "Press 1 for Chicken \r\nPress 2 for Mutton\r\nPress 3 for Beef  \r\nPress 4 for Turkey \r\nPress 5 for fish ";
            //further making it
        }

        private void Chicken_Button_Click(object sender, EventArgs e)
        {
            BackgroundImage = chicken_image.Image;
            chicken = true;
            mutton = false;
            beef = false;
            turkey = false;
            fish = false;
        }

        private void Mutton_button_Click(object sender, EventArgs e)
        {
            BackgroundImage = Mutton_image.Image;
            chicken = false;
            mutton = true;
            beef = false;
            turkey = false;
            fish = false;
        }

        private void Beef_button_Click(object sender, EventArgs e)
        {
            BackgroundImage = beef_image.Image;
            chicken = false;
            mutton = false;
            beef = true;
            turkey = false;
            fish = false;
        }

        private void Turkey_button_Click(object sender, EventArgs e)
        {
            BackgroundImage = Turkey_image.Image;
            chicken = false;
            mutton = false;
            beef = false;
            turkey = true;
            fish = false;
        }

        private void Fish_button_Click(object sender, EventArgs e)
        {
            BackgroundImage = fish_meat_image.Image;
            chicken = false;
            mutton = false;
            beef = false;
            turkey = false;
            fish = true;
        }

        private void Meat_section_Click(object sender, EventArgs e)
        {
            if (recomended_item == true)
            {
                MessageBox.Show("Mutton", "Recommended Item");
            }
            Meat_menu.Visible = true;
            //Chicken_Button.Visible = true;
            //Mutton_button.Visible = true;
            //Beef_button.Visible = true;
            //Turkey_button.Visible = true;
            //Fish_button.Visible = true;
            //button10.Visible = true;
            //button11.Visible = true;
            Meat_calculation.Visible = true;

            //Hide fruit
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            fruitText.Visible = false;
            textBox3.Visible = false; //to hide the fruit calculation

            //Hide Vegetables
            Vegetable.Visible = false;
            Spinch.Visible = false;
            kale_veg.Visible = false;
            Brocolli_veg.Visible = false;
            Pea_veg.Visible = false;
            Sweet_potato_Veg.Visible = false;
            vegetable_calculation.Visible = false;  // to hide the vegetable  calculation box

            //Hide sweets
            Sweet_menu.Visible = false;
            Cheese_button.Visible = false;
            Banana_pudding_Button.Visible = false;
            Brownies_button.Visible = false;
            Creme_Brulee_button.Visible = false;
            Gelato_button.Visible = false;
            Sweet_calculation.Visible = false;
            Fruit_Tart_button.Visible = false;


            //setting bool of Fruit to false so that they dont get added in cart when i am adding Veg in cart
            apples = false;
            orange = false;
            mango = false;
            cherry = false;
            peaches = false;

            //setting bool of sweets to false so that they dont get added in cart when i am adding Veg in cart
            cheesecake = false;
            bananapudding = false;
            brownies = false;
            cremebrulee = false;
            gelato = false;
            fruittart = false;

            //setting bool of Veg to false so that they dont get added in cart when i am adding Veg in cart
            spinach = false;
            kale = false;
            brocolli = false;
            peas = false;
            sweet_potatos = false;
        }

        private void Meat_calculation_TextChanged(object sender, EventArgs e)
        {
            if (remove_item == false || add == true)
            {
                if (int.TryParse(Meat_calculation.Text, out int number))
                {
                    int price_ = 0;
                    if (chicken == true)
                    {
                        if (add == true)
                        {
                            Quantity_chicken += number;
                            price_ = Quantity_chicken * Price_chicken;
                            Chicken_bill = price_;

                        }
                    }
                    else if (mutton == true)
                    {

                        if (add == true)
                        {
                            Quantity_mutton += number;
                            price_ = Quantity_mutton * Price_mutton;
                            Mutton_bill = price_;

                        }

                    }
                    else if (beef == true)
                    {

                        if (add == true)
                        {
                            Quantity_beef += number;
                            price_ = Quantity_beef * Price_beef;
                            Beef_bill = price_;

                        }

                    }
                    else if (turkey == true)
                    {

                        if (add == true)
                        {
                            Quantity_turkey += number;
                            price_ = Quantity_turkey * Price_turkey;
                            Turkey_bill = price_;

                        }

                    }
                    else if (fish == true)
                    {

                        if (add == true)
                        {
                            Quantity_fish += number;
                            price_ = Quantity_fish * Price_fish;
                            Fish_bill = price_;

                        }

                    }
                    total_meat_price = Chicken_bill + Beef_bill + Mutton_bill + Turkey_bill + Fish_bill;

                }
                else
                {

                }
            }
            else
            {
                if (int.TryParse(Meat_calculation.Text, out int r_Number))  //for calculating removing apple
                {

                    if (chicken == true)
                    {
                        int remove_value = 0;
                        int cut_value = 0;
                        remove_value = r_Number * Price_chicken;
                        if (r_Number > Quantity_chicken)
                        {
                            r_Number = Quantity_chicken;
                            cut_value = r_Number * Price_chicken;

                        }
                        else
                        {
                            cut_value = r_Number * Price_chicken;
                        }
                        Quantity_chicken -= r_Number;
                        Chicken_bill = Quantity_chicken * Price_chicken;

                        total_meat_price = total_meat_price - cut_value;

                    }
                    else if (mutton == true)
                    {
                        int remove_value = 0;
                        int cut_value = 0;
                        remove_value = r_Number * Price_mutton;
                        if (r_Number > Quantity_mutton)
                        {
                            r_Number = Quantity_mutton;
                            cut_value = r_Number * Price_mutton;

                        }
                        else
                        {
                            cut_value = r_Number * Price_mutton;
                        }
                        Quantity_mutton -= r_Number;
                        Mutton_bill = Quantity_mutton * Price_mutton;

                        total_meat_price = total_meat_price - cut_value;
                    }
                    else if (beef == true)
                    {
                        int remove_value = 0;
                        int cut_value = 0;
                        remove_value = r_Number * Price_beef;
                        if (r_Number > Quantity_beef)
                        {
                            r_Number = Quantity_beef;
                            cut_value = r_Number * Price_beef;

                        }
                        else
                        {
                            cut_value = r_Number * Price_beef;
                        }
                        Quantity_beef -= r_Number;
                        Beef_bill = Quantity_beef * Price_beef;


                        total_meat_price = total_meat_price - cut_value;
                    }
                    else if (turkey == true)
                    {
                        int remove_value = 0;
                        int cut_value = 0;
                        remove_value = r_Number * Price_turkey;
                        if (r_Number > Quantity_turkey)
                        {
                            r_Number = Quantity_turkey;
                            cut_value = r_Number * Price_turkey;

                        }
                        else
                        {
                            cut_value = r_Number * Price_turkey;
                        }
                        Quantity_turkey -= r_Number;
                        Turkey_bill = Quantity_turkey * Price_turkey;

                        total_meat_price = total_meat_price - cut_value;
                    }
                    else if (fish == true)
                    {
                        int remove_value = 0;
                        int cut_value = 0;
                        if (fish == true)
                            remove_value = r_Number * Price_fish;
                        if (r_Number > Quantity_fish)
                        {
                            r_Number = Quantity_fish;
                            cut_value = r_Number * Price_fish;

                        }
                        else
                        {
                            cut_value = r_Number * Price_fish;
                        }
                        Quantity_fish -= r_Number;
                        Fish_bill = Quantity_fish * Price_fish;

                        total_meat_price = total_meat_price - cut_value;
                    }

                }
                else
                {

                }
            }
        }

        private void Sweet_menu_TextChanged(object sender, EventArgs e)
        {
            Cheese_button.Visible = true;
            Banana_pudding_Button.Visible = true;
            Brownies_button.Visible = true;
            Creme_Brulee_button.Visible = true;
            Gelato_button.Visible = true;
            Fruit_Tart_button.Visible = true;
            button11.Visible = true;   // add button
            button10.Visible = true;   // Remove Button
            Sweet_menu.Text = "Press 1 for Cheesescake \r\nPress 2 for Banana Pudding\r\nPress 3 for Brownies \r\nPress 4 for Creme Brulee \r\nPress 5 for Gelato \r\nPress 6 for Fruit tart\r\n ";
            Sweet_menu.Show();
        }

        private void Sweet_section_Click(object sender, EventArgs e)
        {
            if (recomended_item == true)
            {
                MessageBox.Show("CheeseCake", "Recommended Item");
            }
            Sweet_menu.Visible = true;
            Sweet_calculation.Visible = true;
            //Cheese_button.Visible = true;
            //Banana_pudding_Button.Visible = true;
            //Brownies_button.Visible = true;
            //Creme_Brulee_button.Visible = true;
            //Gelato_button.Visible = true;
            //Fruit_Tart_button.Visible = true;
            //button11.Visible = true;   // add button
            //button10.Visible = true;   // Remove Button

            //Hide fruit
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            fruitText.Visible = false;
            textBox3.Visible = false; //to hide the fruit calculation

            //Hide Vegetables
            Vegetable.Visible = false;
            Spinch.Visible = false;
            kale_veg.Visible = false;
            Brocolli_veg.Visible = false;
            Pea_veg.Visible = false;
            Sweet_potato_Veg.Visible = false;
            vegetable_calculation.Visible = false;  // to hide the vegetable  calculation box
            //Hide Meat
            Meat_menu.Visible = false;
            Chicken_Button.Visible = false;
            Mutton_button.Visible = false;
            Beef_button.Visible = false;
            Turkey_button.Visible = false;
            Fish_button.Visible = false;
            Meat_calculation.Visible = false;

            //setting bool of Veg to false so that they dont get added in cart when i am adding Veg in cart
            spinach = false;
            kale = false;
            brocolli = false;
            peas = false;
            sweet_potatos = false;
            //setting bool of Meat to false so that they dont get added in cart when i am adding Veg in cart
            chicken = false;
            mutton = false;
            beef = false;
            turkey = false;
            fish = false;

            //setting bool of Fruit to false so that they dont get added in cart when i am adding Veg in cart
            apples = false;
            orange = false;
            mango = false;
            cherry = false;
            peaches = false;


        }

        private void Cheese_button_Click(object sender, EventArgs e)
        {

            BackgroundImage = cheese_cake_image.Image;
            cheesecake = true;
            bananapudding = false;
            brownies = false;
            cremebrulee = false;
            gelato = false;
            fruittart = false;
        }

        private void Banana_pudding_Button_Click(object sender, EventArgs e)
        {
            BackgroundImage = banana_pudding_image.Image;
            cheesecake = false;
            bananapudding = true;
            brownies = false;
            cremebrulee = false;
            gelato = false;
            fruittart = false;
        }

        private void Brownies_button_Click(object sender, EventArgs e)
        {
            BackgroundImage = brownie_image.Image;
            cheesecake = false;
            bananapudding = false;
            brownies = true;
            cremebrulee = false;
            gelato = false;
            fruittart = false;
        }

        private void Creme_Brulee_button_Click(object sender, EventArgs e)
        {
            BackgroundImage = creme_brulee_image.Image;
            cheesecake = false;
            bananapudding = false;
            brownies = false;
            cremebrulee = true;
            gelato = false;
            fruittart = false;
        }

        private void Gelato_button_Click(object sender, EventArgs e)
        {
            BackgroundImage = gelato_image.Image;
            cheesecake = false;
            bananapudding = false;
            brownies = false;
            cremebrulee = false;
            gelato = true;
            fruittart = false;
        }

        private void Fruit_Tart_button_Click(object sender, EventArgs e)
        {
            BackgroundImage = fruit_tart_image.Image;
            cheesecake = false;
            bananapudding = false;
            brownies = false;
            cremebrulee = false;
            gelato = false;
            fruittart = true;
        }

        private void Sweet_calculation_TextChanged(object sender, EventArgs e)
        {


            if (remove_item == false || add == true)
            {
                if (int.TryParse(Sweet_calculation.Text, out int number_s))
                {
                    int price_s = 0;
                    if (cheesecake == true)
                    {
                        if (add == true)
                        {
                            Quantity_cheesecake += number_s;
                            price_s = Quantity_cheesecake * Price_cheesecake;
                            Cheesecake_bill = price_s;
                        }

                    }
                    else if (bananapudding == true)
                    {
                        if (add == true)
                        {
                            Quantity_bananapudding += number_s;
                            price_s = Quantity_bananapudding * Price_bananapudding;
                            Bananapudding_bill = price_s;
                        }

                    }
                    else if (brownies == true)
                    {
                        if (add == true)
                        {
                            Quantity_brownies += number_s;
                            price_s = Quantity_brownies * Price_brownies;
                            Brownies_bill = price_s;
                        }

                    }
                    else if (cremebrulee == true)
                    {
                        if (add == true)
                        {
                            Quantity_cremebrulee += number_s;
                            price_s = Quantity_cremebrulee * Price_cremebrulee;
                            Cremebrulee_bill = price_s;
                        }

                    }
                    else if (gelato == true)
                    {
                        if (add == true)
                        {
                            Quantity_gelato += number_s;
                            price_s = Quantity_gelato * Price_gelato;
                            Gelato_bill = price_s;
                        }

                    }
                    else if (fruittart == true)
                    {
                        if (add == true)
                        {
                            Quantity_fruittart += number_s;
                            price_s = Quantity_fruittart * Price_fruittart;
                            Fruittart_bill = price_s;
                        }

                    }
                    total_sweet_price = Cheesecake_bill + Bananapudding_bill + Brownies_bill + Gelato_bill + Fruittart_bill + Cremebrulee_bill;
                }
                else
                {

                }
            }
            else
            {
                if (int.TryParse(Sweet_calculation.Text, out int re_Number))
                {
                    if (cheesecake == true)
                    {
                        int Actual_rem_value = 0;
                        int cutting_val = 0;
                        Actual_rem_value = re_Number * Price_cheesecake;
                        if (re_Number > Quantity_cheesecake)
                        {
                            re_Number = Quantity_cheesecake;
                            cutting_val = re_Number * Price_cheesecake;

                        }
                        else
                        {
                            cutting_val = re_Number * Price_cheesecake;
                        }
                        Quantity_cheesecake -= re_Number;
                        Cheesecake_bill = Quantity_cheesecake * Price_cheesecake;

                        total_sweet_price = total_sweet_price - cutting_val;
                    }
                    else if (bananapudding == true)
                    {
                        int Actual_rem_value = 0;
                        int cutting_val = 0;
                        Actual_rem_value = re_Number * Price_bananapudding;
                        if (re_Number > Quantity_bananapudding)
                        {
                            re_Number = Quantity_bananapudding;
                            cutting_val = re_Number * Price_bananapudding;

                        }
                        else
                        {
                            cutting_val = re_Number * Price_bananapudding;
                        }
                        Quantity_bananapudding -= re_Number;

                        Bananapudding_bill = Quantity_bananapudding * Price_bananapudding;
                        total_sweet_price = total_sweet_price - cutting_val;
                    }
                    else if (brownies == true)
                    {
                        int Actual_rem_value = 0;
                        int cutting_val = 0;
                        Actual_rem_value = re_Number * Price_brownies;
                        if (re_Number > Quantity_brownies)
                        {
                            re_Number = Quantity_brownies;
                            cutting_val = re_Number * Price_brownies;

                        }
                        else
                        {
                            cutting_val = re_Number * Price_brownies;
                        }
                        Quantity_brownies -= re_Number;
                        Brownies_bill = Quantity_brownies * Price_brownies;

                        total_sweet_price = total_sweet_price - cutting_val;
                    }
                    else if (cremebrulee == true)
                    {
                        int Actual_rem_value = 0;
                        int cutting_val = 0;
                        Actual_rem_value = re_Number * Price_cremebrulee;
                        if (re_Number > Quantity_cremebrulee)
                        {
                            re_Number = Quantity_cremebrulee;
                            cutting_val = re_Number * Price_cremebrulee;

                        }
                        else
                        {
                            cutting_val = re_Number * Price_cremebrulee;
                        }
                        Quantity_cremebrulee -= re_Number;
                        Cremebrulee_bill = Quantity_cremebrulee * Price_cremebrulee;


                        total_sweet_price = total_sweet_price - cutting_val;
                    }
                    else if (gelato == true)
                    {
                        int Actual_rem_value = 0;
                        int cutting_val = 0;
                        Actual_rem_value = re_Number * Price_gelato;
                        if (re_Number > Quantity_gelato)
                        {
                            re_Number = Quantity_gelato;
                            cutting_val = re_Number * Price_gelato;

                        }
                        else
                        {
                            cutting_val = re_Number * Price_gelato;
                        }
                        Quantity_gelato -= re_Number;

                        Gelato_bill = Quantity_gelato * Price_gelato;
                        total_sweet_price = total_sweet_price - cutting_val;
                    }
                    else if (fruittart == true)
                    {
                        int Actual_rem_value = 0;
                        int cutting_val = 0;
                        Actual_rem_value = re_Number * Price_fruittart;
                        if (re_Number > Quantity_fruittart)
                        {
                            re_Number = Quantity_fruittart;
                            cutting_val = re_Number * Price_fruittart;

                        }
                        else
                        {
                            cutting_val = re_Number * Price_fruittart;
                        }
                        Quantity_fruittart -= re_Number;
                        Fruittart_bill = Quantity_fruittart * Price_fruittart;

                        total_sweet_price = total_sweet_price - cutting_val;
                    }
                }
                else
                {

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Apple_background_Click(object sender, EventArgs e)
        {

        }

        private void Mango_image_Click(object sender, EventArgs e)
        {

        }
        //my cart item showing list like i have shown through textbox2 
        //here i will sent the quantity of each item within the list
        public void button2_Click(object sender, EventArgs e)  //show cart button
        {
            show_cart = true;
            listView1.Visible = true;
            if (apples == true)
            {
                ListViewItem apple_in_list = new ListViewItem("Apples");
                if (Quantity_apples != 0)
                {
                    apple_in_list.SubItems.Add(Quantity_apples.ToString());
                    apple_in_list.SubItems.Add(Apples_bill.ToString());
                    listView1.Items.Add(apple_in_list);

                }
                else
                {
                    apple_in_list.SubItems.Add(Quantity_apples.ToString());
                    apple_in_list.SubItems.Add(Apples_bill.ToString());
                    listView1.Items.Add(apple_in_list);
                }

            }
            else if (mango == true)
            {
                ListViewItem mango_in_list = new ListViewItem("mango");
                if (Quantity_mango != 0)
                {
                    mango_in_list.SubItems.Add(Quantity_mango.ToString());
                    mango_in_list.SubItems.Add(Mango_bill.ToString());
                    listView1.Items.Add(mango_in_list);
                }
                else
                {
                    mango_in_list.SubItems.Add(Quantity_mango.ToString());
                    mango_in_list.SubItems.Add(Mango_bill.ToString());
                    listView1.Items.Add(mango_in_list);
                }

            }
            else if (orange == true)
            {
                ListViewItem orange_in_list = new ListViewItem("Orange");
                if (Quantity_orange != 0)
                {
                    orange_in_list.SubItems.Add(Quantity_orange.ToString());
                    orange_in_list.SubItems.Add(Orange_bill.ToString());
                    listView1.Items.Add(orange_in_list);
                }
                else
                {
                    orange_in_list.SubItems.Add(Quantity_orange.ToString());
                    orange_in_list.SubItems.Add(Orange_bill.ToString());
                    listView1.Items.Add(orange_in_list);
                }
            }
            else if (peaches == true)
            {
                ListViewItem peaches_in_list = new ListViewItem("peaches");
                if (Quantity_peaches != 0)
                {
                    peaches_in_list.SubItems.Add(Quantity_peaches.ToString());
                    peaches_in_list.SubItems.Add(Peaches_bill.ToString());
                    listView1.Items.Add(peaches_in_list);
                }
                else
                {
                    peaches_in_list.SubItems.Add(Quantity_peaches.ToString());
                    peaches_in_list.SubItems.Add(Peaches_bill.ToString());
                    listView1.Items.Add(peaches_in_list);
                }

            }
            else if (cherry == true)
            {
                ListViewItem cherry_in_list = new ListViewItem("cherry");
                if (Quantity_cherry != 0)
                {
                    cherry_in_list.SubItems.Add(Quantity_cherry.ToString());
                    cherry_in_list.SubItems.Add(Cherry_bill.ToString());
                    listView1.Items.Add(cherry_in_list);
                }
                else
                {
                    cherry_in_list.SubItems.Add(Quantity_cherry.ToString());
                    cherry_in_list.SubItems.Add(Cherry_bill.ToString());
                    listView1.Items.Add(cherry_in_list);
                }

            }
            else if (spinach == true)         ///////////////////////// VEg walay ma fruits ka bool ko false krna hoga
            {
                ListViewItem spinach_in_list = new ListViewItem("spinach");
                if (Quantity_spinach != 0)
                {
                    spinach_in_list.SubItems.Add(Quantity_spinach.ToString());
                    spinach_in_list.SubItems.Add(Spinach_bill.ToString());
                    listView1.Items.Add(spinach_in_list);
                }
                else
                {
                    spinach_in_list.SubItems.Add(Quantity_spinach.ToString());
                    spinach_in_list.SubItems.Add(Spinach_bill.ToString());
                    listView1.Items.Add(spinach_in_list);
                }

            }
            else if (kale == true)         ///////////////////////// VEg walay ma fruits ka bool ko false krna hoga
            {
                ListViewItem kale_in_list = new ListViewItem("kale");
                if (Quantity_kale != 0)
                {
                    kale_in_list.SubItems.Add(Quantity_kale.ToString());
                    kale_in_list.SubItems.Add(Kale_bill.ToString());
                    listView1.Items.Add(kale_in_list);
                }
                else
                {
                    kale_in_list.SubItems.Add(Quantity_kale.ToString());
                    kale_in_list.SubItems.Add(Kale_bill.ToString());
                    listView1.Items.Add(kale_in_list);
                }

            }
            else if (brocolli == true)         ///////////////////////// VEg walay ma fruits ka bool ko false krna hoga
            {
                ListViewItem brocolli_in_list = new ListViewItem("brocolli");
                if (Quantity_brocolli != 0)
                {
                    brocolli_in_list.SubItems.Add(Quantity_brocolli.ToString());
                    brocolli_in_list.SubItems.Add(Brocolli_bill.ToString());
                    listView1.Items.Add(brocolli_in_list);
                }
                else
                {
                    brocolli_in_list.SubItems.Add(Quantity_brocolli.ToString());
                    brocolli_in_list.SubItems.Add(Brocolli_bill.ToString());
                    listView1.Items.Add(brocolli_in_list);
                }

            }
            else if (peas == true)         ///////////////////////// VEg walay ma fruits ka bool ko false krna hoga
            {
                ListViewItem peas_in_list = new ListViewItem("peas");
                if (Quantity_peas != 0)
                {
                    peas_in_list.SubItems.Add(Quantity_peas.ToString());
                    peas_in_list.SubItems.Add(Peas_bill.ToString());
                    listView1.Items.Add(peas_in_list);
                }
                else
                {
                    peas_in_list.SubItems.Add(Quantity_peas.ToString());
                    peas_in_list.SubItems.Add(Peas_bill.ToString());
                    listView1.Items.Add(peas_in_list);
                }

            }
            else if (sweet_potatos == true)         ///////////////////////// VEg walay ma fruits ka bool ko false krna hoga
            {
                ListViewItem sweet_potatos_in_list = new ListViewItem("sweet_potatos");
                if (Quantity_sweet_potatos != 0)
                {
                    sweet_potatos_in_list.SubItems.Add(Quantity_sweet_potatos.ToString());
                    sweet_potatos_in_list.SubItems.Add(Sweet_Potatos_bill.ToString());
                    listView1.Items.Add(sweet_potatos_in_list);
                }
                else
                {
                    sweet_potatos_in_list.SubItems.Add(Quantity_sweet_potatos.ToString());
                    sweet_potatos_in_list.SubItems.Add(Sweet_Potatos_bill.ToString());
                    listView1.Items.Add(sweet_potatos_in_list);
                }

            }
            else if (chicken == true)                      ///////////////////////Meat section
            {
                ListViewItem chicken_in_list = new ListViewItem("chicken");
                if (Quantity_sweet_potatos != 0)
                {
                    chicken_in_list.SubItems.Add(Quantity_chicken.ToString());
                    chicken_in_list.SubItems.Add(Chicken_bill.ToString());
                    listView1.Items.Add(chicken_in_list);
                }
                else
                {
                    chicken_in_list.SubItems.Add(Quantity_chicken.ToString());
                    chicken_in_list.SubItems.Add(Chicken_bill.ToString());
                    listView1.Items.Add(chicken_in_list);
                }
            }
            else if (chicken == true)                      ///////////////////////Meat section
            {
                ListViewItem chicken_in_list = new ListViewItem("chicken");
                if (Quantity_chicken != 0)
                {
                    chicken_in_list.SubItems.Add(Quantity_chicken.ToString());
                    chicken_in_list.SubItems.Add(Chicken_bill.ToString());
                    listView1.Items.Add(chicken_in_list);
                }
                else
                {
                    chicken_in_list.SubItems.Add(Quantity_chicken.ToString());
                    chicken_in_list.SubItems.Add(Chicken_bill.ToString());
                    listView1.Items.Add(chicken_in_list);
                }
            }
            else if (beef == true)                      ///////////////////////Meat section
            {
                ListViewItem beef_in_list = new ListViewItem("beef");
                if (Quantity_beef != 0)
                {
                    beef_in_list.SubItems.Add(Quantity_beef.ToString());
                    beef_in_list.SubItems.Add(Beef_bill.ToString());
                    listView1.Items.Add(beef_in_list);
                }
                else
                {
                    beef_in_list.SubItems.Add(Quantity_beef.ToString());
                    beef_in_list.SubItems.Add(Beef_bill.ToString());
                    listView1.Items.Add(beef_in_list);
                }
            }
            else if (mutton == true)                      ///////////////////////Meat section
            {
                ListViewItem mutton_in_list = new ListViewItem("mutton");
                if (Quantity_mutton != 0)
                {
                    mutton_in_list.SubItems.Add(Quantity_mutton.ToString());
                    mutton_in_list.SubItems.Add(Mutton_bill.ToString());
                    listView1.Items.Add(mutton_in_list);
                }
                else
                {
                    mutton_in_list.SubItems.Add(Quantity_mutton.ToString());
                    mutton_in_list.SubItems.Add(Mutton_bill.ToString());
                    listView1.Items.Add(mutton_in_list);
                }
            }
            else if (turkey == true)                      ///////////////////////Meat section
            {
                ListViewItem turkey_in_list = new ListViewItem("turkey");
                if (Quantity_turkey != 0)
                {
                    turkey_in_list.SubItems.Add(Quantity_turkey.ToString());
                    turkey_in_list.SubItems.Add(Turkey_bill.ToString());
                    listView1.Items.Add(turkey_in_list);
                }
                else
                {
                    turkey_in_list.SubItems.Add(Quantity_turkey.ToString());
                    turkey_in_list.SubItems.Add(Turkey_bill.ToString());
                    listView1.Items.Add(turkey_in_list);
                }
            }
            else if (fish == true)                      ///////////////////////Meat section
            {
                ListViewItem fish_in_list = new ListViewItem("fish");
                if (Quantity_fish != 0)
                {
                    fish_in_list.SubItems.Add(Quantity_fish.ToString());
                    fish_in_list.SubItems.Add(Fish_bill.ToString());
                    listView1.Items.Add(fish_in_list);
                }
                else
                {
                    fish_in_list.SubItems.Add(Quantity_fish.ToString());
                    fish_in_list.SubItems.Add(Fish_bill.ToString());
                    listView1.Items.Add(fish_in_list);
                }
            }
            else if (cheesecake == true)                      ///////////////////////Sweet  section
            {
                ListViewItem cheesecake_in_list = new ListViewItem("cheese cake");
                if (Quantity_cheesecake != 0)
                {
                    cheesecake_in_list.SubItems.Add(Quantity_cheesecake.ToString());
                    cheesecake_in_list.SubItems.Add(Cheesecake_bill.ToString());
                    listView1.Items.Add(cheesecake_in_list);
                }
                else
                {
                    cheesecake_in_list.SubItems.Add(Quantity_cheesecake.ToString());
                    cheesecake_in_list.SubItems.Add(Cheesecake_bill.ToString());
                    listView1.Items.Add(cheesecake_in_list);
                }
            }
            else if (bananapudding == true)                      ///////////////////////Sweet  section
            {
                ListViewItem bananapudding_in_list = new ListViewItem("Banana Pudding");
                if (Quantity_bananapudding != 0)
                {
                    bananapudding_in_list.SubItems.Add(Quantity_bananapudding.ToString());
                    bananapudding_in_list.SubItems.Add(Bananapudding_bill.ToString());
                    listView1.Items.Add(bananapudding_in_list);
                }
                else
                {
                    bananapudding_in_list.SubItems.Add(Quantity_bananapudding.ToString());
                    bananapudding_in_list.SubItems.Add(Bananapudding_bill.ToString());
                    listView1.Items.Add(bananapudding_in_list);
                }
            }
            else if (brownies == true)                      ///////////////////////Sweet  section
            {
                ListViewItem brownies_in_list = new ListViewItem("brownies");
                if (Quantity_brownies != 0)
                {
                    brownies_in_list.SubItems.Add(Quantity_brownies.ToString());
                    brownies_in_list.SubItems.Add(Brownies_bill.ToString());
                    listView1.Items.Add(brownies_in_list);
                }
                else
                {
                    brownies_in_list.SubItems.Add(Quantity_brownies.ToString());
                    brownies_in_list.SubItems.Add(Brownies_bill.ToString());
                    listView1.Items.Add(brownies_in_list);
                }
            }
            else if (cremebrulee == true)                      ///////////////////////Sweet  section
            {
                ListViewItem cremebrulee_in_list = new ListViewItem("Creme Brulee");
                if (Quantity_cremebrulee != 0)
                {
                    cremebrulee_in_list.SubItems.Add(Quantity_cremebrulee.ToString());
                    cremebrulee_in_list.SubItems.Add(Cremebrulee_bill.ToString());
                    listView1.Items.Add(cremebrulee_in_list);
                }
                else
                {
                    cremebrulee_in_list.SubItems.Add(Quantity_cremebrulee.ToString());
                    cremebrulee_in_list.SubItems.Add(Cremebrulee_bill.ToString());
                    listView1.Items.Add(cremebrulee_in_list);
                }
            }
            else if (gelato == true)                      ///////////////////////Sweet  section
            {
                ListViewItem gelato_in_list = new ListViewItem("Gelato");
                if (Quantity_gelato != 0)
                {
                    gelato_in_list.SubItems.Add(Quantity_gelato.ToString());
                    gelato_in_list.SubItems.Add(Gelato_bill.ToString());
                    listView1.Items.Add(gelato_in_list);
                }
                else
                {
                    gelato_in_list.SubItems.Add(Quantity_gelato.ToString());
                    gelato_in_list.SubItems.Add(Gelato_bill.ToString());
                    listView1.Items.Add(gelato_in_list);
                }
            }
            else if (fruittart == true)                      ///////////////////////Sweet  section
            {
                ListViewItem fruittart_in_list = new ListViewItem("Fruit Tart");
                if (Quantity_fruittart != 0)
                {
                    fruittart_in_list.SubItems.Add(Quantity_fruittart.ToString());
                    fruittart_in_list.SubItems.Add(Fruittart_bill.ToString());
                    listView1.Items.Add(fruittart_in_list);
                }
                else
                {
                    fruittart_in_list.SubItems.Add(Quantity_fruittart.ToString());
                    fruittart_in_list.SubItems.Add(Fruittart_bill.ToString());
                    listView1.Items.Add(fruittart_in_list);
                }
            }

        }
        private void clear_item_Click(object sender, EventArgs e)
        {

            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Discount_button_Click(object sender, EventArgs e)
        {
            discount = true;
        }
        public void textBox2_TextChanged(object sender, EventArgs e)  //my cart item showing list
        {
            if (view_total_bill == true)
            {
                Total_amount_bill = total_fruit_price + total_meat_price + total_sweet_price + total_Veg_price;
                if (discount == true)
                {
                    double d_amount = 0.15 * Total_amount_bill;
                    Total_amount_bill = Total_amount_bill - d_amount;
                    textBox2.Text = "total_fruit_bill : " + total_fruit_price.ToString() + "\r\ntotal_Vegetable_bill : " + total_Veg_price.ToString() + "\r\ntotal_Meat_bill : " + total_meat_price.ToString() + "\r\ntotal_sweet_bill : " + total_sweet_price.ToString() + "\r\ntotal_Discount_amount : " + d_amount.ToString() + "\r\nGrand_Total_amount : " + Total_amount_bill.ToString();
                    textBox2.Show();
                }
                else
                {
                    textBox2.Text = "total_fruit_bill : " + total_fruit_price.ToString() + "\r\ntotal_Vegetable_bill : " + total_Veg_price.ToString() + "\r\ntotal_Meat_bill : " + total_meat_price.ToString() + "\r\ntotal_sweet_bill : " + total_sweet_price.ToString() + "\r\nGrand_Total_amount : " + Total_amount_bill.ToString();
                    textBox2.Show();
                }
            }

        }

        private void Total_bill_button_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            view_total_bill = true;
        }

        private void sweet_potato_pic_Click(object sender, EventArgs e)
        {

        }

        private void Checking_out_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            textBox2.Clear();
            textBox2.Visible = false;
            MessageBox.Show("Thank you !");

        }

        
    }
}
