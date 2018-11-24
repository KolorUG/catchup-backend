namespace CatchUp.Models.Roles
{
    public class User : BaseEntity
    {
        public string Login { get; set;}
        public string Password { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}