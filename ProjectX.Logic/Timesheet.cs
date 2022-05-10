using System;
namespace ProjectX.Logic
{
    //табель успеваемости/посещений
    internal class Timesheet
    {
        //лекция
        public int LectureLectureID { get; set; }
        public Lecture Lecture { get; set; }

        //студент
        public int StudentStudentID { get; set; }
        public bool IsOnLecture { get; set; }
        public Student Student { get; set; }

        //дз
        public int HomeworkID { get; set; }
        public bool DoTask { get; set; }
        public Homework homeWork { get; set; }

        //оценка
        public short? Grade { get; set; }

        
        
    }
}
