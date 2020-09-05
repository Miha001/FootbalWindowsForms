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
    public partial class NewTeam : Form
    {
        Context db;
        public NewTeam()
        {
            InitializeComponent();
            db = new Context();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            team.Name = NameTeam.Text;
            team.Coach = NameCoach.Text;
           

            db.Teams.Add(team);
            db.SaveChanges();
            MessageBox.Show("Новая команда добавлена");
        }
    }
}
