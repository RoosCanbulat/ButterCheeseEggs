namespace Boter__kaas_en_eieren
{
    public partial class View : Form
    {
        private Controller controller;

        public View()
        {
            InitializeComponent();

            controller = new Controller();
        }

        /// <summary>
        /// Starts and/or restarts with clear buttons
        /// </summary>
        private void Start()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            controller.Start();
        }

        /// <summary>
        /// Marks the selected square
        /// </summary>
        /// <param name="square"></param>
        private void Mark(int square)
        {
            Question question = controller.GetQuestion();
            DialogResult result = MessageBox.Show(question.Text, "Question", MessageBoxButtons.YesNo);
            bool givenAnswer = result == DialogResult.Yes;
            int player = controller.DecidePlayer(question, givenAnswer);
            controller.Mark(player, square);

            Button button = button1;
            if (square == 1)
            {
                button = button1;
            }
            else if (square == 2)
            {
                button = button2;
            }
            else if (square == 3)
            {
                button = button3;
            }
            else if (square == 4)
            {
                button = button4;
            }
            else if (square == 5)
            {
                button = button5;
            }
            else if (square == 6)
            {
                button = button6;
            }
            else if (square == 7)
            {
                button = button7;
            }
            else if (square == 8)
            {
                button = button8;
            }
            else if (square == 9)
            {
                button = button9;
            }

            if (player == 1)
            {
                button.Text = "X";
                button.ForeColor = Color.Blue;
            }
            else
            {
                button.Text = "O";
                button.ForeColor = Color.Red;
            }

           string gameResult = controller.GetResult();
           if (gameResult == "Win")
            {
                MessageBox.Show($"Player {player} won");
                Start();
            }
           else if (gameResult == "Draw")
            {
                MessageBox.Show("Its a draw");
                Start();
            }

        }


        /// <summary>
        /// Starts the game when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mark(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mark(2);            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mark(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mark(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mark(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mark(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Mark(7);
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Mark(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Mark(9);
        }
    }

    /// <summary>
    /// This class represents the questions you get out of the database
    /// </summary>
    public class Question
    {
        public string Text;
        public bool Correct;

        public Question(string text, bool correct)
        {
            Text = text;
            Correct = correct;
        }
    }

    public class Controller
    {
        /// <summary>
        /// Starts a new game
        /// </summary>
        public void Start()
        {
        }

        /// <summary>
        /// Get random question from database
        /// </summary>
        /// <returns></returns>
        public Question GetQuestion()
        {
            return new Question("Dummy", true);
        }

        /// <summary>
        /// Decide player based on given answer to a question
        /// </summary>
        /// <param name="question"></param>
        /// <param name="givenAnswer"></param>
        /// <returns></returns>
        public int DecidePlayer(Question question, bool givenAnswer)
        {
            if (question.Correct == givenAnswer)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        /// <summary>
        /// Marks the square as taken by the player
        /// </summary>
        public void Mark(int player, int square)
        {
            
        }

        /// <summary>
        /// Get the result of the game
        /// </summary>
        /// <returns></returns>
        public string GetResult()
        {
            if (true == true)
            {
                return "Win";               
            }
            else if (true == false)
            {
                return "Draw";
            }
            else
            {
                return "Ongoing";
            }
        }


    }   
}