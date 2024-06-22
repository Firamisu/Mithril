namespace Mithril.Models
{
    public class ExerciseRecorder
    {
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Repetitions { get; set; }

        public ExerciseRecorder(int exerciseId, string exerciseName)
        {
            ExerciseId = exerciseId;
            ExerciseName = exerciseName;
        }

        public void StartRecording()
        {
            StartTime = DateTime.Now;
        }

        public void StopRecording()
        {
            EndTime = DateTime.Now;
        }

        public TimeSpan GetDuration()
        {
            return EndTime - StartTime;
        }
    }
}
