using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace WpfApp4

{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new MainForm());
        }
    }
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string movieTitle = "Название фильма";
            DateTime startTime = DateTime.Now.AddHours(2);
            Image moviePoster = Image.FromFile("poster.jpg");

            Label titleLabel = new Label
            {
                Text = movieTitle,
                Location = new System.Drawing.Point(10, 10),
                AutoSize = true,
                Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 16, System.Drawing.FontStyle.Bold),
            };

            Label timeLabel = new Label
            {
                Text = startTime.ToString("dd.MM.yyyy HH:mm"),
                Location = new System.Drawing.Point(10, 50),
                AutoSize = true,
                Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 14),
            };

            PictureBox posterPictureBox = new PictureBox
            {
                Image = moviePoster,
                Location = new System.Drawing.Point(10, 90),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new System.Drawing.Size(200, 300),
            };

            Controls.Add(titleLabel);
            Controls.Add(timeLabel);
            Controls.Add(posterPictureBox);
        }
    }
}