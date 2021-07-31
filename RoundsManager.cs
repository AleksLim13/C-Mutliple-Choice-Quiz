class RoundsManager
    {
        private int id;
        private static int idCount;
        private static int roundCount; 
        private MoviesLoader ml;
        private Player currentPlayer;
        private Round currentRound;
        private GameSignUp gsu;
        
        public RoundsManager() {
            this.id = RoundsManager.idCount;
            RoundsManager.idCount++;
            this.ml = new MoviesLoader();
            this.currentPlayer = new Player();
            this.currentRound = new Round();
            this.gsu = new GameSignUp();
            this.LoadMovies();
        }//End C:*

        public RoundsManager(Player current)
        {
            this.id = RoundsManager.idCount;
            RoundsManager.idCount++;
            this.currentPlayer = current;
            this.currentRound = new Round();
            this.ml = new MoviesLoader();
            this.gsu = new GameSignUp();
            this.LoadMovies();
        }//End C:*

        public void LoadMovies() {
            this.ml.Load2018MovieList();
        }//End M:*

        public Player GetCurrentPlayer() {
            return this.currentPlayer;
        }//End M:*

        public MoviesLoader GetMoviesLoader() {
            return this.ml;
        }//End M:*

        public Round GetCurrentRound() {
            return this.currentRound;
        }//End M:*

        public GameSignUp GetGameSignUp() {
            return gsu;
        }//End M:*

        public void UserSignedUp(string nickname)
        {
            this.gsu = new GameSignUp(new Player(nickname));
            this.currentPlayer = this.gsu.GetPlayer();

        }//End M:*

        public MultipleChoices SetupChoices()
        {
            ml.ShuffleMovieList();
            Random randy = new Random();
            List<Movie> mll = ml.GetMovieList();
            int capacity = mll.Count;
            List<Movie> roundOptions = new List<Movie>();

            int actRand = randy.Next(0, capacity);
            Movie optionA = mll[actRand];
            roundOptions.Add(optionA);

            actRand = randy.Next(0, capacity);
            Movie optionB = mll[actRand];
            roundOptions.Add(optionB);

            actRand = randy.Next(0, capacity);
            Movie optionC = mll[actRand];
            roundOptions.Add(optionC);

            actRand = randy.Next(0, capacity);
            Movie optionD = mll[actRand];
            roundOptions.Add(optionD);


            actRand = randy.Next(0, 4);

            Movie currentQuestion = roundOptions[actRand];

            MultipleChoices mcs = new MultipleChoices(
                optionA.GetName(), 
                optionB.GetName(), 
                optionC.GetName(), 
                optionD.GetName(), 
                currentQuestion.GetName(),
                currentQuestion.GetQuestion()
                );
            

            return mcs;
        }//End M:*

        public void StartRound() {

           
            MultipleChoices mcs = this.SetupChoices();

            Round round = new Round(
                                    currentPlayer, 
                                    RoundsManager.roundCount, 
                                    mcs.GetQuestion(), 
                                    mcs.GetAnswer(),
                                    mcs
                                    );

            RoundsManager.roundCount++;

            this.currentRound = round;

            
        }//End M:*

        public void NextRound() {
            this.StartRound();
        }//End M:*

        public Scores CalcResults()
        {

            Scores score;

            if (this.currentPlayer.GetGuess() == this.currentRound.GetAnswer())
            {
                score = new Scores(
                                          this.currentPlayer,
                                          RoundsManager.roundCount,
                                          1,
                                          this.currentPlayer.GetGuess()
                                          );
                return score;
            }//End I:*


            score = new Scores(
                                    this.currentPlayer,
                                    RoundsManager.roundCount,
                                    0,
                                    this.currentPlayer.GetGuess()
                                    );
            return score;


        }//End M:*

        public Scores AChosen() {
            Round round = this.currentRound;
            Player player = this.currentRound.GetPlayer();
            MultipleChoices mc = round.GetMCS();
            string opA = mc.GetOptionA();
            player.SetGuess(opA);
            this.currentPlayer = player;
            return this.CalcResults();
        }//End M:*

        public Scores BChosen() {
            Round round = this.currentRound;
            Player player = this.currentRound.GetPlayer();
            MultipleChoices mc = round.GetMCS();
            string opB = mc.GetOptionB();
            player.SetGuess(opB);
            this.currentPlayer = player;
            return this.CalcResults();
        }//End M:*

        public Scores CChosen() {
            Round round = this.currentRound;
            Player player = this.currentRound.GetPlayer();
            MultipleChoices mc = round.GetMCS();
            string opC = mc.GetOptionC();
            player.SetGuess(opC);
            this.currentPlayer = player;
            return this.CalcResults();
        }//End M:*

        public Scores DChosen() {
            Round round = this.currentRound;
            Player player = this.currentRound.GetPlayer();
            MultipleChoices mc = round.GetMCS();
            string opD = mc.GetOptionD();
            player.SetGuess(opD);
            this.currentPlayer = player;
            return this.CalcResults();

        }//End M:*

    }//End CL:*
