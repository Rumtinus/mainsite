using CourseRegistration.Common;
using mainsite;
using mainsite.Common;
using mainsite.Models;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class Lessons : Table 
    {
        public int? LessonID { get; set; }
        public string Lesson { get; set; }

        public List<Lessons> all()
        {
            _database.connect();
            string q = "SELECT * from [Lessons]";
            SqlDataReader reader = _database.QueryResult(q);
            List<Lessons> lessons = new List<Lessons>();
            while (reader.Read())
            {
                Lessons temp = new Lessons();
                temp.LessonID = int.Parse(reader["LessonID"].ToString());
                temp.Lesson = reader["Lesson"].ToString();
                lessons.Add(temp);
            }
            _database.disConnect();
            return lessons;
        }

        public void get(int id)
        {
            _database.connect();
            string q = string.Format("SELECT * from [Lessons] where LessonID={0}", id);
            SqlDataReader reader = _database.QueryResult(q);
            if (reader != null)
            {
                reader.Read();
                this.LessonID = int.Parse(reader["LessonID"].ToString());
                this.Lesson = reader["Lesson"].ToString();
            }


            _database.disConnect();
        }

        public void save()
        {
            _database.connect();
            string q;
            if (this.LessonID == null)
            {
                q = string.Format("INSERT into [Lessons] (Lesson) values(N'{0}')", this.Lesson);
            }
            else
            {
                q = string.Format("UPDATE Lessons set Lesson=N'{0}' where LessonID={1}", this.Lesson, this.LessonID);
            }
            _database.QueryNonResult(q);
            _database.disConnect();
        }

        public void delete()
        {
            _database.connect();
            string q = string.Format("DELETE from Lessons where LessonID={0}", this.LessonID);
            _database.QueryNonResult(q);
            _database.disConnect();
        }
        public bool hasStudentsRegistrations()
        {
            _database.connect();
            string q = string.Format("SELECT * from [Students_Registrations] where LessonsID={0}", this.LessonID);
            SqlDataReader reader = _database.QueryResult(q);

            if (reader.HasRows == true)
            {
                _database.disConnect();
                return true;

            }
            _database.disConnect();
            return false;
            

        }
        public bool CheckLesson()
        {
            _database.connect();
            string q = string.Format("SELECT * from [Lessons] where Lesson=N'{0}' and LessonID!={1}", this.Lesson,this.LessonID??0);
            SqlDataReader reader = _database.QueryResult(q);
            bool a = reader.Read();
            if (reader.HasRows == true)
            {
                _database.disConnect();
                return true;

            }
            _database.disConnect();
            return false;
            

        }
    }
}
