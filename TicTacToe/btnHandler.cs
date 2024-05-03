namespace TicTacToe
{
    public class btnHandler
    {
        public static void Clicked(object sender, EventArgs e, int turn)
        {
            Button clickedButton = sender as Button;
            if (turn % 2 != 0)
            {
                clickedButton.Text = "X";
            }
            else
            {
                clickedButton.Text = "O";
            }
            clickedButton.Enabled = false;
        }

        public static void clearingButtons(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Text = "";
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
            button.Enabled = true;
        }

        public static void clearingLabels(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Text = "Spieler 1";
        }

        public static void changeTurn(object sender, EventArgs e, int turn)
        {
            Label label = sender as Label;
            if (turn % 2 != 0)
            {
                label.Text = "Spieler 2";
            }
            else
            {
                label.Text = "Spieler 1";
            }
        }
        public static bool controlWinnerX(string one, string two, string three)
        {
            //somehow to check for winner
            return false;
        }
    }
}
