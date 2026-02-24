using System;
using System.Collections.Generic;
using System.Text;

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
