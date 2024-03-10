using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Autos_doga
{
    public partial class NyitoForm : Form
    {
        public NyitoForm()
        {
            InitializeComponent();
        }

        private void NyitoForm_Load(object sender, EventArgs e)
        {
            foreach (string mark in Program.autok.Select(a => a.Mark).Distinct())
            {
                CheckBox cb = new CheckBox();
                cb.Text = mark;
                cb.Checked = true;
                cb.Location = new Point(10, panel_Marka.Controls.Count * 20);
                cb.CheckedChanged += new EventHandler(marka_valtozott);
                panel_Marka.Controls.Add(cb);
            }
            UpdateAutokList();
        }
        private void marka_valtozott(object sender, EventArgs e)
        {
            UpdateAutokList();
        }
        private void UpdateAutokList()
        {
            listBox_Autok.Items.Clear();
            List<string> kijelolt = new List<string>();
            foreach (CheckBox item in panel_Marka.Controls)
            {
                if (item.Checked) { kijelolt.Add(item.Text); };
            }  
            foreach (Auto item in Program.autok)
            {
                    if (kijelolt.Contains(item.Mark))
                    {
                        listBox_Autok.Items.Add(item);
                    }
            }
            
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormAuto formAuto = new FormAuto("add");
            formAuto.ShowDialog();

        }

        private void módosítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Autok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return; 
            }
            FormAuto formAuto = new FormAuto("edit");
            formAuto.ShowDialog();
        }

        private void törölToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Autok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;
            }
            FormAuto formAuto = new FormAuto("delete");
            formAuto.ShowDialog();
        }
    }   
}
