  class Scores
    {
        private int id;
        private static int idCount;
        private Player player;
        private int round;
        private int score;
        private string answer;
        private List<Scores> scoresList;

        public Scores(
                      Player player, 
                      int round, 
                      int score, 
                      string answer
                     )
        {
            this.id = Scores.idCount;
            Scores.idCount++;
            this.player = player;
            this.round = round;
            this.score = score;
            this.answer = answer;
            this.scoresList = new List<Scores>();
        }//End C:*

        public Scores()
        {
            this.player = new Player();
            this.scoresList = new List<Scores>();
        }//End C:*

        public Player GetPlayer() {
            return this.player;
        }//End G:*

        public int GetRound() {
            return this.round;
        }//End G:*

        public int GetScore()
        {
            return this.score;
        }//End G:*


        public Scores Create(
                      Player player,
                      int round,
                      int score,
                      string answer
                      ) {
            return new Scores(player, round, score, answer);
        }//End M:*

        public Scores Read(int id)
        {
            for (int i = 0; i < scoresList.Count; i++)
            {
                if (id == scoresList[i].id)
                {
                    return scoresList[i];
                }//End I:*

            }//End F:*

            return null;
        }//End M:*

        public void UpdatePlayer(int id, Player player)
        {
            for (int i = 0; i < scoresList.Count; i++)
            {
                if (id == scoresList[i].id)
                {
                    scoresList[i].player= player;
                }//End I:*

            }//End F:*
        }//End M:*

        public void UpdateScore(int id, int score)
        {
            for (int i = 0; i < scoresList.Count; i++)
            {
                if (id == scoresList[i].id)
                {
                    scoresList[i].score = score;
                }//End I:*

            }//End F:*

        }//End M:*

        public void UpdateRound(int id, int round)
        {
            for (int i = 0; i < scoresList.Count; i++)
            {
                if (id == scoresList[i].id)
                {
                    scoresList[i].round = round;
                }//End I:*

            }//End F:*
        }//End M:*

        public void UpdateAnswer(int id, string answer)
        {
            for (int i = 0; i < scoresList.Count; i++)
            {
                if (id == scoresList[i].id)
                {
                    scoresList[i].answer = answer;
                }//End I:*

            }//End F:*
        }//End M:*

        public void Delete(int id)
        {
            int counter = 0;
            for (int i = 0; i < scoresList.Count; i++)
            {
                if (id == scoresList[i].id)
                {
                    counter = i;
                    break;
                }//End I:*

            }//End F:*

            List<Scores> newSList = new List<Scores>();

            for (int i = 0; i < counter; i++)
            {
                newSList[i] = scoresList[i];
            }//End F:*

            for (int i = counter + 1; i < scoresList.Count; i++)
            {
                newSList[counter] = scoresList[i];
                counter++;
            }//End F:*

            this.scoresList = newSList;

        }//End M:*

    }//End CL:*
