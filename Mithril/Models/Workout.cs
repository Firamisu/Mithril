namespace Mithril.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public int RestTimeSeconds { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
