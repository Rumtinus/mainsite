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
    public class Terms: Table
    {

        public int? TermID { get; set; }
        public int Term { get; set; }

        public List<Terms> all()
        {
            _database.connect();
            string q = "SELECT * from [Terms]";
            SqlDataReader reader = _database.QueryResult(q);
            List<Terms> Terms = new List<Terms>();
            while (reader.Read())
            {
                Terms temp = new Terms();
                temp.TermID = int.Parse(reader["TermID"].ToString());
                temp.Term = int.Parse(reader["Term"].ToString());
                Terms.Add(temp);
            }
            _database.disConnect();
            return Terms;
        }

        public void get(int id)
        {
            _database.connect();
            string q = string.Format("SELECT * from [Terms] where TermID={0}", id);
            SqlDataReader reader = _database.QueryResult(q);
            if (reader != null)
            {
                reader.Read();
                this.TermID = int.Parse(reader["TermID"].ToString());
                this.Term = int.Parse(reader["Term"].ToString());
            }


            _database.disConnect();
        }

        public void save()
        {
            _database.connect();
            string q;
            if (this.TermID == null)
            {
                q = string.Format("INSERT into [Terms] (Term) values({0})", this.Term);
            }
            else
            {
                q = string.Format("UPDATE Terms set Term=N'{0}' where TermID={1}", this.Term, this.TermID);
            }
            _database.QueryNonResult(q);
            _database.disConnect();
        }

        public void delete()
        {
            _database.connect();
            string q = string.Format("DELETE from Terms where TermID={0}", this.TermID);
            _database.QueryNonResult(q);
            _database.disConnect();
        }
        public bool hasStudentsRegistrations()
        {
            _database.connect();
            string q = string.Format("SELECT * from [Students_Registrations] where TermsID={0}", this.TermID);
            SqlDataReader reader = _database.QueryResult(q);
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
