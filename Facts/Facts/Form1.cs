using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
namespace Facts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> items = new List<string>();
            items.Add("cat");
            items.Add("dog");
            items.Add("horse");



            comboBox1.Items.AddRange(items.ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = comboBox1.Text;
            decimal amount = numericUpDown1.Value;
            var client = new RestClient($"https://cat-fact.herokuapp.com/facts/random?animal_type={type}&amount={amount}");
            var request = new RestRequest(Method.GET);
            List<response> response = client.Execute<List<response>>(request).Data;
            dataGridView1.DataSource = response;
        }
    }
}
