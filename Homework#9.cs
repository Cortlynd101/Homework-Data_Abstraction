using System;
using static System.Console;

namespace AllHW
{
    class Person
    //This class has a name and an address.
    //It can get the name or the address and return a string.
    //It can also change the address.
    {
        protected string name;
        protected string address;
        public Person (string Name, string Address)
        {
            Name = name;
            Address = address; 
        }
        public static string GetName(Person person)
        {
            return person.name;
        }
        public static string GetAddress(Person person)
        {
            return person.address;
        }
        public static void ChangeAddress(Person person, string newAddress)
        {
            person.address = newAddress;
        }
    }
    class Student : Person
    //This class inherits the members of a person object.
    //This class also has an id, an amount of credits, and a gpa as members.
    //It can get any of its members and return them as their type.
    //It can also change the address.
    {
        protected int id;
        protected int credits;
        protected double gpa;
        public Student(string Name, string Address, int ID, int Credits, double GPA) : base(Name, Address)
        {
            Name = name;
            Address = address;
            ID = id;
            Credits = credits;
            GPA = gpa;
        }
        public static int GetID(Student student)
        {
            return student.id;
        }
        public static int GetCredits(Student student)
        {
            return student.credits;
        }
        public static double GetGPA(Student student)
        {
            return student.gpa;
        }
        public static void ChangeAddress(Student student, string newAddress)
        {
            student.address = newAddress;
        }
    }
    class UgradStudent : Student
    //This class inherits the members of a student object.
    //This class also has a degree member and a major member.
    //It can get any of its members and return them as their type.
    {
        protected string degree;
        protected string major;
        public UgradStudent(string Name, string Address, int ID, int Credits, double GPA, string Degree, string Major) : base(Name, Address, ID, Credits, GPA)
        {
            Name = name;
            Address = address;
            ID = id;
            Credits = credits;
            GPA = gpa;
            Degree = degree;
            Major = major;
        }
        public static string GetDegree(UgradStudent ugradStudent)
        {
            return ugradStudent.degree;
        }
        public static string GetMajor(UgradStudent ugradStudent)
        {
            return ugradStudent.major;
        }
    }
}