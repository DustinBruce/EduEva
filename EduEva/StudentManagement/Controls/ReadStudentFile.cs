using System;
using System.Collections.Generic;
using System.IO;
using EduEva.CoreControl;
using EduEva.CoreData;
using EduEva.Properties;

namespace EduEva.StudentManagement.Controls
{
    public static class ReadStudentFile
    {
        public static List<Student> Students { get; set; }

        private static void ReadStudents()
        {
            Students = new List<Student>();
            var reader = new StreamReader(Resources.SaveFile);
            while(!reader.EndOfStream)
            {
                var currentLine = reader.ReadLine();
                var studentAttributes = currentLine.Split('|');
                Students.Add(new Student
                                 {
                                     Name = studentAttributes[0],
                                     Age = new Age
                                               {
                                                   DateOfBirth = DateTime.Parse(studentAttributes[2]),
                                               },
                                     Class = new ClassRoom
                                                 {
                                                     Grade = studentAttributes[3]
                                                 },
                                     Note = studentAttributes[4]

                                 });
            }
        }

        public static List<DisplayItem> GetDisplayableStudents()
        {
            ReadStudents();

            var items = new List<DisplayItem>();
            Students.ForEach(student => items.Add(new DisplayItem
                                                      {
                                                        Delete = false,
                                                        DateOfBirth = student.Age.DateOfBirth.ToShortDateString(),
                                                        Age = student.Age.CurrentAge.ToString(),
                                                        Name = student.Name,
                                                        Note = student.Note
                                                       }));
            return items;
        }
    }
}
