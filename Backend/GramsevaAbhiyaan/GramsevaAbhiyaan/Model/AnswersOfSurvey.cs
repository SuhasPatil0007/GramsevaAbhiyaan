namespace GramsevaAbhiyaan.Model
{
    public class AnswersOfSurvey
    {
        public int Id { get; set; }
        public int SarveyFormId { get; set; }
        public SarveyForm SarveyForm { get; set; }
        public string Answer { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
