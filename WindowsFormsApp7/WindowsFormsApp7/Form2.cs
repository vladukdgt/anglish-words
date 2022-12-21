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
    public partial class Form2 : Form
    {
        Timer timer1 = new Timer();
        int i = 0; //поле класса формы
        string[] randoms = new string[7];
        Dictionary<string, string> words = new Dictionary<string, string>()
        {
            {"Cat", "Кошка" },
            {"Dog", "Собака" },
            {"Elephant", "Слон" },
            {"Mouse", "Мышь"},
            
        };
        Button clicButton;
        bool buttonClick = false;
        DateTime start;
        public Form2()
        {
            InitializeComponent();
            button1.Text = "Кошка";
            button2.Text = "Мышь";
            button3.Text = "Собака";
            button4.Text = "Слон";
            button5.Text = "Elephant";
            button6.Text = "Cat";
            button7.Text = "Dog";
            button8.Text = "Mouse";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonClick == false)
            {
                clicButton = button1;
                buttonClick = true;

            }
        }

            private void button2_Click(object sender, EventArgs e)
            {
            if (buttonClick == false)
            {
                clicButton = button2;
                buttonClick = true;

            }

        }

            private void button3_Click(object sender, EventArgs e)
            {
            if (buttonClick == false)
            {
                clicButton = button3;
                buttonClick = true;

            }

        }

            private void button4_Click(object sender, EventArgs e)
            {
            if (buttonClick == false)
            {
                clicButton = button4;
                buttonClick = true;

            }

        }

        private void button5_Click(object sender, EventArgs e)
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


                    buttonClick = false;

                }
                if (clicButton.Text != words[button5.Text])
                {
                    clicButton.BackColor = Color.Red;
                    button5.BackColor = Color.Red;


                    buttonClick = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
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


                    buttonClick = false;

                }
                if (clicButton.Text != words[button6.Text])
                {
                    clicButton.BackColor = Color.Red;
                    button6.BackColor = Color.Red;


                    buttonClick = false;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
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


                    buttonClick = false;

                }
                if (clicButton.Text != words[button7.Text])
                {
                    clicButton.BackColor = Color.Red;
                    button7.BackColor = Color.Red;


                    buttonClick = false;
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
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


                    buttonClick = false;

                }
                if (clicButton.Text != words[button8.Text])
                {
                    clicButton.BackColor = Color.Red;
                    button8.BackColor = Color.Red;


                    buttonClick = false;
                }

            }
        }

            private void button12_Click(object sender, EventArgs e)
            {
            Application.Restart();

        }

            private void button14_Click(object sender, EventArgs e)
            {
                Close();
            }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // разница между текущим временем и начальным
            TimeSpan diff = DateTime.Now - start;
            label1.Text = "Осталось " + (int)(10 - diff.TotalSeconds) + " секунды.";
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
                button12.Visible = true;
                label1.Visible = false;
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    
}

