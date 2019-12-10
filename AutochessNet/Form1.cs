using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_AUTO_CHESS.DB;
using System.IO;

namespace AutochessNet
{
    public partial class Form1 : Form
    {
        MySQLconnector database = new MySQLconnector();
        public Form1()
        {
            InitializeComponent();

            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\sql\init.sql";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    database.InitBDD(line);
                }
            }
        }

        private void show_champions_Click(object sender, EventArgs e)
        {
            List<string> champions = database.Select_All_Values_From_Table("champions");
            var message = string.Join(Environment.NewLine, champions);
            MessageBox.Show(message);
            
        }

        private void show_heroes_Click(object sender, EventArgs e)
        {
            List<string> heroes = database.Select_All_Values_From_Table("heroes");
            var message = string.Join(Environment.NewLine, heroes);
            MessageBox.Show(message);
        }

        private void show_classe_Click(object sender, EventArgs e)
        {
            List<string> classe = database.Select_All_Values_From_Table("classe");
            var message = string.Join(Environment.NewLine, classe);
            MessageBox.Show(message);
        }

        private void begin_game_Click(object sender, EventArgs e)
        {

        }
    }
}
