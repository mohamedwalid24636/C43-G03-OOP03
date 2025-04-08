using System.Net.Http.Headers;
using Assignment_03_OOP;

internal class Program
{



    public static void Sort(Employee [] emp)
    {
        for (int i = 0; i < emp.Length-1; i++)
        {
        int min = i;
           
            for (int j =i+1; j < emp.Length; j++)
            {
                if (emp[j].hiredate < emp[min].hiredate)
                {
                    min = j;
                }
            }
        (emp[min], emp[i]) = (emp[i], emp[min]);
        
        }

    }




    private static void Main(string[] args)
    {
        Employee EMP1 = new Employee(20039150 , "Mohaed Walid Abdallah" , 50000 ,2022,5,13, Gender.M,(security_lv) 6);

        Employee[] emparr =
            { new Employee(2165 , "ezz walid" , 25000 ,          2020 , 12 , 22         , Gender.M , security_lv.secretary) ,
              new Employee(4685 , "walid abdallah" , 80_000 ,    1999 , 7 , 15           ,Gender.M, security_lv.DBA   ) ,
              new Employee(948 , "BEBE" , 13000 ,                2000 , 7 , 24           , Gender.F ,(security_lv) 15 ) };
        //Console.WriteLine(emparr.Length);



        foreach (Employee p in emparr)
        {
            Console.WriteLine(p+"\n");
        }




        Sort(emparr);



        foreach (Employee p in emparr)
        {
            Console.WriteLine(p);
        }


    }




}