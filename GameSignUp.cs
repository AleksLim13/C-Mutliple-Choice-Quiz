  class GameSignUp
    {
        private int id;
        private static int idCount;
        private Player player; 
        private List<GameSignUp> gsuList;

        public GameSignUp(Player player) {
            this.id = GameSignUp.idCount;
            GameSignUp.idCount++;
            this.player = player; 
            this.gsuList = new List<GameSignUp>();
        }//End C:*

        public GameSignUp()
        {
            this.id = GameSignUp.idCount;
            GameSignUp.idCount++;
            this.player = new Player();
            this.gsuList = new List<GameSignUp>();
        }//End C:*

        public GameSignUp(List<GameSignUp> gsuList) {
            this.id = GameSignUp.idCount;
            GameSignUp.idCount++;
            this.player = new Player();
            this.gsuList = gsuList;
        }//End C:*

        public Player GetPlayer() {
            return this.player; 
        }//End M:*

        public List<GameSignUp> GetGSUList()
        {
            return this.gsuList;
        }//End M:*

        public GameSignUp Create(string nickname)
        {
            Player player = new Player(nickname);
            this.player = player; 
            return new GameSignUp(player);
        }//End M:*

        public void Add(GameSignUp gsu) {
            gsuList.Add(gsu);
        }//End M:*

        public GameSignUp Read(int id)
        {
            for (int i = 0; i < gsuList.Count; i++)
            {
                if (id == gsuList[i].id)
                {
                    return gsuList[i];
                }//End I:*

            }//End F:*

            return null;
        }//End M:*

        public void UpdatePlayer(int id, Player player)
        {
            for (int i = 0; i < gsuList.Count; i++)
            {
                if (id == gsuList[i].id)
                {
                    gsuList[i].player = player;
                }//End I:*

            }//End F:*
        }//End M:*

        public void Delete(int id)
        {
            int counter = 0;
            for (int i = 0; i < gsuList.Count; i++)
            {
                if (id == gsuList[i].id)
                {
                    counter = i;
                    break;
                }//End I:*

            }//End F:*

            List<GameSignUp> newGSUList = new List<GameSignUp>();

            for (int i = 0; i < counter; i++)
            {
                newGSUList[i] = gsuList[i];
            }//End F:*

            for (int i = counter + 1; i < gsuList.Count; i++)
            {
                newGSUList[counter] = gsuList[i];
                counter++;
            }//End F:*

            this.gsuList = newGSUList;
        }//End M:*

    }//End CL:*

