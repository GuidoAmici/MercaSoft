namespace View
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void Container_Reload(object sender, EventArgs e)
        {
            /*
            if (!Program.Logged)
            {
                this.mainPanel.Parent = new LogIn();
                this.mainPanel.Show();
            }
            */
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}