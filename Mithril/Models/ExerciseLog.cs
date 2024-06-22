namespace Mithril.Models
{
    public class ExerciseLog
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public int ExerciseLogSetId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public int Reps { get; set; }

        // Navigation properties
        public Exercise Exercise { get; set; }
        public ExerciseLogSet ExerciseLogSet { get; set; }
    }
}
