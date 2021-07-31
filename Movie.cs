 class Movie

    {
        private static int idCount;
        private int id;
        private int year;
        private string name;
        private string question; 
        private List<Movie> movieList;

        public Movie(int year, string name, string question) {
            this.id = idCount;
            Movie.idCount++;
            this.year = year;
            this.name = name;
            this.question = question;
            this.movieList = new List<Movie>();
        }//End C:*

        public Movie() {
            this.movieList = new List<Movie>();
        }//End C:*

        public int GetYear() {
            return year; 
        }//End M:*

        public string GetName() {
            return this.name;
        }//End M:*

        public string GetQuestion()
        {
            return this.question;
        }//End M:*

        public void Create(int year, string name, string question)
        {
            Movie movie = new Movie(year, name, question);
        }//End M:*

        public void Add(Movie movie) {
            movieList.Add(movie);
        }//End M:*

        public Movie ReadMovie(Movie movie) {
            for (int i = 0; i < movieList.Count; i++)
            {
                if (movie == movieList[i])
                {
                    return movieList[i];
                }//End I:*

            }//End F:*
            return null;
        }//End M:*

        public Movie ReadById(int id)
        {
            for (int i = 0; i < movieList.Count; i++) {
                if (id == movieList[i].id) {
                    return movieList[i];
                }//End I:*

            }//End F:*

            return null;
        }//End M:*

        public Movie ReadByName(string name)
        {
            for (int i = 0; i < movieList.Count; i++)
            {
                if (name == movieList[i].name)
                {
                    return movieList[i];
                }//End I:*

            }//End F:*

            return null;

        }//End M:*

        public void UpdateName(int id, string name)
        {
            for (int i = 0; i < movieList.Count; i++)
            {
                if (id == movieList[i].id)
                {
                    movieList[i].name = name;
                }//End I:*

            }//End F:*
        }//End M:*

        public void UpdateYear(int id, int year)
        {
            for (int i = 0; i < movieList.Count; i++)
            {
                if (id == movieList[i].id)
                {
                    movieList[i].year = year;
                }//End I:*

            }//End F:*
        }//End M:*

        public void Delete(int id)
        {
            int counter = 0;
            for (int i = 0; i < movieList.Count; i++)
            {
                if (id == movieList[i].id)
                {
                    counter = i;
                    break;
                }//End I:*

            }//End F:*

            List<Movie> newMList = new List<Movie>();

            for (int i = 0; i < counter; i++)
            {
                newMList[i] = movieList[i];
            }//End F:*

            for (int i = counter + 1; i < movieList.Count; i++)
            {
                newMList[counter] = movieList[i];
                counter++;
            }//End F:*

            this.movieList = newMList;

        }//End M:*

    }//End CL:*
