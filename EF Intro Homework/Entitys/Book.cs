using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Intro_Homework.Entitys
{
    public class Book:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public ICollection<StudentBook> StudentsBooks { get; set; }


        // foreign keys
        public int BookTypeId { get; set; }
        public int AuthorId { get; set; }

    }
}
