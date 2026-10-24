using System.Collections.Generic;

namespace EFCoreTutorialsConsole
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; } = string.Empty;

        // Quan hệ 1 - N: Một lớp có nhiều học sinh
        public IList<Student> Students { get; set; } = new List<Student>();
    }
}