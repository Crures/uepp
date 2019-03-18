using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uepp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Data info = new Data();
            info.AddDeck(1);
            info.ShuffleCards(info.GetDeck());

            listBox1.DataSource = info.GetDeckCardNames();

        }
    }
}
