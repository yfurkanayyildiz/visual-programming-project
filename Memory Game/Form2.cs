using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void memory_game(object sender, EventArgs e)
        {
            Form1 memoryGame = new Form1();
            //main menü kapanmıyor yada tekrar açılmıyor
            //memoryGame.mainMenu = this;
            memoryGame.Show();
            this.Hide();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //public void showMainMenu()
        //{
        //    this.Show();
        //}
    }
}
