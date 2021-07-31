class MultipleChoices
    {
        private int id;
        private static int idCount;
        private string optionA;
        private string optionB;
        private string optionC;
        private string optionD;
        private string answer;
        private string question;
        private List<MultipleChoices> mcList;

        public MultipleChoices() {
            this.id = MultipleChoices.idCount;
            MultipleChoices.idCount++;
            this.mcList = new List<MultipleChoices>();
        }//End C:*

        public MultipleChoices(
                             string opA,
                             string opB,
                             string opC,
                             string opD,
                             string answer,
                             string question
            )
        {
            this.id = MultipleChoices.idCount;
            MultipleChoices.idCount++;
            this.optionA = opA;
            this.optionB = opB;
            this.optionC = opC;
            this.optionD = opD;
            this.answer = answer;
            this.question = question;
            this.mcList = new List<MultipleChoices>();
        }//End C:*

        public String GetOptionA() {
            return this.optionA;
        }//End G:*

        public String GetOptionB()
        {
            return this.optionB;
        }//End G:*

        public String GetOptionC()
        {
            return this.optionC;
        }//End G:*

        public String GetOptionD()
        {
            return this.optionD;
        }//End G:*

        public string GetAnswer() {
            return this.answer;
        }//End M:*

        public string GetQuestion()
        {
            return this.question;
        }//End M:*

        public List<MultipleChoices> GetMCList() {
            return this.mcList;
        }//End G:*

        public MultipleChoices Create(
                             string opA,
                             string opB,
                             string opC,
                             string opD,
                             string answer,
                             string question) {

            return new MultipleChoices(opA, opB, opC, opD, answer, question);

        }//End M:*

        public void Add(MultipleChoices mc) {
            this.mcList.Add(mc);
        }//End M:*

        public MultipleChoices Read(int id) {
            
            for (int i = 0; i < mcList.Count; i++)
            {
                if (id == mcList[i].id)
                {
                    return mcList[i];
                }//End I:*

            }//End F:*

            return null;

        }//End M:*

        public void UpdateOptionA(int id, string opA) {

            for (int i = 0; i < mcList.Count; i++)
            {
                if (id == mcList[i].id)
                {
                    mcList[i].optionA = opA;
                }//End I:*

            }//End F:*

        }//End M:*

        public void UpdateOptionB(int id, string opB) {
            
            for (int i = 0; i < mcList.Count; i++)
            {
                if (id == mcList[i].id)
                {
                    mcList[i].optionB = opB;
                }//End I:*

            }//End F:*

        }//End M:*

        public void UpdateOptionC(int id, string opC) {
            for (int i = 0; i < mcList.Count; i++)
            {
                if (id == mcList[i].id)
                {
                    mcList[i].optionC = opC;
                }//End I:*

            }//End F:*
        }//End M:*

        public void UpdateOptionD(int id, string opD) {
            for (int i = 0; i < mcList.Count; i++)
            {
                if (id == mcList[i].id)
                {
                    mcList[i].optionD = opD;
                }//End I:*

            }//End F:*
        }//End M:*

        public void UpdateAnswer(int id, string ans)
        {
            for (int i = 0; i < mcList.Count; i++)
            {
                if (id == mcList[i].id)
                {
                    mcList[i].answer = ans;
                }//End I:*

            }//End F:*
        }//End M:*

        public void UpdateQuestion(int id, string quest)
        {
            for (int i = 0; i < mcList.Count; i++)
            {
                if (id == mcList[i].id)
                {
                    mcList[i].question = quest;
                }//End I:*

            }//End F:*
        }//End M:*

        public void Delete(int id) {
            int counter = 0;
            for (int i = 0; i < mcList.Count; i++)
            {
                if (id == mcList[i].id)
                {
                    counter = i;
                    break;
                }//End I:*

            }//End F:*

            List<MultipleChoices> newMCList = new List<MultipleChoices>();

            for (int i = 0; i < counter; i++)
            {
                newMCList[i] = mcList[i];
            }//End F:*

            for (int i = counter + 1; i < mcList.Count; i++)
            {
                newMCList[counter] = mcList[i];
                counter++;
            }//End F:*

            this.mcList = newMCList;
        }//End M:*

    }//End CL:*
