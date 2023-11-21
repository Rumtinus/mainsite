using CourseRegistration.Common;
using CourseRegistration.Models;
using mainsite.Common;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainsite.Models
{
    public class Students : Table
    {

        public int? StudentID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int StudentNumber { get; set; }


        public List<Students> all()
        {
            _database.connect();
            string q = "SELECT * from [Students]";
            List<Students> students = new List<Students>();

            SqlDataReader dread = _database.QueryResult(q);
            while (dread.Read())
            {
                Students temp = new Students();
                temp.StudentID = int.Parse(dread["StudentID"].ToString());
                temp.Firstname = dread["Firstname"].ToString();
                temp.Lastname = dread["Lastname"].ToString();
                temp.StudentNumber = int.Parse(dread["StudentNumber"].ToString());
                students.Add(temp);
            }
            _database.disConnect();
            return students;
        }


        public void get(int id)
        {
            _database.connect();
            string q = string.Format("SELECT * from [Students] where StudentId={0}", id);
            SqlDataReader dread = _database.QueryResult(q);
            if (dread != null)
            {
                dread.Read();
                this.StudentID = int.Parse(dread["StudentID"].ToString());
                this.Firstname = dread["Firstname"].ToString();
                this.Lastname = dread["Lastname"].ToString();
                this.StudentNumber = int.Parse(dread["StudentNumber"].ToString());
            }


            _database.disConnect();
        }


        public void save()
        {
            _database.connect();
            string q;
            if (StudentID == null)
            {
                q = string.Format("INSERT into Students (Firstname, Lastname, StudentNumber) values (N'{0}',N'{1}',{2})  ",this.Firstname,this.Lastname,this.StudentNumber );
            }
            else
            {
                q = string.Format("UPDATE Students set Firstname=N'{0}',Lastname_N'{1}',StudentNumber={2} where StudentID={3}", this.Firstname, this.Lastname, this.StudentNumber,this.StudentID);
            }
            _database.QueryNonResult(q);
            _database.disConnect();
        }
        public void delete()
        {
            _database.connect();
            string q = string.Format("DELETE from Students where StudentID={0}", this.StudentID);
            _database.QueryNonResult(q);
            _database.disConnect();
        }
        public bool hasStudentsRegistrations()
        {
            _database.connect();
            string q = string.Format("SELECT * from [Students_Registrations] where StudentsID={0}", this.StudentID);
            SqlDataReader reader = _database.QueryResult(q);
            if (reader.HasRows == true)
            {
                _database.disConnect();
                return true;

            }
            _database.disConnect();
            return false;

        }

        public bool CheckStudent()
        {
            _database.connect();
            string q = string.Format("SELECT * from Students where StudentID!={0} and Firstname=N'{1}' and Lastname=N'{2}' and StudentNumber={3} ", this.StudentID ?? 0,this.Firstname,this.Lastname,this.StudentNumber);
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
