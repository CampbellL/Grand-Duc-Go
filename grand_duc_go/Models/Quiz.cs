namespace grand_duc_go.Models
{
    public struct Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public Answer(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }
    }

    public class Quiz
    {
        public bool IsCompleted = false;
        public string CompletionText { get; set; }
        public Answer[] Answers { get; set; }
        public string Question { get; set; }
    }
}