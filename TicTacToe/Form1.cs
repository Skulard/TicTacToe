//pretty annoying :)
namespace TicTacToe
{
    public partial class Form1 : Form
    {
        #region Variables
        public List<Button> listButtons = new List<Button>();
        internal int turn = 1;
        internal bool WINNER;
        #endregion
        #region Formhandling
        public Form1()
        {
            InitializeComponent();
            listButtons = countButton(grpbxTicTacToe);
        }
        public List<Button> countButton(Control parent)
        {
            List<Button> buttons = new List<Button>();
            foreach (Control child in parent.Controls)
            {
                if (child is Button button)
                {
                    buttons.Add(button);
                }
                if (child.HasChildren)
                {
                    buttons.AddRange(countButton(child));
                }
            }
            return buttons;
        }
        #endregion
        public void Clicked(object sender, EventArgs e)
        {
            btnHandler.Clicked(sender, e, turn);
            btnHandler.changeTurn(label2, e, turn);
            WINNER = btnHandler.controlWinnerX(btn11.Text.ToString(), btn12.Text.ToString(), btn13.Text.ToString());
            turn++;
            if (WINNER == true)
            {
                MessageBox.Show("Spieler 1 hat gewonnen!", "Spiel Vorbei :(");
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            foreach (var btnName in listButtons)
            {
                Button button = Controls.Find(btnName.Name.ToString(), true).FirstOrDefault() as Button;
                if (button != null)
                {
                    btnHandler.clearingButtons(button, e);
                }
            }
            btnHandler.clearingLabels(label2, e);
        }
    }
}
