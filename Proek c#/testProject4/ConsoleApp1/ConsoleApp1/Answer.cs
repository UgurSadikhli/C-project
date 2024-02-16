namespace User_L

{
    public class Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public Answer()
        {

        }
        public Answer(string text, bool isCorecct)
        {
            Text = text;
            IsCorrect = isCorecct;
        }
        public override string ToString()
        {
            return $"{Text}";
        }

    }
}
