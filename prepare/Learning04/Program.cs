using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment myAssignment = new Assignment();
        myAssignment.SetStudentName("Carlos Poma");
        myAssignment.SetTopic("Multiplication");
        Console.WriteLine(myAssignment.GetSummary()); 
        

        MathAssignment myMathAssignment = new MathAssignment();

        myMathAssignment.SetStudentName("Roberto Rodriguez");
        myMathAssignment.SetTopic("Fractions");
        myMathAssignment.SetTextbookSection("Section 7.3");
        myMathAssignment.SetTextProblems("Problems 8-19");


        Console.WriteLine(myMathAssignment.GetHomeworkList());


        WritingAssigment myWritingAssignment = new WritingAssigment();

        myWritingAssignment.SetStudentName("Mary Waters ");
        myWritingAssignment.SetTopic("European History");
        myWritingAssignment.SetTitle("The Causes of World War II");
        
        Console.WriteLine(myWritingAssignment.GetWritingInformation());



    }
}