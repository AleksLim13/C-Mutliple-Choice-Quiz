class Player

    {
        private int id;
        private static int IdCount;
        private string name;
        private string guess;
        private List<Player> playerList;

        public Player() {
            this.id = IdCount;
            Player.IdCount++;
            this.playerList = new List<Player>();
        }//End C:*

        public Player(string name, string guess)
        {
            this.id = IdCount;
            Player.IdCount++;
            this.name = name;
            this.guess = guess;
            this.playerList = new List<Player>();
        }//End C:*

        public Player(string name)
        {
            this.id = IdCount;
            Player.IdCount++;
            this.name = name;
            this.playerList = new List<Player>();
        }//End C:*

        public string GetName() {
            return this.name;
        }//End M:*

        public string GetGuess()
        {
            return this.guess;
        }//End M:*

        public Player Create(string name, string guess) {
            return new Player(name, guess);
        }//End M:*

        public Player Create(string name)
        {
            return new Player(name);
        }//End M:*

        public List<Player> GetPlayerList() {
            return this.playerList;
        }//End M:*

        public void Add(Player player) {
            this.playerList.Add(player);
        }//End M:*

        public Player Read(int id) {
            for (int i = 0; i < playerList.Count; i++)
            {
                if (id == playerList[i].id)
                {
                    return playerList[i];
                }//End I:*

            }//End F:*

            return null;
        }//End M:*

        public void UpdateName(int id, string name) {
            for (int i = 0; i < playerList.Count; i++)
            {
                if (id == playerList[i].id)
                {
                    playerList[i].name = name; 
                }//End I:*

            }//End F:*
        }//End M:*

        public void UpdateGuess(int id, string guess)
        {
            for (int i = 0; i < playerList.Count; i++)
            {
                if (id == playerList[i].id)
                {
                    playerList[i].guess = guess;
                }//End I:*

            }//End F:*

        }//End M:*

        public void SetGuess(string guess) {
            this.guess = guess;
        }//End S:*

        public void Delete(int id) {
            int counter = 0;
            for (int i = 0; i < playerList.Count; i++)
            {
                if (id == playerList[i].id)
                {
                    counter = i;
                    break;
                }//End I:*

            }//End F:*

            List<Player> newPList = new List<Player>();

            for (int i = 0; i < counter; i++)
            {
                newPList[i] = playerList[i];
            }//End F:*

            for (int i = counter + 1; i < playerList.Count; i++)
            {
                newPList[counter] = playerList[i];
                counter++;
            }//End F:*

            this.playerList = newPList;
        }//End M:*

    }//End CL:*
