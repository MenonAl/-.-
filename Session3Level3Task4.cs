using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    // Поля.
    string name;
    string surname;
    int age;
    double avengeGrade;
    bool isCabalny;
    public Student(string name, string surname, int age, double averageGrade)
    {
        this.name = name;
        this.surname = surname; 
        this.age = age;
        this.avengeGrade = averageGrade;
        removeFromCabala();
        // место для вашего кода
    }
    public string getNameStudent() { return this.name; }
    public string getSurenameStudent() { return this.surname; }

    public void changeGrade(double newGrade)
    {
        this.avengeGrade = newGrade;
        // место для вашего кода
    }

    public bool addToCabala()
    {
        if (isCabalny == true)
        {
            return false;
        }
        else
        {
            this.isCabalny = true;
            return false;
        }
    }

    public bool removeFromCabala()
    {
        if (isCabalny == false)
        {
            this.isCabalny = false;
            return true;
        }
        else 
        {
            return false; 
        }
    }
}

class Teacher
{
    // Поля.
    string name;
    string surname;
    int age;
    string teachedSubject;
    public Teacher(string name, string surname, int age, string teachedSubject)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.teachedSubject = teachedSubject;
        // место для вашего кода
    }
    public string getNameTeacher() { return name; }
    public string getSurnameTeacher() { return surname; }
    public void changeLesson(string newName)
    {
        this.teachedSubject = newName;
        // место для вашего кода
    }
}

class School
{
    Student[][] classes;
    int[] Class_of_studens;
    int amountOfClasses;
    int amountOfStudents;
    int amountOfTeachers;
    Teacher[] teachers = new Teacher[0];
    Teacher[] classMasters;
    int amountOfMasters;
    string name;
    int[] arraySizes;

    public School(string name, int amountOfClasses, int[] arraySizes)
    {
        this.name = name;
        this.amountOfClasses = amountOfClasses;
        this.arraySizes = arraySizes;
        this.Class_of_studens = new int[this.amountOfClasses];
        for (int i = 0; i < amountOfClasses; ++i) 
        {
            this.Class_of_studens[i] = 0;
        }
        Console.WriteLine(this.Class_of_studens.Length); // 4
        classes = new Student[this.amountOfClasses][];
        for (int i = 0; i < amountOfClasses; ++i) 
        {
            classes[i] = new Student[arraySizes[i]];
        }
        classMasters = new Teacher[this.amountOfClasses];
        teachers = new Teacher[100]; 
        // место для вашего кода
    }

    public bool addStudent(int classNumber, Student addedStudent)
    {

        this.amountOfStudents++;
        Class_of_studens[classNumber-1]++;
        classes[classNumber-1][Class_of_studens[classNumber-1]-1] = addedStudent; //classes - ERROR
        
        // место для вашего кода
        return false;
    }

    public void freeEveryone()
    {
        for (int i = 0; i < amountOfClasses; ++i) 
        {
            for (int j = 0; j < Class_of_studens[i]; ++j) 
            {
                classes[i][j].removeFromCabala();
            }
        }
        //Console.WriteLine("Never");
        // место для вашего кода
    }

    public bool addTeacher(Teacher addedTeacher)
    {
        // место для вашего кода
        if (amountOfTeachers < 101)
        {
            amountOfTeachers++;
            //teachers = new Teacher[amountOfTeachers];
            teachers[amountOfTeachers - 1] = addedTeacher;

            return true;
        }
        else { return false; }
    }

    public bool changeClassMaster(int classIndex, int teacherIndex)
    {
        // место для вашего кода
        if (classMasters[classIndex-1] != null)
        {
            return false;
        }
        else 
        {
            classMasters[classIndex-1] = teachers[teacherIndex];
            return true;
        }
    }

    public void printSchoolStudents()
    {
        for (int i = 0; i < amountOfClasses; ++i)
        {
            for (int j = 0; j < Class_of_studens[i]; ++j)
            {
                Console.Write(classes[i][j].getNameStudent());
                Console.Write(' ');
                Console.Write(classes[i][j].getSurenameStudent());
            }
            Console.WriteLine(" ");
        }
    }

    public void printSchoolTeachers()
    {
        for (int i = 0; i < amountOfTeachers; ++i) 
        {
            Console.Write(teachers[i].getNameTeacher());
            Console.Write(' ');
            Console.Write(teachers[i].getSurnameTeacher());
            Console.Write(' ');
        }
        Console.WriteLine(" ");
        // место для вашего кода
    }

    public void printClassMasters()
    {
        for (int i = 0; i < classMasters.Length; ++i) 
        {
            if (classMasters[i] != null)
            {
                Console.Write(classMasters[i].getNameTeacher());
                Console.Write(' ');
                Console.Write(classMasters[i].getSurnameTeacher());
                Console.Write(" ");
            }
            else 
            {
                Console.WriteLine("null");
            }
        }
        // место для вашего кода
    }
}

class Program
{
    static bool tests0()
    {
        try 
        {
            School CPM = new School("CPM", 5, new int[] { 24,14,7,9,19});
            Student std1 = new Student("Alex", "Alex", 14, 4.1);
            return true; 
        }
        catch { return false; }
    }
    static bool tests1()
    {
        try
        {
            School CPM = new School("CPM", 5, new int[] { 24, 14, 7, 9, 19 });
            Student stud1 = new Student("Alex", "Alex", 14, 4.1);
            Teacher teach = new Teacher("OLEG", "oleg", 25, "physic");
            Student stud2 = new Student("someone","something", 12, 5.0);
            Console.WriteLine(CPM.addStudent(1, stud1));
            Console.WriteLine(CPM.addStudent(4,stud2));
            return true;
        }
        catch { return false; }
    }
    static bool tests2()
    {
        try 
        {
            School CPM = new School("CPM", 5, new int[] { 24, 14, 7, 9, 19 });
            Student stud1 = new Student("Alex", "Alex", 14, 4.1);
            Student stud2 = new Student("someone", "something", 12, 5.0);
            Console.WriteLine(CPM.addStudent(1, stud1));
            Console.WriteLine(CPM.addStudent(4, stud2));
            Student stud3 = new Student("Gena", "Gena", 15, 3.9);
            Console.WriteLine(CPM.addStudent(5, stud3));
            Console.WriteLine(stud3.addToCabala());
            return true;
        }
        catch { return false; }
    }
    static bool tests3()
    {
        try
        {
            School CPM = new School("CPM", 5, new int[] { 24, 14, 7, 9, 19 });
            Student stud1 = new Student("Alex", "Alex", 14, 4.1);
            Student stud2 = new Student("someone", "something", 12, 5.0);
            Console.WriteLine(CPM.addStudent(1, stud1));
            Console.WriteLine(CPM.addStudent(4, stud2));
            Student stud3 = new Student("Gena", "Gena", 15, 3.9);
            Console.WriteLine(CPM.addStudent(5, stud3));
            Console.WriteLine(stud3.addToCabala());
            Console.WriteLine(stud1.addToCabala());
            Console.WriteLine(stud1.addToCabala());
            return true;
        }
        catch { return false; }
    }
    static bool tests4()
    {
        try
        {
            School CPM = new School("CPM", 5, new int[] { 24, 14, 7, 9, 19 });
            Student stud1 = new Student("Alex", "Alex", 14, 4.1);
            Student stud2 = new Student("someone", "something", 12, 5.0);
            Console.WriteLine(CPM.addStudent(1, stud1));
            Console.WriteLine(CPM.addStudent(4, stud2));
            Student stud3 = new Student("Gena", "Gena", 15, 3.9);
            Console.WriteLine(CPM.addStudent(5, stud3));
            Console.WriteLine(stud3.addToCabala());
            Console.WriteLine(stud1.addToCabala());
            CPM.freeEveryone();
            Console.WriteLine(stud2.addToCabala());
            return true;
        }
        catch { return false; }
    }
    static bool tests5()
    {
        try
        {
            School CPM = new School("CPM", 5, new int[] { 24, 14, 7, 9, 19 });
            Student stud1 = new Student("Alex", "Alex", 14, 4.1);
            Student stud2 = new Student("someone", "something", 12, 5.0);
            Console.WriteLine(CPM.addStudent(1, stud1));
            Console.WriteLine(CPM.addStudent(4, stud2));
            Student stud3 = new Student("Gena", "Gena", 15, 3.9);
            Console.WriteLine(CPM.addStudent(5, stud3));
            Console.WriteLine(stud3.addToCabala());
            Console.WriteLine(stud1.addToCabala());
            CPM.printSchoolStudents();
            CPM.freeEveryone();
            Console.WriteLine(stud2.addToCabala());
            CPM.printSchoolStudents();
            return true;
        }
        catch { return false; }
    }
    static bool tests6()
    {
        try
        {
            School CPM = new School("CPM", 5, new int[] { 24, 14, 7, 9, 19 });
            Student stud1 = new Student("Alex", "Alex", 14, 4.1);
            Student stud2 = new Student("someone", "something", 12, 5.0);
            Console.WriteLine(CPM.addStudent(1, stud1));
            Console.WriteLine(CPM.addStudent(4, stud2));
            Student stud3 = new Student("Gena", "Gena", 15, 3.9);
            Console.WriteLine(CPM.addStudent(5, stud3));
            Console.WriteLine(stud3.addToCabala());
            Console.WriteLine(stud1.addToCabala());
            CPM.printSchoolStudents();
            CPM.freeEveryone();
            Console.WriteLine(stud2.addToCabala());
            Console.WriteLine(stud2.removeFromCabala());
            Student stud4 = new Student("surname", "No surmane", 16, 4.0);
            CPM.printSchoolStudents();
            Console.WriteLine(CPM.addStudent(3, stud4));
            CPM.printSchoolStudents();
            return true;
        }
        catch { return false; }
    }
    static bool tests7()
    {
        try 
        {
            School WCPM = new School("WCPM", 3, new int[] {20,14,25 } );
            Student std1 = new Student("Bro", "https://www.youtube.com/watch?v=HIcSWuKMwOw", 13, 4.6);
            Student std2 = new Student("Ctepan","Ctepka", 15, 4.9);
            Console.WriteLine(WCPM.addStudent(1,std1));
            Console.WriteLine(WCPM.addStudent(2,std2));
            Teacher teach1 = new Teacher("Fedor","Gomonov", 23, "algoritmic");
            Teacher teach2 = new Teacher("Git","Hub",24, "programming");
            Console.WriteLine(WCPM.addTeacher(teach1));
            Console.WriteLine(WCPM.addTeacher(teach2));
            WCPM.printSchoolTeachers();
            teach1.changeLesson("math");
            WCPM.printSchoolTeachers();
            return true;
        }
        catch { return false; }
    }
    static bool tests8()
    {
        try
        {
            School WCPM = new School("WCPM", 3, new int[] { 20, 14, 25 });
            Student std1 = new Student("Bro", "https://www.youtube.com/watch?v=HIcSWuKMwOw", 13, 4.6);
            Student std2 = new Student("Ctepan", "Ctepka", 15, 4.9);
            Console.WriteLine(WCPM.addStudent(1, std1));
            Console.WriteLine(WCPM.addStudent(2, std2));
            Teacher teach1 = new Teacher("Fedor", "Gomonov", 23, "algoritmic");
            Teacher teach2 = new Teacher("Git", "Hub", 24, "programming");
            Console.WriteLine(WCPM.addTeacher(teach1));
            Console.WriteLine(WCPM.addTeacher(teach2));
            WCPM.printSchoolTeachers();
            teach1.changeLesson("math");
            WCPM.printSchoolTeachers();
            std1.changeGrade(4.5);
            std2.changeGrade(4.95);
            return true;
        }
        catch { return false; }
    }
    static bool tests9()
    {
        try
        {
            School WCPM = new School("WCPM", 3, new int[] { 20, 14, 25 });
            Student std1 = new Student("Bro", "https://www.youtube.com/watch?v=HIcSWuKMwOw", 13, 4.6);
            Student std2 = new Student("Ctepan", "Ctepka", 15, 4.9);
            Console.WriteLine(WCPM.addStudent(1, std1));
            Console.WriteLine(WCPM.addStudent(2, std2));
            Teacher teach1 = new Teacher("Fedor", "Gomonov", 23, "algoritmic");
            Teacher teach2 = new Teacher("Git", "Hub", 24, "programming");
            Console.WriteLine(WCPM.addTeacher(teach1));
            Console.WriteLine(WCPM.addTeacher(teach2));
            WCPM.printSchoolTeachers();
            teach1.changeLesson("math");
            WCPM.printSchoolTeachers();
            std1.changeGrade(4.5);
            std2.changeGrade(4.95);
            Console.WriteLine(WCPM.changeClassMaster(1,2));
            Console.WriteLine(WCPM.changeClassMaster(2,1));
            WCPM.printClassMasters();
            Console.WriteLine(WCPM.changeClassMaster(2, 2));
            WCPM.printClassMasters();
            return true;
        }
        catch { return false; }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(tests0());
        Console.WriteLine(tests1());
        Console.WriteLine(tests2());
        Console.WriteLine(tests3());
        Console.WriteLine(tests4());
        Console.WriteLine(tests5());
        Console.WriteLine(tests6());
        Console.WriteLine(tests7());
        Console.WriteLine(tests8());
        Console.WriteLine(tests9());
        Console.ReadLine();
    }
}
