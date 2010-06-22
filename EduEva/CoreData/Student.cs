namespace EduEva.CoreData
{
    public class Student
    {
        public ClassRoom Class { get; set;}
        public string Name { get; set; }
        public Age Age { get; set; }
        public string Note { get; set; }
    
        public Student()
        {
            Age = new Age();
            Class = new ClassRoom();
        }

        public string SaveStudent()
        {
            return "°" + Name + "|" + Age.CurrentAge + "|" +
                Age.DateOfBirth.ToShortDateString() + "|" +
                Class.Grade + "|" + Note;
        }
    }
}
