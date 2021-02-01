using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task6.DTOs;
using task6.Models;

namespace task6.Services
{
    public interface IStudentsDbService
    {
        Student EnrollStudent(Student student);
        Enrollment PromoteStudent(Enrollment enrollment);
        bool validationCredential(string login, string password);

        void assignRefreshToken(string login, Guid rtoken);

        bool checkrefreshToken(string token);

        void updateRefreshToken(string oldtoken, Guid newtoken);
        object EnrollStudent(EnrollStudentRequest request);
        object PromoteStudents(PromoteStudentsRequest request);
    }
}