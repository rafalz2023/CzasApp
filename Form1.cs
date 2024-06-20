using System;
using System.Windows.Forms;

namespace CzasApp
{
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 sekunda
            timer.Tick += new EventHandler(UpdateDateTime);
            timer.Start();
        }

        private void UpdateDateTime(object sender, EventArgs e)
        {
            timeLabel.Text = "Czas: " + DateTime.Now.ToString("HH:mm:ss");
            dateLabel.Text = "Data: " + DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}
