using System.ComponentModel.Design;

namespace Currency_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double[] currencies = { 0.54, 18.97, 0.59 };
            string[] currencieCodes = { "EUR", "TL", "USD" };

            while (true)
            {
                Console.WriteLine("Qiymeti daxil edin");
                double userEntered = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Valyuta novunu secin:");
                int index = 0;
                while (index < currencieCodes.Length)
                {
                    Console.WriteLine($"{index + 1}. {currencieCodes[index]}");
                    index++;
                }
                int select = 0;
                while (true)
                {
                    select = Convert.ToInt32(Console.ReadLine());

                    if (select > 0 && select <= currencieCodes.Length)
                    {
                        break;
                    }
                    Console.WriteLine("Duzgun deyer daxil edin");
                }

                double sum = 0;
                //if (select == 1)
                //{
                //    Console.WriteLine(sum = userEntered * currencies[2]);

                //}else if (select == 2)
                //{
                //    Console.WriteLine(sum = userEntered * currencies[0]);

                //}else if(select == 3)
                //{
                //    Console.WriteLine(sum = userEntered * currencies[1]);

                //}else
                //{
                //    Console.WriteLine("Duzgun secim edin");



                //}

                sum = userEntered * currencies[select - 1];
                Console.WriteLine(sum + " " + currencieCodes[select - 1]);


                Console.WriteLine($"Valyuta cevrilmesi:{sum}");
                Console.WriteLine("Yeni valyuta deyisdirmek isteyirsiz? davam etmek isteyirsizse Y/Yes ve yaxud inkar etmek isteyirsizse N/No daxil edin");



                //if (yesNo == "N" || yesNo == "No")
                //{
                //    break;
                //}
                //else if (yesNo == "Y" || yesNo == "Yes")
                //{
                   
                //}
                //else
                //{
                //    Console.WriteLine("Duzgun cavab daxil et");
                //}

                while(true)
                {
                    string loopTerminationResult=Console.ReadLine();
                    if (loopTerminationResult == "Exit")
                    {
                        return;
                    }
                    else if (loopTerminationResult != "Yes" && loopTerminationResult != "Y")
                    {
                        Console.WriteLine("Duzgun daxil edin ");
                    }
                    else
                    {
                        break ;
                    }




                }   


            }



        }
    }
}
