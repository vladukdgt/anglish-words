using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        
        Timer timer1 = new Timer();
        int i = 0; //поле класса формы

        string[] randoms = new string[7];
        Dictionary<string, string> words = new Dictionary<string, string>()
        {
            
            {"Big","Большой"},
            {"Hig", "Высокий"},
            {"Change", "Менять"},
            {"Ask", "Спрашивать"},
            {"Cat", "Кошка"},
            {"Dog", "Собака"},
            {"Elephant", "Слон"},
            {"Mouse", "Мышь"},

        };
        Button clicButton;
        bool buttonClick = false;
        DateTime start;
        public Form1()
        {
            InitializeComponent();
           button1.Text = "Большой";
            button2.Text = "Высокий";
            button3.Text = "Менять";
            button4.Text = "Спрашивать";
            button5.Text = "Change";
            button6.Text = "Ask";
            button7.Text = "Hig";
            button8.Text = "Big";

            button16.Text = "Слон";
            button17.Text = "Мышь";
            button18.Text = "Кошка";
            button19.Text = "Собака";
            button20.Text = "Cat";
            button21.Text = "Elephant";
            button22.Text = "Dog";
            button23.Text = "Mouse";



        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            label1.Visible = false;
            textBox1.Visible = false;
            button11.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox2.Visible = false;
            timer2.Start();
            start = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button15.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;

            label1.Visible = false;
            textBox1.Visible = false;

            button11.Visible = false;

            label3.Visible = false;
            label4.Visible = false;

            textBox2.Visible = false;
            button12.Visible = false;

            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button11.Visible = true;
            label1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            timer2.Stop();
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) {//"Большой"
            if (buttonClick == false)
            {
                clicButton = button1;
                buttonClick = true;
                


            }
            
        }

        private void button2_Click(object sender, EventArgs e) //"Высокий"
                   
        {
            if (buttonClick == false)
            {
                clicButton = button2;
                buttonClick = true;
                

            }
            
        }

        private void button3_Click(object sender, EventArgs e) //менять
        {
            if (buttonClick == false)
            {
                clicButton = button3;
                buttonClick = true;
                

            }
           
        }

        private void button4_Click(object sender, EventArgs e) // спрашивать
        {
            if (buttonClick == false)
            {
                clicButton = button4;
                buttonClick = true;
                

            }
            
        }

        private void button5_Click(object sender, EventArgs e) //change
        {
            if (buttonClick == false)
            {
                MessageBox.Show("Выберите сначала русское слово");
            }
            else
            {
                if (clicButton.Text == words[button5.Text])
                {
                    clicButton.BackColor = Color.Green;
                    button5.BackColor = Color.Green;

                    button15.Visible = true;
                    buttonClick = false;
                }
                else
                {
                    clicButton.BackColor = Color.Red;
                    button5.BackColor = Color.Red;


                    buttonClick = false;
                }
            }


        }

        private void button6_Click(object sender, EventArgs e) // ask
        {
            if (buttonClick == false)
            {
                MessageBox.Show("Выберите сначала русское слово");
            }
            else
            {
                if (clicButton.Text == words[button6.Text])
                {
                    clicButton.BackColor = Color.Green;
                    button6.BackColor = Color.Green;

                    button15.Visible = true;
                    buttonClick = false;
                }
                else
                {
                    clicButton.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                    
                    
                    buttonClick = false;
                }
            }
            
            
        }

        private void button7_Click(object sender, EventArgs e) //hig
        {
            if (buttonClick == false)
            {
                MessageBox.Show("Выберите сначала русское слово");
            }
            else
            {
                if (clicButton.Text == words[button7.Text])
                {
                    clicButton.BackColor = Color.Green;
                    button7.BackColor = Color.Green;

                    button15.Visible = true;
                    buttonClick = false;
                }
                else
                {
                    clicButton.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                    
                    
                    buttonClick = false;
                }
            }
            
            

        }
              

        private void button8_Click_1(object sender, EventArgs e) //big
        {
            if (buttonClick == false)
            {
                MessageBox.Show("Выберите сначала русское слово");
            }
            else
            {
                if (clicButton.Text == words[button8.Text])
                {
                    clicButton.BackColor = Color.Green;
                    button8.BackColor = Color.Green;

                    button15.Visible = true;
                    buttonClick = false;
                    
                }
                else
                {
                    clicButton.BackColor = Color.Red;
                    button8.BackColor = Color.Red;

                   
                    button8.Enabled = true;
                    buttonClick = false;
                }
            }
            
            
            //button15_Click.Color = 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // разница между текущим временем и начальным
            TimeSpan diff = DateTime.Now - start;
            label2.Text = "Осталось " + (int)(10 - diff.TotalSeconds) + " секунды.";
            if ((int)(10 - diff.TotalSeconds) == 0)
            {
                
                //this.Close();
                timer2.Stop();
                MessageBox.Show("Ваше время прошло!!!");
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button12.Visible = true;
                label2.Visible = false;
                button15.Visible = false;

                button16.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                button21.Visible = false;
                button22.Visible = false;
                button23.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
           //d.Add(d.Count, textBox1.Text);//собственно добавление
            words.Add(textBox2.Text, textBox1.Text);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;

            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            

            timer2.Start();
            start = DateTime.Now;
            button15.Visible = false;

            /*if (button1.Text == "Большой") button16.Text = "Слон";

            

            if (button2.Text == "Высокий") button17.Text = "Мышь";

            

            if (button3.Text == "Менять") button18.Text = "Кошка";

            

            if (button4.Text == "Спрашивать") button19.Text = "Собака";

            

            if (button5.Text == "Change") button20.Text = "Cat";

            
            if (button6.Text == "Ask") button21.Text = "Elephant";

            

            if (button7.Text == "Hig") button22.Text = "Dog";

            

            if (button8.Text == "Big") button23.Text = "Mouse";*/



            timer2.Start();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (buttonClick == false)
            {
                clicButton = button19;
                buttonClick = true;
                button15.Visible = false;

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (buttonClick == false)
            {
                clicButton = button18;
                buttonClick = true;


            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (buttonClick == false)
            {
                clicButton = button17;
                buttonClick = true;


            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (buttonClick == false)
            {
                clicButton = button16;
                buttonClick = true;


            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (buttonClick == false)
            {
                MessageBox.Show("Выберите сначала русское слово");
            }
            else
            {
                if (clicButton.Text == words[button20.Text])
                {
                    clicButton.BackColor = Color.Green;
                    button20.BackColor = Color.Green;

                    
                    buttonClick = false;

                }
                else
                {
                    clicButton.BackColor = Color.Red;
                    button20.BackColor = Color.Red;


                    button20.Enabled = true;
                    buttonClick = false;
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (buttonClick == false)
            {
                MessageBox.Show("Выберите сначала русское слово");
            }
            else
            {
                if (clicButton.Text == words[button21.Text])
                {
                    clicButton.BackColor = Color.Green;
                    button21.BackColor = Color.Green;

                    
                    buttonClick = false;

                }
                else
                {
                    clicButton.BackColor = Color.Red;
                    button21.BackColor = Color.Red;


                    button21.Enabled = true;
                    buttonClick = false;
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (buttonClick == false)
            {
                MessageBox.Show("Выберите сначала русское слово");
            }
            else
            {
                if (clicButton.Text == words[button22.Text])
                {
                    clicButton.BackColor = Color.Green;
                    button22.BackColor = Color.Green;

                    
                    buttonClick = false;

                }
                else
                {
                    clicButton.BackColor = Color.Red;
                    button22.BackColor = Color.Red;


                    button22.Enabled = true;
                    buttonClick = false;
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (buttonClick == false)
            {
                MessageBox.Show("Выберите сначала русское слово");
            }
            else
            {
                if (clicButton.Text == words[button23.Text])
                {
                    clicButton.BackColor = Color.Green;
                    button23.BackColor = Color.Green;

                    
                    buttonClick = false;

                }
                else
                {
                    clicButton.BackColor = Color.Red;
                    button23.BackColor = Color.Red;


                    button23.Enabled = true;
                    buttonClick = false;
                }
            }
        }

        
    }
}


        