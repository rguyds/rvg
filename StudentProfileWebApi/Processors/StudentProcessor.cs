using StudentProfileWebApi.Models;
using StudentProfileWebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentProfileWebApi.Processors
{
    public class StudentProcessor
    {
        public static bool ProcessStudent(Student student) {

            return StudentRepository.AddToDB(student);


        }

        public static bool ProcessUpdateStudent(Student student)
        {

            return StudentRepository.UpdateToDB(student);


        }
        public static bool ProcessDeleteStudent(Student student)
        {

            return StudentRepository.DeleteToDB(student);


        }

    }
}