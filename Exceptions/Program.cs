// --------- Divide By Zero! ----------

 
static double Divide(double x, double y)
{
    // Write your code here!
    if (y == 0.0)
    {
        throw new ArgumentOutOfRangeException("y","Cannot divide by zero!");
        
    }
    return x / y;
}


// Test out your Divide() function here!
try
{ 
 Console.WriteLine(Divide(5.0, 0.0)); 
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message); 
}

// --------- Test Student Labs ----------


static int CheckFileExtension(string fileName)
{
    int studentPoints = 0;
    if (fileName == null || fileName == "")
    { 
        throw new ArgumentNullException(fileName, "waiting for you to turn in your assignment");
    } 
    else if (fileName.EndsWith(".cs"))
    {
        studentPoints++;
    }
       else if (!fileName.EndsWith(".cs"))
    {
        studentPoints = 0;
        }
    return studentPoints;


}


// Test out your CheckFileExtension() function here!

Dictionary<string, string> students = new Dictionary<string, string>();
students.Add("Carl", "Program.cs");
students.Add("Brad", "");
students.Add("Elizabeth", "MyCode.cs");



foreach (KeyValuePair<string, string> student in students)
{
    try
    {
        Console.WriteLine(CheckFileExtension(student.Value));

    }
    catch (ArgumentNullException e)
    {
        Console.WriteLine(e.Message);
    }

}





