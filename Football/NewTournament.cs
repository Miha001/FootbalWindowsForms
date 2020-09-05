using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football
{
    public partial class NewTournament : Form
    {
        Context db;
        public NewTournament()
        {
            InitializeComponent();
            db = new Context();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tournament tour = new Tournament();
            tour.Name = textBox1.Text;
            tour.Season = textBox3.Text;


            db.Tournaments.Add(tour);
            db.SaveChanges();
            MessageBox.Show("Новый турнир добавлен");
        }
    }
}
