using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace _2
{
    class Person{
        public int ID,age;
        public string name,lastName;
        public Person(int id,string name,string lname,int age){
            this.ID = id;
            this.name = name;
            this.lastName = lname;
            this.age = age;
        }
    }
    class  Nomre
    {
        public int ID;
        public int cSharp, cPl, ap;
        public Nomre(int id, int cSharp, int cPl, int ap){
            this.cSharp = cSharp;
            this.cPl = cPl;
            this.ap = ap;
            this.ID  = id;
        }
    }
    public static class Tabdil{
        public static void seRagham(this int value){
            Console.WriteLine(string.Format("{0:N}", value));
        }
        public static void tabdil_tarikh(this DateTime date){
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();
            
            string year = persianCalendar.GetYear(date).ToString();
            string month = persianCalendar.GetMonth(date).ToString().PadLeft(2,'0');
            string day = persianCalendar.GetDayOfMonth(date).ToString().PadLeft(2, '0');
            string persianDateString = string.Format("{0}/{1}/{2}", year, month, day);
            Console.WriteLine(persianDateString);
        }
        public static string toFarsi(this string name){
            
            if(name == "behrad")
                return "بهراد";
            return null;
        }
    }
    //interface
    interface IMashin{
        int tedadDar();
        void soratMashin(int sorat);
        string noeMotor();
    }
    

    class BMW : IMashin{
        int sorat;
        public int tedadDar(){
            return 4;
        }
        public void soratMashin(int sorat){
            this.sorat = sorat;
        }
        public string noeMotor(){
            return "Almani";
        }
    }
    class Perayd : IMashin{
        int sorat;
        public int tedadDar(){
            return 4;
        }
        public void soratMashin(int sorat){
            this.sorat = sorat;
        }
        public string noeMotor(){
            return "Irani";
        }
    }
    class Lamborgini : IMashin
    {
        int sorat;
        public int tedadDar(){
            return 2;
        }
        public void soratMashin(int sorat){
            this.sorat = sorat;
        }
        public string noeMotor(){
            return "Italiaii";
        }
    }
    
    class Program
    {
       
        static void Main(string[] args)
        {
            // DateTime dateTime = DateTime.UtcNow.Date;
            // Console.WriteLine(dateTime.ToString("d"));
            // dateTime.tabdil_tarikh();
        //     String sorat_p = Console.ReadLine();
        //     String sorat_l = Console.ReadLine();
        //     String sorat_b = Console.ReadLine();
        //    // Console.WriteLine(val.toFarsi());
        //     Perayd perayd = new Perayd();
        //     Console.WriteLine(perayd.noeMotor());
        //     Lamborgini lamborgini = new Lamborgini();
        //     Console.WriteLine(lamborgini.noeMotor());
        //     BMW bmw = new BMW();
        //     Console.WriteLine(bmw.noeMotor());
        //     int firstInput = 0;
        //     string val = Console.ReadLine();
        //     //polymorphism
        //     IMashin IPerayd = new Perayd();
        //     IMashin IBmw = new BMW();
        //     IMashin ILam = new Lamborgini();
        //     //ienumerable 
        //     IEnumerable <int> IElist = new List<int>();

            //linq
            // Random rnd = new Random();
            // int[] random = new int[10];
            // for(int i = 0; i< 10;i++){
            //     random[i] = rnd.Next(1,10);
            // }
            // var list = (from n in random orderby n descending select n).ToList();
            // var tedadDo = random.Count(i => i==2);
            // var tedadDoha = (from n in random where n == 2 select n).Count();
            // Console.WriteLine(tedadDo);
            // foreach(var num in list){
            //     Console.Write(num);
            //     Console.Write(" ");
            // }


            Person firstP = new Person(1,"Behrad","Khorram", 20);
            Person secondP = new Person(2,"Ahmad","Karimi", 21);
            Person thirdP = new Person(3,"Nikka","Shahabi", 19);
            Nomre firstNomre = new Nomre(1,20,18,19);
            Nomre secondNomre = new Nomre(2,12,16,20);
            Nomre thirdNomre = new Nomre(3,8,20,20);
            IList<Person> studentList = new List<Person>(){
                firstP,secondP,thirdP
            };
            IList<Nomre> nomres = new List<Nomre>(){
                firstNomre, secondNomre, thirdNomre
            };
            var join = (from p in studentList join n in nomres on p.ID equals n.ID select new{
                name = p.name, cSharp = n.cSharp, cpl = n.cPl , ap = n.ap, id = n.ID,
                avg = (n.cSharp+n.cPl+n.ap)/3, maxnomre = Math.Max(n.cSharp, Math.Max(n.cPl, n.ap)),
                minnomre = Math.Min(n.cSharp, Math.Min(n.cPl, n.ap))
            }).ToArray();
            
            foreach(var nafar in join){
                Console.WriteLine(nafar.name + " ID: " + nafar.id
                 + " C#: " + nafar.cSharp + " C++: " + 
                 nafar.cpl + " AP: " + nafar.ap + " miangin: " + nafar.avg + " min: " +  nafar.minnomre + " max: " + nafar.maxnomre);

            }
            //try{
            //     int sorate_perayd = Convert.ToInt32(sorat_p);
            //     perayd.soratMashin(sorate_perayd);
            //     int sorate_bmw = Convert.ToInt32(sorat_b);
            //     bmw.soratMashin(sorate_bmw);
            //     int sorate_lam = Convert.ToInt32(sorat_l);
            //     bmw.soratMashin(sorate_lam);
                
                
            // }catch(Exception e){
            //     Console.WriteLine("Agha adade avalo doros vared kn :/");
            // }
            
        }
    }
}
















/*static double avrage(int n, int[] arr){
            int x = 0;
            for(int index = 0;index<n;index++)
                x+=arr[index];
            return x/n;
        }
        static double sum(int n, int[] arr){
            int x = 0;
            for(int index = 0;index<n;index++)
                x+=arr[index];
            return x/n;
        }
        static int sum(int n, int[] arr, int type){
            int x = 0;
            for(int index = 0;index<n;index++)
                x+=arr[index];
            return x;
        }
        static void tabdil(int input){
            if(input%1000>99 || input<1000)
                Console.WriteLine(input%1000);
            else if(input%1000>9){
                Console.Write(0);
                Console.WriteLine(input%1000);
            }
            else{
                Console.Write(0);
                Console.Write(0);
                Console.WriteLine(input%1000);
            }
        }
        */
        /*
        class Prime{
        private int val;
        public Prime(int input){
            val = input;
        }
        public bool isPrime(){
            for(int i = 2;i*i<=val;i++)
                if(val%i==0)
                    return false;
            return true;
        }
    }
    class Person{
        protected int age;
        protected string firstName, lastName;
    }
    class Student : Person{
        public Student(string name){
            firstName = name;
        }
        public string getName(){
            return firstName;
        }
    }
    class Pride{
        private int speed;
        
        public int Speed { get{
            return speed;
        } set{
            speed = value;
            if(value > 120)
                   Console.WriteLine("Be behsht khush amadid");
                else
                    Console.WriteLine("Be behesht vared nashodid");
        } }
    }
    */