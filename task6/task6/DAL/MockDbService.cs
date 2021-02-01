using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task6.Models;

namespace task6.DAL
{
	public class MockDbService : IDbService
	{
		private static IEnumerable<Student> _students;

		static MockDbService()
		{
			_students = new List<Student>
			{
				new Student { idStudent = 1, FirstName = "John", LastName = "Eduardo" },
				new Student { idStudent = 2, FirstName = "Tim", LastName = "Cook" },
		
			};
		}

		public IEnumerable<Student> GetStudents()
		{
			return _students;
		}
	}