using StudentProfileWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentProfileWebApi.Repositories
{

    public class GetStudent {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Student_Profile;Integrated Security=true");

        public DataSet GetRecordbyID(string id) {
            var query = "Select * from Student_Profile where Student_ID = @Student_ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Student_ID", id);
            SqlDataAdapter da = new SqlDataAdapter(command);
            var query2 = "Select * from Employment_Records where Student_ID = @Student_ID";
            SqlCommand command2 = new SqlCommand(query2, connection);
            command2.Parameters.AddWithValue("@Student_ID", id);
            SqlDataAdapter da2 = new SqlDataAdapter(command2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            da2.Fill(ds);
            return ds;
        }

        public DataSet GetERecordbyID(string id)
        {
            var query = "Select * from Employment_Records where Student_ID = @Student_ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Student_ID", id);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }




    }
    public class StudentRepository
    {
        public static bool AddToDB(Student student)
        {
            var connectionString = "Data Source=.;Initial Catalog=Student_Profile;Integrated Security=true";
            var query = "INSERT INTO Student_Profile (Student_ID,First_Name,Middle_Name,Last_Name,Birth_Date ,Gender,Height,Weight ,Blood_Type,Contact_Number,Email,Facebook_Twitter,LearnerRefNo,Entry_Period,Date_Enrolled,Date_Started,Exam_Result,Sponsor,Present_Address,PMunicipality ,PZipCode ,HomeAddress ,HMunicipality,HZipCode ,FathersName,FContactNo ,FOccupation,MothersName ,MContactNo ,MOccupation,GuardiansName ,GContactNo) VALUES" +
                "('@Student_ID','@First_Name','@Middle_Name','@Last_Name','@Birth_Date' ,'@Gender','@Height','@Weight' ,'@Blood_Type','@Contact_Number','@Email','@Facebook_Twitter','@LearnerRefNo'" +
                ",'@Entry_Period','@Date_Enrolled','@Date_Started','@Exam_Result','@Sponsor','@Present_Address','@PMunicipality' ,'@PZipCode' ,'@HomeAddress' ,'@HMunicipality','@HZipCode' ,'@FathersName','@FContactNo' ,'@FOccupation','@MothersName' ,'@MContactNo' ,'@MOccupation','@GuardiansName' ,'@GContactNo')";

            var query2 = "INSERT INTO Employment_Records (Student_ID,Company,FromCompany,ToCompany,Position) VALUES" +
                "('@Student_ID','@Company','@FromCompany','@ToCompany','@Position')";

            query2 = query2.Replace("@Student_ID", student.Student_ID)
                         .Replace("@Company", student.Company)
                         .Replace("@FromCompany", student.FromCompany)
                         .Replace("@ToCompany", student.ToCompany)
                         .Replace("@Position", student.Position);

            query = query.Replace("@Student_ID", student.Student_ID)
                         .Replace("@First_Name", student.First_Name)
                         .Replace("@Middle_Name", student.Middle_Name)
                         .Replace("@Last_Name", student.Last_Name)
                         .Replace("@Birth_Date", student.Birth_Date)
                         .Replace("@Gender", student.Gender)
                         .Replace("@Height", student.Height)
                         .Replace("@Weight", student.Weight)
                         .Replace("@Blood_Type", student.Blood_Type)
                         .Replace("@Contact_Number", student.Contact_Number)
                         .Replace("@Email", student.Email)
                         .Replace("@Facebook_Twitter", student.Facebook_Twitter)
                         .Replace("@LearnerRefNo", student.LearnerRefNo)
                         .Replace("@Entry_Period", student.Entry_Period)
                         .Replace("@Date_Enrolled", student.Date_Enrolled)
                         .Replace("@Date_Started", student.Date_Started)
                         .Replace("@Exam_Result", student.Exam_Result)
                         .Replace("@Sponsor", student.Sponsor)
                         .Replace("@Present_Address", student.Present_Address)
                         .Replace("@PMunicipality", student.PMunicipality)
                         .Replace("@PZipCode", student.PZipCode)
            .Replace("@HomeAddress", student.HomeAddress)
                         .Replace("@HMunicipality", student.HMunicipality)
                         .Replace("@HZipCode", student.HZipCode)
            .Replace("@FathersName", student.FathersName)
                         .Replace("@FContactNo", student.FContactNo)
                         .Replace("@FOccupation", student.FOccupation)
            .Replace("@MothersName", student.MothersName)
                         .Replace("@MContactNo", student.MContactNo)
                         .Replace("@MOccupation", student.MOccupation)
            .Replace("@GuardiansName", student.GuardiansName)
                         .Replace("@GContactNo", student.GContactNo);



            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlCommand command2 = new SqlCommand(query2, connection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command.Dispose();
                command2.Dispose();
                connection.Close();
                return true;
            }
            catch
            {
                //throw;
                return false;
            }



        }

        public static bool UpdateToDB(Student student)
        {
            var connectionString = "Data Source=.;Initial Catalog=Student_Profile;Integrated Security=true";
            var query = "Update Student_Profile set First_Name ='@First_Name',Middle_Name='@Middle_Name',Last_Name ='@Last_Name',Birth_Date = '@Birth_Date' ,Gender= '@Gender',Height = '@Height' ,Weight = '@Weight' , "+
"Blood_Type = '@Blood_Type',Contact_Number = '@Contact_Number',Email = '@Email',Facebook_Twitter = '@Facebook_Twitter',LearnerRefNo = '@LearnerRefNo',"+
"Entry_Period = '@Entry_Period',Date_Enrolled = '@Date_Enrolled',Date_Started = '@Date_Started',Exam_Result = '@Exam_Result',Sponsor = '@Sponsor',"+
"Present_Address = '@Present_Address',PMunicipality = '@PMunicipality' ,PZipCode = '@PZipCode' ,HomeAddress = '@HomeAddress' ,HMunicipality = '@HMunicipality',"+
"HZipCode = '@HZipCode' ,FathersName = '@FathersName',FContactNo = '@FContactNo'  ,FOccupation = '@FOccupation',MothersName = '@MothersName'"+
" ,MContactNo = '@MContactNo' ,MOccupation = '@MOccupation',GuardiansName = '@GuardiansName',GContactNo = '@GContactNo' WHERE Student_ID = '@Student_ID'; ";

            var query2 = "Update Employment_Records set Company= '@Company',FromCompany = '@FromCompany' ,ToCompany= '@ToCompany',Position = '@Position'" +
               "WHERE Student_ID = '@Student_ID'; ";

            query2 = query2.Replace("@Student_ID", student.Student_ID)
                         .Replace("@Company", student.Company)
                         .Replace("@FromCompany", student.FromCompany)
                         .Replace("@ToCompany", student.ToCompany)
                         .Replace("@Position", student.Position);

            query = query.Replace("@Student_ID", student.Student_ID)
                         .Replace("@First_Name", student.First_Name)
                         .Replace("@Middle_Name", student.Middle_Name)
                         .Replace("@Last_Name", student.Last_Name)
                         .Replace("@Birth_Date", student.Birth_Date)
                         .Replace("@Gender", student.Gender)
                         .Replace("@Height", student.Height)
                         .Replace("@Weight", student.Weight)
                         .Replace("@Blood_Type", student.Blood_Type)
                         .Replace("@Contact_Number", student.Contact_Number)
                         .Replace("@Email", student.Email)
                         .Replace("@Facebook_Twitter", student.Facebook_Twitter)
                         .Replace("@LearnerRefNo", student.LearnerRefNo)
                         .Replace("@Entry_Period", student.Entry_Period)
                         .Replace("@Date_Enrolled", student.Date_Enrolled)
                         .Replace("@Date_Started", student.Date_Started)
                         .Replace("@Exam_Result", student.Exam_Result)
                         .Replace("@Sponsor", student.Sponsor)
                         .Replace("@Present_Address", student.Present_Address)
                         .Replace("@PMunicipality", student.PMunicipality)
                         .Replace("@PZipCode", student.PZipCode)
            .Replace("@HomeAddress", student.HomeAddress)
                         .Replace("@HMunicipality", student.HMunicipality)
                         .Replace("@HZipCode", student.HZipCode)
            .Replace("@FathersName", student.FathersName)
                         .Replace("@FContactNo", student.FContactNo)
                         .Replace("@FOccupation", student.FOccupation)
            .Replace("@MothersName", student.MothersName)
                         .Replace("@MContactNo", student.MContactNo)
                         .Replace("@MOccupation", student.MOccupation)
            .Replace("@GuardiansName", student.GuardiansName)
                         .Replace("@GContactNo", student.GContactNo);



            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlCommand command2 = new SqlCommand(query2, connection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command.Dispose();
                command2.Dispose();
                connection.Close();
                return true;
            }
            catch
            {
                //throw;
                return false;
            }



        }

        public static bool DeleteToDB(Student student)
        {
            var connectionString = "Data Source=.;Initial Catalog=Student_Profile;Integrated Security=true";
            var query = "DELETE FROM Student_Profile WHERE Student_ID = '@Student_ID';";
            var query2 = "DELETE FROM Employment_Records WHERE Student_ID = '@Student_ID';";

            query = query.Replace("@Student_ID", student.Student_ID);
            query2 = query2.Replace("@Student_ID", student.Student_ID);


            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlCommand command2 = new SqlCommand(query2, connection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command.Dispose();
                command2.Dispose();
                connection.Close();
                return true;
            }
            catch
            {
                //throw;
                return false;
            }



        }
    }
}