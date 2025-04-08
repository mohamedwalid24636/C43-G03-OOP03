using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_03_OOP
{
    internal class Employee
    
    {
       int    id;
       string name;
       double salary;
       public DateTime? hiredate { get; set; } 
       Gender gender = new Gender();
       security_lv security = new security_lv();






        public Employee(int id, string name, double salary,int year,int month,int day, Gender g, security_lv s) 
        {
            this.id = id;
            this.name = name;
            this.salary = salary; 
            hiredate = new DateTime(year, month, day);
            gender = g;
            security = s;
        }

        public override string ToString()
        {
            return $"id : {id} , name : {name} , salary : {salary} , hiredate : {string.Format ("{0:yyyy-MMM-dd}", hiredate)} \n " +
                $"gender : {gender} , security level {security}";
        }













    }



    internal enum Gender 
    {
        M , F 
    }

    [Flags]
    internal enum security_lv
    {
        guest = 1,  // 0001
        Developer = 2, // 0010  => 2
        secretary = 4 , // 0100 => 4
        DBA       = 8   // 1000 
            // D + S => 6 
    }





}
