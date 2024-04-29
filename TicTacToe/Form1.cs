//pretty annoying :)
namespace TicTacToe
{
    public partial class Form1 : Form
    {
        #region Variables
        internal int turn = 1;
        internal bool WINNER;
        #endregion
        #region Formhandling
        public Form1()
        {
            InitializeComponent();
        }
        public void Clicked(object sender, EventArgs e)
        {
            btnHandler.Clicked(sender, e, turn);
            btnHandler.changeTurn(label2, e, turn);
            WINNER =btnHandler.controlWinnerX(btn11.Text.ToString(), btn12.Text.ToString(), btn13.Text.ToString());
            turn++;
            if(WINNER==true)
            {
                MessageBox.Show("Spieler 1 hat gewonnen!", "Spiel Vorbei :(");
            }
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
#endregion
}
