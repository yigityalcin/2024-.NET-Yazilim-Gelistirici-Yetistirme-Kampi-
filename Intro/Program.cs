using Intro.Business;
using Intro.Entities;


CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();
for (int i = 0;i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}
courseManager.GetAll();

BaseCustomer[] customers = {}
