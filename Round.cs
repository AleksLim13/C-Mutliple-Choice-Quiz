 class Round
    {
        private int id;
        private static int idCount;
        private Player player;
        private int round;
        private string question;
        private string answer;
        private MultipleChoices mcs;
        private List<Round> roundList;

        public Round() {
            this.id = Round.idCount;
            Round.idCount++;
            this.roundList = new List<Round>();
            this.player = new Player();
        }//End C:*

        public Round(
                       Player player,
                       int round,
                       string question,
                       string answer,
                       MultipleChoices mcs
               )
        {
            this.id = Round.idCount;
            Round.idCount++;
            this.player = player;
            this.round = round;
            this.question = question;
            this.answer = answer;
            this.mcs = mcs;
            this.roundList = new List<Round>();
        }//End C:*

        public Player GetPlayer() {
            return this.player;
        }//End M:*

        public void SetPlayer(Player player) {
            this.player = player;
        }//End S:*

        public int GetRound() {
            return this.round;
        }//End G:*

        public int GetId() {
            return this.id; 
        }//End M:*

        public string GetQuestion() {
            return this.question;
        }//End G:*

        public string GetAnswer()
        {
            return this.answer;
        }//End G:*

        public MultipleChoices GetMCS()
        {
            return this.mcs;
        }//End G:*

        public Round Create(
                            Player player, 
                            int round, 
                            string question, 
                            string answer, 
                            MultipleChoices mcs
                               ) {
            return new Round(player, round, question, answer, mcs);
        }//End M:*

        public Round Read(int id) {

            for (int i = 0; i < roundList.Count; i++)
            {
                if (id == roundList[i].id)
                {
                    return roundList[i];
                }//End I:*

            }//End F:*

            return null;
        }//End M:*

        public void UpdatePlayer(int id, Player player)
        {

            for (int i = 0; i < roundList.Count; i++)
            {
                if (id == roundList[i].id)
                {
                    roundList[i].player = player;
                }//End I:*

            }//End F:*

        }//End M:*

        public void UpdateRound(int id, int round) {

            for (int i = 0; i < roundList.Count; i++)
            {
                if (id == roundList[i].id)
                {
                    roundList[i].round = round;
                }//End I:*

            }//End F:*

        }//End M:*

        public void UpdateQuestion(int id, string question)
        {
            for (int i = 0; i < roundList.Count; i++)
            {
                if (id == roundList[i].id)
                {
                    roundList[i].question = question;
                }//End I:*

            }//End F:*

        }//End M:*

        public void UpdateAnswer(int id, string answer)
        {
            for (int i = 0; i < roundList.Count; i++)
            {
                if (id == roundList[i].id)
                {
                    roundList[i].answer = answer;
                }//End I:*

            }//End F:*

        }//End M:*

        public void UpdateMCS(int id, MultipleChoices mcs)
        {
            for (int i = 0; i < roundList.Count; i++)
            {
                if (id == roundList[i].id)
                {
                    roundList[i].mcs = mcs;
                }//End I:*

            }//End F:*

        }//End M:*

        public void Delete(int id) {

            int counter = 0;

            for (int i = 0; i < roundList.Count; i++)
            {
                if (id == roundList[i].id)
                {
                    counter = i;
                    break;
                }//End I:*

            }//End F:*

            List<Round> newRList = new List<Round>();

            for (int i = 0; i < counter; i++)
            {
                newRList[i] = roundList[i];
            }//End F:*

            for (int i = counter + 1; i < roundList.Count; i++)
            {
                newRList[counter] = roundList[i];
                counter++;
            }//End F:*

            this.roundList = newRList;
        }//End M:*

    }//End CL:*
