using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private string countru_box_value_;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Config conf =  new Config();
            conf.SetCountry(countru_box_value_);
            WeatherRequest weatherRequest = new WeatherRequest(conf);
            temperature.Text = weatherRequest.GetTemp();
            description.Text = weatherRequest.GetDesc();
            wind.Text = weatherRequest.GetWing();
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void label1_Click(object sender, EventArgs e) {}

        private void label5_Click(object sender, EventArgs e) {}

        private void cityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            countru_box_value_ = cityBox.SelectedItem.ToString();
        }
    }
}
