using CourseRegistration.Common;
using mainsite.Common;
using mainsite.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class ShowStudentsRegistrationsData
    {
        public int Id { get; set; }
        public string Lessons { get; set; }
        public int Terms { get; set; }
        public string Students { get; set; }

    }

    public class StudentsRegistrations : Table
    {
        public int? ID { get; set; }
        public int LessonsID { get; set; }
        public int TermsID { get; set; }
        public int StudentsID { get; set; }
        public DateTime CreateAt { get; set; }
        public Students student { get; set; }
        public Terms term { get; set; }
        public Lessons lesson { get; set; }




        public List<StudentsRegistrations> all()
        {
            _database.connect();
            string q = "SELECT * from [Students_Registrations]";
            SqlDataReader reader = _database.QueryResult(q);
            List<StudentsRegistrations> studentsRegistrations = new List<StudentsRegistrations>();
            while (reader.Read())
            {
                StudentsRegistrations temp = new StudentsRegistrations();
                temp.ID = int.Parse(reader["ID"].ToString());
                temp.LessonsID = int.Parse(reader["LessonsID"].ToString());
                temp.TermsID = int.Parse(reader["TermsID"].ToString());
                temp.StudentsID = int.Parse(reader["StudentsID"].ToString());
                temp.CreateAt = DateTime.Parse(reader["CreateAt"].ToString());
                temp.getLesson();
                temp.getTerm();
                temp.getStudent();
                studentsRegistrations.Add(temp);
                
            }
            _database.disConnect();
            return studentsRegistrations;
        }
        public void get(int id)
        {
            _database.connect();
            string q =string.Format( "SELECT * from [Students_Registrations] where id={0}",id);
            SqlDataReader reader = _database.QueryResult(q);
            if (reader!=null)
            {
                reader.Read(); 
                this.ID = int.Parse(reader["ID"].ToString());
                this.LessonsID = int.Parse(reader["LessonsID"].ToString());
                this.TermsID = int.Parse(reader["TermsID"].ToString());
                this.StudentsID = int.Parse(reader["StudentsID"].ToString());
                this.CreateAt = DateTime.Parse(reader["CreateAt"].ToString());
                this.getLesson();
                this.getTerm();
                this.getStudent();
            }
            _database.disConnect();
        }

        public void save()
        {
            _database.connect();
            string q;
            if (ID == null)
            {
                q = string.Format("INSERT into Students_registrations (LessonsID, TermsID, StudentsID, CreateAt) values ({0},{1},{2},'{3}')  ", this.LessonsID, this.TermsID, this.StudentsID, this.CreateAt.ToString());
            }
            else
            {
                q = string.Format("UPDATE Students_registrations set LessonsID={0},TermsID={1},StudentsID={2},CreateAt='{3}' where ID={4}", this.LessonsID, this.TermsID, this.StudentsID, this.CreateAt.ToString(), this.ID);
            }
            _database.QueryNonResult(q);
            _database.disConnect();
        }




        public void delete()
        {
            _database.connect();
            string q = string.Format("DELETE from Students_registrations where ID={0}", this.ID);
            _database.QueryNonResult(q);
            _database.disConnect();
        }

        public void getStudent()
        {
            this.student=new Students();
            this.student.get(this.StudentsID);
        }
        
        public void getLesson()
        {
            this.lesson=new Lessons();
            this.lesson.get(this.LessonsID);
        }
        
        public void getTerm()
        {
            this.term=new Terms();
            this.term.get(this.TermsID);
        }



    }
}
