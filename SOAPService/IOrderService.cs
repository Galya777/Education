using EducationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPService
{
    interface IOrderService
    {
        IEnumerable<Course> GetCourses();
        void Write2File(string sender, Course course);
    }
}
