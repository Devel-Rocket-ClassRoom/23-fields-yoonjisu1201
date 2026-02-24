using System;

// README.md를 읽고 아래에 코드를 작성하세요.
ClassroomManager class1 = new ClassroomManager("1반");
class1.AddStudent("홍길동");
class1.AddStudent("김철수");
class1.AddStudent("이영희");
class1.ShowStudents();
Console.WriteLine();

ClassroomManager class2 = new ClassroomManager("2반");
class2.AddStudent("박민수");
class2.AddStudent("정수진");
class2.ShowStudents();
Console.WriteLine();

ClassroomManager.ShowTotalClassrooms();
class ClassroomManager
{
    public const int maxStudents = 5;
    public readonly string classname;
    private string[] studentsName;
    private int studentsCount = 0;
    private static int totalClassCount;

    public ClassroomManager(string name)
    {
        classname = name;
        studentsName = new string[maxStudents];
        totalClassCount++;
    }

    public void AddStudent(string name)
    {
        if (studentsCount >= maxStudents)
        {
            return;
        }
        studentsName[studentsCount++] = name;
         
    }

    public void ShowStudents()
    {
        Console.WriteLine($"=== {classname} 학생 목록 ({studentsCount}/{maxStudents}) ===");
        for (int i = 0; i < studentsCount; i++)
        {
            Console.WriteLine($"{i}. {studentsName[i]} ");
        }
    }

    public static void ShowTotalClassrooms()
    {
        Console.WriteLine("전체 교실 수: " + totalClassCount);
    }
}
