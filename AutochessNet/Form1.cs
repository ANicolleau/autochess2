using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_Auto_Chess.DB;
using System.IO;

namespace AutochessNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MySQLconnector bdd = new MySQLconnector();

            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\sql\init.sql";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    bdd.InitBDD(line);
                }
            }
        }

        private void show_champions_Click(object sender, EventArgs e)
        {

        }

        private void show_heroes_Click(object sender, EventArgs e)
        {

        }

        private void show_classe_Click(object sender, EventArgs e)
        {

        }
    }
}
