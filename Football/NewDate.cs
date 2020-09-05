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
    public partial class NewDate : Form
    {
        Context db;
        
        public NewDate()
        {
            InitializeComponent();
            db = new Context();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Format = DateTimePickerFormat.Time;

            List<Tournament> tournaments = db.Tournaments.ToList();
            listBox1.DataSource = tournaments;
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Name";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dates d = new Dates();
            d.DateOfStart= dateTimePicker1.Value.ToShortDateString(); 
            d.DateOfEnd= dateTimePicker2.Value.ToShortDateString();
            Tournament t = new Tournament();
            d.IdOfTournament = listBox1.SelectedIndex+1;
           
             
            
            db.Datess.Add(d);
            db.SaveChanges();
            MessageBox.Show("Дата добавлена");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
