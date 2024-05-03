using EducationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPService
{
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class OrderService : IOrderService
    {
        Dictionary<string, Course> courses;
        List<string> titles;

        public OrderService()
        {
            Random Ncourses = new Random();
            Random Ntitles = new Random();
            Ntitles.Next(6, 12);
            titles.Add( "Title No. "+ Ntitles.ToString());
            Ncourses.Next(6, 20);
            ServiceType type = (ServiceType)Ncourses.Next(0, 5);
            Course course = new Course(type, titles.ElementAt(Ntitles.Next(0, titles.Count)), Ncourses.Next(6, 20));
            courses.Add(titles.ElementAt(Ntitles.Next(0, titles.Count)), course);
        }
        public IEnumerable<Course> GetCourses()
        {
            yield return titles;
        }

        public void Write2File(string sender, Course course)
        {
            throw new NotImplementedException();
        }
    }
}
