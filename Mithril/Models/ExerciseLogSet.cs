namespace Mithril.Models
{
    public class ExerciseLogSet
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }

        // Navigation property
        public ICollection<ExerciseLog> ExerciseLogs { get; set; }
    }
}
