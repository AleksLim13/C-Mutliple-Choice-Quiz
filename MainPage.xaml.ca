 /// </summary>
    public sealed partial class MainPage : Page
    {

        private RoundsManager rm; 

        public MainPage()
        {
            this.InitializeComponent();
            rm = new RoundsManager();
     
        }//End C:*

        

        public void Page_Loaded(Object sender, RoutedEventArgs e)
        {
            

        }//End M:*

     

        public void GameSignUp_Click(Object sender, RoutedEventArgs e)
        {

            rm.UserSignedUp(NicknameIn.Text);
            NicknameIn.Text = "Thank You!";
        }//End M:*

        public void StartRound_Click(Object sender, RoutedEventArgs e)
        {
            try {
                CodeDocsOut.Text = "";
                rm.StartRound();

                Round round = rm.GetCurrentRound();

                MultipleChoices mcs = round.GetMCS();

                string opA = mcs.GetOptionA();
                OptionAOut.Text = opA;
                string opB = mcs.GetOptionB();
                OptionBOut.Text = opB;
                string opC = mcs.GetOptionC();
                OptionCOut.Text = opC;
                string opD = mcs.GetOptionD();
                OptionDOut.Text = opD;

                string question = mcs.GetQuestion();

                QuestionOut.Text = question;

            }//End TRY:*

            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }//End CAT:*

  
        }//End M:*

        public void CodeDocs_Click(Object sender, RoutedEventArgs e) {
            CodeDocsOut.Text = 
                               "_2018Movies.cs, GameSignUp.cs, Movie.cs, MoviesLoader.cs\n" +
                               "MultipleChoices.cs, Player.cs, Round.cs, Scores.cs\n" +
                               "RoundsManager.cs";
        }//End M:*

        public void NextRound_Click(Object sender, RoutedEventArgs e)
        {
            try {

                rm.NextRound();

                Round round = rm.GetCurrentRound();

                MultipleChoices mcs = round.GetMCS();

                string opA = mcs.GetOptionA();
                OptionAOut.Text = opA;
                string opB = mcs.GetOptionB();
                OptionBOut.Text = opB;
                string opC = mcs.GetOptionC();
                OptionCOut.Text = opC;
                string opD = mcs.GetOptionD();
                OptionDOut.Text = opD;

                string question = mcs.GetQuestion();

                QuestionOut.Text = question;

                ResultOut.Text = "__________";
                PointsOut.Text = "__________";

            }//End TRY:*

            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }//End CAT:*
            
        }//End M:*

        public void ASelected_Click(Object sender, RoutedEventArgs e) {
            try {
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Scores score = rm.AChosen();
            Round round = rm.GetCurrentRound();
            MultipleChoices mcs = round.GetMCS();
            string answer = mcs.GetAnswer();
            ResultOut.Text = answer;

            if (score.GetScore() == 1)
            {
                PointsOut.Text = "You are correct";
            }//End I:*

            else if (score.GetScore() == 0)
            {
                PointsOut.Text = "You are incorrect";
            }//End EI:*
        }//End M:*


        public void BSelected_Click(Object sender, RoutedEventArgs e)
        {
            try
            {
                Scores score = rm.BChosen();
                Round round = rm.GetCurrentRound();
                MultipleChoices mcs = round.GetMCS();
                string answer = mcs.GetAnswer();
                ResultOut.Text = answer;

                if (score.GetScore() == 1)
                {
                    PointsOut.Text = "You are correct";
                }//End I:*

                else if (score.GetScore() == 0)
                {
                    PointsOut.Text = "You are incorrect";
                }//End EI:*
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            

        }//End M:*

        public void CSelected_Click(Object sender, RoutedEventArgs e)
        {
            try
            {
                Scores score = rm.CChosen();
                Round round = rm.GetCurrentRound();
                MultipleChoices mcs = round.GetMCS();
                string answer = mcs.GetAnswer();
                ResultOut.Text = answer;

                if (score.GetScore() == 1)
                {
                    PointsOut.Text = "You are correct";
                }//End I:*

                else if (score.GetScore() == 0)
                {
                    PointsOut.Text = "You are incorrect";
                }//End EI:*
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

          
        }//End M:*

        public void DSelected_Click(Object sender, RoutedEventArgs e)
        {
            try
            {
                Scores score = rm.DChosen();
                Round round = rm.GetCurrentRound();
                MultipleChoices mcs = round.GetMCS();
                string answer = mcs.GetAnswer();
                ResultOut.Text = answer;

                if (score.GetScore() == 1)
                {
                    PointsOut.Text = "You are correct";
                }//End I:*

                else if (score.GetScore() == 0)
                {
                    PointsOut.Text = "You are incorrect";
                }//End EI:*
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }//End M:*

    }//End CL:*
