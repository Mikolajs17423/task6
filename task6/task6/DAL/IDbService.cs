using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task6.Models;

namespace task6.DAL
{
    public class IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
