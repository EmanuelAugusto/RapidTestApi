using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace rapidTestApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void RouterGet(string url)
        {
           

            try
            {
                string URL = url;

                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(URL))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var JsonString = await response.Content.ReadAsStringAsync();

                            textBox2.Text = JsonString;

                            //MessageBox.Show(response.StatusCode.ToString(), "aa");
                            
                            if(response.StatusCode.ToString() == "OK")
                            {
                                label2.Visible = true;
                                label2.Text = "200 OK";
                                label1.Visible = true;
                                label2.BackColor = Color.Lime;
                                textBox2.ScrollBars = ScrollBars.Vertical;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Não foi possível se conectar a API" + response.StatusCode);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Nenhuma rota ou endereço foi definido", "AVISO");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uri = textBox1.Text;
            RouterGet(uri);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
