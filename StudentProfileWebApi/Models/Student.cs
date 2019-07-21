using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentProfileWebApi.Models
{
    public class Student
    {
        public string Student_ID { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Birth_Date { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Blood_Type { get; set; }
        public string Contact_Number { get; set; }
        public string Email { get; set; }
        public string Facebook_Twitter { get; set; }
        public string LearnerRefNo { get; set; }
        public string Entry_Period { get; set; }
        public string Date_Enrolled { get; set; }
        public string Date_Started { get; set; }
        public string Exam_Result { get; set; }
        public string Sponsor { get; set; }
        public string Present_Address { get; set; }
        public string PMunicipality { get; set; }
        public string PZipCode { get; set; }
        public string HomeAddress { get; set; }
        public string HMunicipality { get; set; }
        public string HZipCode { get; set; }
        public string FathersName { get; set; }
        public string FContactNo { get; set; }
        public string FOccupation { get; set; }
        public string MothersName { get; set; }
        public string MContactNo { get; set; }
        public string MOccupation { get; set; }
        public string GuardiansName { get; set; }
        public string GContactNo { get; set; }
        public string Company { get; set; }
        public string FromCompany { get; set; }
        public string ToCompany  { get; set; }
        public string Position { get; set; }

    }
}