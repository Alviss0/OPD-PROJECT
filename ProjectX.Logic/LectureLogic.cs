using System;
using ProjectX.DAL.Entities;
using ProjectX.DAL.Repositories;
using ProjectX.Logic.Exceptions;


namespace ProjectX.ProjectX.Logic
{
    public class LectureLogic
    {
        public static class Lecturelogic {

            public static string GetInfo(this Lecture lecture)
            {
                string result = "";
                if (lecture == null)
                    throw new LectureNotFoundException("{ \"The requested Lecture was null.\" }");
                result += $"\"Lecture_{lecture.LectureID}\" : ";
                result += lecture.Teacher.GetInfo();
            }
        }

            
        
    }
}
