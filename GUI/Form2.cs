using Dane_pogoda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form2 : Form
    {
        public Form2(Weather_info.root w, string m)
        {
            InitializeComponent();
            listBox1.Items.Add(m);
            listBox2.Items.Add(w.weather[0].main);
            listBox3.Items.Add(w.weather[0].description);
            listBox4.Items.Add(w.main.KelvinToCelsius(w.main.temp));
            listBox5.Items.Add(w.main.KelvinToCelsius(w.main.feels_like));
            listBox6.Items.Add(w.main.pressure);
            listBox7.Items.Add(w.main.humidity);
            listBox8.Items.Add(w.main.KelvinToCelsius(w.main.temp_max));
            listBox9.Items.Add(w.main.KelvinToCelsius(w.main.temp_min));

        }
    }
}
