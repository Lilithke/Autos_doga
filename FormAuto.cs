using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autos_doga
{
    public partial class FormAuto : Form
    {
        string muv;
        public FormAuto(string muv)
        {
            InitializeComponent();
            this.muv = muv;
        }

        private void FormAuto_Load(object sender, EventArgs e)
        {
            switch (muv) 
            {
                case "add":
                    this.Text = "Új laptop";
                    button_muv.Text = "Rögzítés";
                    button_muv.BackColor = Color.Green;
                    button_muv.Click += new EventHandler(insertAuto);
                    break;
                case "edit":
                    this.Text = "Módosítás";
                    button_muv.Text = "Módosítás";
                    button_muv.BackColor = Color.Blue;
                    button_muv.ForeColor = Color.White;
                    button_muv.Click += new EventHandler(updateAuto);
                    adatokFeltoltese();
                    break;
                case "delete":
                    this.Text = "Törlés";
                    button_muv.Text = "Törlés";
                    button_muv.BackColor = Color.Red;
                    button_muv.ForeColor = Color.White;
                    button_muv.Click += new EventHandler(deleteAuto);
                    adatokFeltoltese();
                    break;

            }
        }

        private void deleteAuto(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void insertAuto(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void updateAuto(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            auto.Rend= textBox_rend.Text;
            auto.Mark = textBox_mark.Text;
            auto.Model = textBox_model.Text;
            auto.Gyartasev = int.Parse(textBox_gyartasev.Text);
            auto.VetelAr = decimal.Parse(num_vetelar.Text);
            auto.Hengerurt = int.Parse(num_hengerurt.Text);
            auto.KmAllas = int.Parse(num_kmallas.Text);
            auto.Tomeg = int.Parse(num_tomeg.Text);
            auto.Teljesitmeny = int.Parse(num_teljesitmeny.Text);
            auto.ForgalmiErvenyesseg = DateTime.Parse(dateTimePicker_forg.Text);
            Program.database.updateAuto(auto);


        }

        private void adatokFeltoltese()
        {
            Auto auto = (Auto)Program.nyitoform.listBox_Autok.SelectedItem;
            textBox_rend.Text = auto.Rend.ToString();
            textBox_model.Text = auto.Model.ToString();
            textBox_mark.Text = auto.Mark.ToString();
            textBox_gyartasev.Text = auto.Gyartasev.ToString();
            num_hengerurt.Value = (decimal)auto.Hengerurt;
            num_kmallas.Value = (decimal)auto.KmAllas;
            num_teljesitmeny.Value=(decimal)auto.Teljesitmeny;
            num_tomeg.Value= (decimal)auto.Tomeg;
            num_vetelar.Value = (decimal)auto.VetelAr;
            dateTimePicker_forg.Value = (DateTime)auto.ForgalmiErvenyesseg;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
