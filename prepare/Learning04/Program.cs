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
        
        Console.WriteLine("++++++++++++++++++++");

        MathAssignment myMathAssignment = new MathAssignment();

        myMathAssignment.SetStudentName("Roberto Rodriguez");
        myMathAssignment.SetTopic("Fractions");
        myMathAssignment.SetTextbookSection("7.3");
        myMathAssignment.SetTextProblems("8-19");

        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());

        Console.WriteLine("++++++++++++++++++++");

        WritingAssigment myWritingAssignment = new WritingAssigment();

        myWritingAssignment.SetStudentName("Mary Waters ");
        myWritingAssignment.SetTopic("European History");
        myWritingAssignment.SetTitle("The Causes of World War II");
        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingInformation());



    }
}