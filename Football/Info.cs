using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Football
{
    public partial class Info : Form
    {
        Context db;
        string str;
        public Info()
        {
            InitializeComponent();
            db = new Context();
            db.Datess.Load();
            db.Teams.Load();
            db.Tournaments.Load();
            db.Results.Load();
            dataGridView1.DataSource = db.Teams.Local.ToBindingList();
            dataGridView2.DataSource = db.Tournaments.Local.ToBindingList();
            dataGridView3.DataSource = db.Datess.Local.ToBindingList();
            dataGridView4.DataSource = db.Results.Local.ToBindingList();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
     

            List<Tournament> tournaments = db.Tournaments.ToList();
            listBox1.DataSource = tournaments;
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Name";

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strdate = dateTimePicker1.Value.ToShortDateString();
            var pur = db.Results.Where(p => p.DateOfResult == strdate);
            int tourId= listBox1.SelectedIndex+1;

            foreach (Result p in pur)
            {
                if (p.IdOfTournament==tourId)
                {
                string score = p.Score.ToString();
                str += "Дата: " + p.DateOfResult + " - счет: " + score + " ,Id-первое место: " + p.IdOfFirstPlace + ",Id=второе место: " + p.IdOfSecondPlace+"\n";

                }
                
            }
            label6.Text = string.Format(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
       

           
        }
    }
}
