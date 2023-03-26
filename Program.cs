/*GPA Calculator*/
/*Collect Student name*/


Console.WriteLine("Input student name");
string studentName = Console.ReadLine();
Console.WriteLine("========================================================================================================================");


Console.WriteLine("Input your course name");
string course1Name = Console.ReadLine();

Console.WriteLine("Input the next course name");
string course2Name = Console.ReadLine();

Console.WriteLine("Input the next course name");
string course3Name = Console.ReadLine();

Console.WriteLine("Input the next course name");
string course4Name = Console.ReadLine();

Console.WriteLine("Input the last course name");
string course5Name = Console.ReadLine();

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

// Create variables to store the average
int totalCreditHours = 0;
// Increment the sum
// totalCreditHours += course1Credit;
// totalCreditHours += course2Credit;
// totalCreditHours += course3Credit;
// totalCreditHours += course4Credit;
// totalCreditHours += course5Credit;

// Short hand for the above
totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

int totalGradePoints = 0;

totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

int leadingDigit = (int)gradePointAverage;

int trailingDigits = (int)(gradePointAverage * 100) - (leadingDigit * 100);


Console.WriteLine($"Student: {studentName}\n");

Console.WriteLine("Course Name\t\t" + "Grade\t\t" + "Credit Hours");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine($"{course1Name}\t\t {course1Grade}\t\t {course1Credit}");
Console.WriteLine($"{course2Name}\t\t {course2Grade}\t\t {course2Credit}");
Console.WriteLine($"{course3Name}\t\t {course3Grade}\t\t {course3Credit}");
Console.WriteLine($"{course4Name}\t {course4Grade}\t\t {course4Credit}");
Console.WriteLine($"{course5Name}\t\t {course5Grade}\t\t {course5Credit}");

Console.WriteLine("-----------------------------------------------------");

Console.WriteLine($"Final GPA:\t\t{leadingDigit}.{trailingDigits}");

Console.ReadKey();
