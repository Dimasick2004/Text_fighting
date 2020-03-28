using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fighting
{
    public partial class Form1 : Form
    {
        SoundPlayer sf = new SoundPlayer(@"C:\Users\User\source\repos\Fighting\Fighting\Resources\Recording_4.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Жди релиз! Кстати, нажми на логотип :)";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Текстовый файтинг на двоих, который состоит из угадывания действий противника. Игрок выбирает направление атаки, ваш оппонент, который должен не знать о направлении атаки, выбирает направление блока. Если угадывает - сейвит свои hp, если не угадывает - теряет.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sf.Play();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Разработчик данного проекта: Назаренко Дмитрий.";
        }
    }
}
