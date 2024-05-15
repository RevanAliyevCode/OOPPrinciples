using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Subject
    {
        public string Title { get; set; }
        public int Hour { get; set; }

        public Subject(string title, int hour)
        {
            Title = title;
            Hour = hour;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Subject Title: {Title}, Subject Hour: {Hour}");
        }
    }
}
