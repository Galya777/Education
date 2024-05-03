using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationServices
{
    public class Course
    {
       public static string ID;
       const int MAX_NUMBER_IN_COURSE=10;

        ServiceType serviceType;
        string title;
        int numOfStudents;

       public Course(ServiceType serviceType, string title,  int numOfStudents)
        {
            Random num = new Random();
            num.Next(1000, 9999);
            ID += num;
            ID+='_';
            ID += "2022";
            this.title = title;
            this.serviceType = serviceType;
            this.numOfStudents = numOfStudents;
        }

       public Course(Course other)
        {
            title = other.title;
            serviceType = other.serviceType;
            numOfStudents = other.numOfStudents;
        }

        public ServiceType ServiceType { get {return serviceType; } set {serviceType=value; } }
        public string Title { get { return title; } set { title = value; } }
        public int NumOfStudents { get { return numOfStudents; } set { numOfStudents = value < 10 ? value : 0; } }

       
           public override string ToString()
        {
            return string.Format("%s, %s, %s, $d", ID, title, serviceType, numOfStudents);
        }
    }
}
