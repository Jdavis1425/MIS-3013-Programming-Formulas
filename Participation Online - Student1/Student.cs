//Jatin Davis
using System;

class Student
{
	public string FirstName { get; set; }

	public string LastName { get; set; }

	public List<string> CourseName { get; set; }

	public List<string> CourseGrade { get; set; }

	public Student()
    {
		FirstName = "";
		LastName = "";
		List<string> CourseName = new List<string>();
		List<string> CourseGrade = new List<string>();
		//CourseName.Add("MIS-3013");
		//CourseName.Add("MIS-3313");
		//CourseName.Add("MIS-3433");
		//CourseGrade.Add("A");
		//CourseGrade.Add("B");
		//CourseGrade.Add("C");
    }
	public Student(string first, string second)
    {
		first = FirstName;
		second = LastName;
		

    }
	public double CalculateGPA()
    {
		double totalPoints = 0;
		double points = 0;
		foreach (var item in CourseGrade)
        {
            if (CourseGrade == "A")
            {
				points = 4 * 3;
            }
            else if (CourseGrade == "B")
            {
				points = 3 * 3;
            }
            else if (CourseGrade == "C")
            {
				points = 2 * 3;
            }
            else if (CourseGrade == "D")
            {
				points = 1 * 3;
            }
            else
            {
				points = 0;
            }
			totalPoints += points;
        }
		return totalPoints / CourseGrade.Count;
		


    }

}
