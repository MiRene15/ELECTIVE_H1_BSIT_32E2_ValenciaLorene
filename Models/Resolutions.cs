namespace ELECTIVE_H1_BSIT_32E2_ValenciaLorene.Models
{
    public class Resolutions
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsDone { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
