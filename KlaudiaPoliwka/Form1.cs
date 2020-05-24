using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlaudiaPoliwka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sweetEntities MojModel = new sweetEntities();
            Smak mojSmak = new Smak(); 
            mojSmak.NazwaSmaku = textBox1.Text;
            MojModel.SmakSet.Add(mojSmak);
            MojModel.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sweetEntities MojModel = new sweetEntities();
            dataGridView1.DataSource = MojModel.SmakSet.OrderBy(k => k.idSmak).ToList();
        }
    }
}
