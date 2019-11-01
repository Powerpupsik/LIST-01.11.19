using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var dateToday = new DateTime(1988, 12, 9);
            Console.WriteLine(dateToday);
            var dayOfTheWeek = dateToday.DayOfWeek;
            Console.WriteLine(dayOfTheWeek);*/


            //Küsib sünnikuud ja päeva ning ütleb, mis päeval sa sündisid.
            /*Console.WriteLine("Enter your birth year, month and date: ");
            string birthYear = Console.ReadLine();
            GetArrayFromString(birthYear);*/

            /*string userYear;
            Console.WriteLine("Enter your date of birth(yyyy/m/dd)")
            userYear= Console.ReadLine();

            string[] userData = userYear.Split('/');
            int year = int.Parse(userData[0]); 
            int month= int.Parse(userData[1]);
            int day= int.Parse(userData[2]);

            var userBirthday = new DateTime(year, month, day);
            var birthdayDayOfTheWeek = userBirthday.DayOfWeek;
            Console.WriteLine($"You were born on {birthdayDayOfTheWeek}");

            Console.ReadLine();*/


            //KUUPÄEV TÄNA

            var currentDate =  DateTime.Now;
            var dateObject = new DateTime(2019, 11, 1);
            Console.WriteLine(currentDate);
           

            var currentDayOfTheWeek = currentDate.DayOfWeek; //var on objekt; ükskõik mida salvestad sinna
           

            var ticks = dateObject.Ticks;
            Console.WriteLine($"Ticks: {ticks}");

            Console.WriteLine($"Print current date: {currentDate}");
            Console.WriteLine($"Print long date string: {currentDate.ToLongDateString()}");
            Console.WriteLine($"Print long date string: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Print long time to string: {currentDate.ToLongTimeString()}");
            Console.WriteLine($"Print long time to string: {currentDate.ToShortTimeString()}");
            Console.WriteLine($"Date format: {currentDate.ToString("dd-MM-yyyy HH:mm")}");


            Console.ReadLine();

        }
       
        
    }
}
