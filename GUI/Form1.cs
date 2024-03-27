using Dane_pogoda;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
namespace GUI
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string miasto = comboBox1.Text;/*dzia³a tylko dla London bo trzeba podaæ te¿ znacznik kraju*/
            
            string call = $"http://api.openweathermap.org/data/2.5/weather?q={miasto}&APPID=790d009aaa18a4aa46f1271e72d613af";
            string response = await client.GetStringAsync(call);
            Weather_info.root info = JsonSerializer.Deserialize<Weather_info.root>(response);
            Form2 form2 = new Form2(info, miasto);
            form2.pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon +".png";
            if (checkBox1.Checked)
            {
                form2.label6.Visible = true;
                form2.listBox6.Visible = true;
                form2.label7.Visible = true;
                form2.listBox7.Visible = true;
                form2.label8.Visible = true;
                form2.listBox8.Visible = true;
                form2.label9.Visible = true;
                form2.listBox9.Visible = true;
            }

            form2.Show();

        }

      
    }
}
