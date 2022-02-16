using System;

namespace ObjectsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Lutfiyar";
            student.surname = "Aliyev";
            student.group = 1301;
            student.age = 26;

            Console.WriteLine("Ilk tapsiriq bu sekilde gorunecek");
            Console.WriteLine(student.GetFullname());


            Console.WriteLine("Ikinci tapsiriq bu sekilde gorunecek");
            Console.WriteLine(student.GetInfo());


            //Console.WriteLine("\n Telebenin imtahan neticesi:\n");
            //Console.WriteLine(student.PointsExam());
        }
       


        

    }

    class Student
    {


        public string name;
        public string surname;
        public int age;
        public int group;
        public int point;
        public bool isGraduated;

        public string GetFullname()
        {

            return $"\nName:  {name},\nSurname:  {surname}\n";

        }
        public string GetInfo()
        {
            return $" \n\n Name : {name}  \n Surname : {surname} \n Age : {age} \n Group : {group} \n Point : {point} \n IsGraduated : {isGraduated}";
        }

        internal bool Points()
        {
            throw new NotImplementedException();
        }
        //public string Imtahan()
        //{
        //    if (point>80)
        //    {
        //        return "Imtahandan kecdi";

        //        else
        //            return "Imtahandan kesildi";
                
        //    }
        //}
        //public string PointsExam()
        //{
        //   bool Ehtimal1=false;
        //   bool Ehtimal2=true;
        //   bool result= Ehtimal1.Equals(Ehtimal2);
        //    if (result == true)
        //    {
        //        return "Imtahana gire biler";
        //    }
           
            
            
        
        
    }
    
}
