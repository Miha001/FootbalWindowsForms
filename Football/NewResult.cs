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
    public partial class NewResult : Form
    {
        Context db;
        public NewResult()
        {
            InitializeComponent();
            db = new Context();
            List<Team> teams1 = db.Teams.ToList();
            List<Team> teams2 = db.Teams.ToList();
            lb1.DataSource = teams1;
            lb1.ValueMember = "Id";
            lb1.DisplayMember = "Name";

            lb2.DataSource = teams2;
            lb2.ValueMember = "Id";
            lb2.DisplayMember = "Name";

            List<Tournament> tournaments = db.Tournaments.ToList();
            listBox3.DataSource = tournaments;
            listBox3.ValueMember = "Id";
            listBox3.DisplayMember = "Name";

            dateTimePicker1.Format = DateTimePickerFormat.Time;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result r = new Result();

            r.IdOfFirstPlace= lb1.SelectedIndex + 1;
            r.IdOfSecondPlace= lb2.SelectedIndex + 1;
            r.IdOfTournament = listBox3.SelectedIndex + 1;
            r.Score = Score.Text;
            r.DateOfResult= dateTimePicker1.Value.ToShortDateString();



            db.Results.Add(r);
            db.SaveChanges();
            MessageBox.Show("Результат добавлен");
        }
    }
}
