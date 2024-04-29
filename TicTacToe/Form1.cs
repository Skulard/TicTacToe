namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        internal int turn = 1;
        public void Clicked(object sender, EventArgs e)
        {
            btnHandler.Clicked(sender, e, turn);
            btnHandler.changeTurn(label2, e, turn);
            turn++;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            string[] btns = ["btn11", "btn12", "btn13", "btn21", "btn22", "btn23", "btn31", "btn32", "btn33"];
            foreach (string btnName in btns)
            {
                Button button = Controls.Find(btnName, true).FirstOrDefault() as Button;
                if (button != null)
                {
                    btnHandler.clearingButtons(button, e);
                }
            }
            btnHandler.clearingLabels(label2, e);
        }
    }
}
