using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Набери_число
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            switch (Form1.vict)
            {
                case Form1.Victory.Gold:
                    pictureBox1.Image = Properties.Resources.iввв;
                    label1.Text += "\nВы достигли отличного результата\n" +
                                        "Вы использовали всего " + Form1.myCountCommand.ToString() + " команд!";
                    break;
                case Form1.Victory.Silver:
                    pictureBox1.Image = Properties.Resources.iыы;
                    label1.Text += "\nНеплохо, неплохо... Вы на правильном пути!\n" +
                                                "Вы использовали  " + Form1.myCountCommand.ToString() + " команд.";
                    break;
                case Form1.Victory.Copper:
                    pictureBox1.Image = Properties.Resources.iФ;
                    label1.Text += "\nМммм да... но всё же вы в тройке победителей!\n" +
                                                "Вы использовали  " + Form1.myCountCommand.ToString() + " команд.";
                    break;
            }
        }
    }
}
