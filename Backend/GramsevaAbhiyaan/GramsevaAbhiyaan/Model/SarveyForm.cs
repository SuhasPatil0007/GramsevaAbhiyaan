namespace GramsevaAbhiyaan.Model
{
    public class SarveyForm
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string QuestionType { get; set; } // e.g., "text", "multiple-choice"
    }
}
