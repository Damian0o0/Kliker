using System.Threading;
using System.Timers;

namespace clicker
{
    public partial class Form1 : Form
    {
        private int licznik = 0;
        private int _ticks;
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            licznik++;
            label1.Text = licznik.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            label2.Text = "Czas: " + _ticks.ToString();
            if(_ticks == 3)
            {
                button1.Text = "Koniec";
                timer1.Stop();
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            licznik = 0;
            label1.Text = licznik.ToString();
            label2.Text = "Czas: 0";
            timer1.Stop();
            _ticks = 0;
            button1.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}