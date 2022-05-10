using System;
using ProjectX.DAL.Entities;
using ProjectX.Logic.Exceptions;


namespace ProjectX.Logic
{
    public static class HomeworkLogic
    {
        public static Homework Create(Lecture lecture, Student student, int grade)
        {
            Homework homework = new Homework();
            homework.LectureID = lecture.LectureID;
            homework.Grade = grade;
            homework.StudentID = student.StudentID;
            return homework;
        }
        public static bool MapTo(this Homework source, Homework target)
        {
            if (source != null && target != null)
            {
                target.LectureID = source.LectureID;
                target.StudentID = source.StudentID;
                target.Grade = source.Grade;
                return true;
            }
            return false;
        }
        public static string GetInfo(this Homework homework)
        {
            string result = "";
            if (homework == null || homework.HomeworkID < 0)
            {
                result += "{ \"Homework's is absent (No such).\" }";
                throw new HomeworkNotFoundException(result);
            }
            else
            {
                result += $"{{ \"HomeworkID\": {homework.HomeworkID}, ";
                result += $"\"HomeworkMark\" : {homework.Grade}, ";
                result += $"\"StudentID\" : { homework.StudentID } }}";
            }
            return result;
        }
    }
}
