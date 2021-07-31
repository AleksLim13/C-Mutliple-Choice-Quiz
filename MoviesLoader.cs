class MoviesLoader
    {

        private List<Movie> movieList;
        
        public MoviesLoader() {
            this.movieList = new List<Movie>();
        }//End C:*

        public MoviesLoader(List<Movie> mList) {
            this.movieList = mList;
        }//End C:*


        public void Load2018MovieList()
        {
            _2018Movies _2018movies = new _2018Movies();

            string[] _2018MNames = _2018movies.GetMovieNames();
            string[] _2018MQuestions = _2018movies.GetMovieQuestions();

            for (int i = 0; i < _2018MNames.Length; i++)
            {
                Movie movie = new Movie(2018, _2018MNames[i], _2018MQuestions[i]);
                movieList.Add(movie);
            }//End F:*

        }//End M:*


        public void ShuffleMovieList() {
            Random randy = new Random();
            int actualRando = randy.Next(0, this.movieList.Count);
                
            for (int i = 0; i < movieList.Count; i++)
            {
                //swapping the elements
                Movie temp = movieList[actualRando];
                movieList[actualRando] = movieList[i];
                movieList[i] = temp;

            }//End F:*

        }//End M:*

        public List<Movie> GetMovieList() {
            return this.movieList;
        }//End M:*

    }//End CL:*
