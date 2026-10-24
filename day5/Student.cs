namespace EFCoreTutorialsConsole
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        // Khóa ngoại liên kết tới Grade
        public int GradeId { get; set; }
        public Grade? Grade { get; set; }
    }
}