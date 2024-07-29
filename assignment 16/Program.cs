namespace assignment_16
{
    internal class Program
    {
        #region ques 1
        public enum WeekDays
        {
            monday = 1,
            tuesday,
            thursday,
            wednesday,
            friday,
            saturday,
            sunday,

        }
        #endregion
        #region ques 2
        public enum Season
        {
            spring,
            summer,
            Autumn,
            Winter,
        }



        #endregion
        #region ques 3
        [Flags]
        public enum Permession
        {
            None=0,
            Read=1,
            Write=2,
            Delete=4,
            Execute=8,
        }
        //static void DisplayPermession(Permession perm)
        //{
        //    Console.WriteLine($"Current pemessions:{perm}");
        //}



        #endregion
        #region ques 4
        //public enum Colors
        //{
        //    Red,
        //    Green,
        //    Blue,

        //}




        #endregion
        static void Main(string[] args)
        {
            #region ques 1
            // WeekDays wd=WeekDays.monday;
            //for(int i = 1; i <= 7; i++)
            // {
            //     Console.WriteLine((WeekDays)i);
            // }



            #endregion
            #region ques 2
            //Console.Write("Enter the season: ");
            //string se = Console.ReadLine();
            //if (Enum.TryParse(se, true, out Season ses))
            //{
            //    switch (ses)
            //    {
            //        case Season.spring:
            //            Console.WriteLine("Spring : March to May");
            //            break;
            //        case Season.summer:
            //            Console.WriteLine("Summer : June to August ");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to Febraury");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        default:
            //            Console.WriteLine("invalid season entered");
            //            break;

            //    }


            //}
            //else
            //    Console.WriteLine("invalid season entered");

            #endregion
            #region ques 3
            //Permession per = Permession.None;
            //per |= Permession.Read;
            //per|=Permession.Write;
            //Console.WriteLine("permession Read and Write is Added");
            //DisplayPermession(per);

            //bool HasDeleteperm = (per & Permession.Delete) == Permession.Delete;
            //Console.WriteLine($"is Delete permession Exist: {HasDeleteperm}");
            //bool HasWriteperm = (per & Permession.Write) == Permession.Write;
            //Console.WriteLine($"is Write permession Exist: {HasWriteperm}");





            #endregion
            #region ques 4
            //Console.Write("Enter the color:");
            //string col = Console.ReadLine();

            //Colors color;
            //if(Enum.TryParse(col,true,out color) && Enum.IsDefined(typeof(Colors), color))
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color ");
            //            break;
            //        default:
            //            Console.WriteLine($"{color} is not a primary color");
            //            break;


            //    }
            //}
            //else
            //    Console.WriteLine($"{color} is not a primary color");






            #endregion
            #region ques 5
            //point p1;
            //Console.Write("Enter the first number : ");
            //int.TryParse(Console.ReadLine(),out p1.x); 
            //Console.Write("Enter the second number : ");
            //int.TryParse(Console.ReadLine(),out p1.y);

            //p1.SumTwoNumbers();





            #endregion

        }
    }
}
