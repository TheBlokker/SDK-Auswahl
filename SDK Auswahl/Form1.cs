namespace SDK_Auswahl
{
    public partial class Form1 : Form
    {
        Aboutbox aboutBox = new Aboutbox();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            aboutBox.Show();
        }
    }
}