using System;

namespace Hour_On_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hour on exam: ");
            var HourOnExam = int.Parse(Console.ReadLine());
            if (HourOnExam >= 0 && HourOnExam <= 23)
            {
                Console.Write("Minutes on exam: ");
                var MinOnExam = int.Parse(Console.ReadLine());
                if (MinOnExam >= 0 && MinOnExam <= 59)
                {
                    Console.Write("Hour on arrive: ");
                    var HourOnArrive = int.Parse(Console.ReadLine());


                    if (HourOnArrive >= 0 && HourOnArrive <= 23)
                    {
                        Console.Write("Minutes on arrive: ");
                        var MinOnArrive = int.Parse(Console.ReadLine());
                        if (HourOnArrive == HourOnExam)
                        {
                            if (MinOnArrive == MinOnExam)
                            {
                                Console.WriteLine("On time");
                            }
                            else if (MinOnArrive > MinOnExam)
                            {
                                int dif = MinOnArrive - MinOnExam;
                                Console.WriteLine("Late");
                                Console.WriteLine("{0} minutes after the start", dif);
                            }
                            else if (MinOnExam > MinOnArrive)
                            {
                                int dif = MinOnExam - MinOnArrive;
                                Console.WriteLine("On time");
                                Console.WriteLine("{0} minutes befor the start", dif);
                            }
                        }
                        else if (HourOnArrive > HourOnExam)
                        {
                            if (MinOnArrive == MinOnExam)
                            {
                                int dif = HourOnArrive - HourOnExam;
                                if (dif == 1)
                                {
                                    Console.WriteLine("Late");
                                    Console.WriteLine("{0} hour after the start", dif);
                                }
                                else
                                {
                                    Console.WriteLine("Late");
                                    Console.WriteLine("{0} hours after the start", dif);
                                }

                            }
                            else if (MinOnArrive > MinOnExam)
                            {
                                int dif = HourOnArrive - HourOnExam;
                                int dife = MinOnArrive - MinOnExam;

                                if (dif == 1)
                                {

                                    Console.WriteLine("Late");
                                    Console.WriteLine("{0}:{1} hours after the start", dif, dife);
                                }
                                else
                                {
                                    Console.WriteLine("Late");
                                    Console.WriteLine("{0}:{1} hours after the start", dif, dife);
                                }

                            }
                            else if (MinOnArrive < MinOnExam)
                            {
                                int dif = (HourOnArrive * 60) + MinOnArrive;
                                int dife = HourOnExam * 60 + MinOnExam;
                                int difer = Math.Abs(dif - dife);
                                int difere = difer / 60;
                                int diferen = difer % 60;

                                Console.WriteLine("Late");
                                Console.WriteLine("{0}:{1} hours after the start", difere, diferen);
                            }
                        }
                        else if (HourOnArrive < HourOnExam)
                        {
                            if (MinOnArrive == MinOnExam)
                            {
                                int dif = HourOnExam - HourOnArrive;
                                Console.WriteLine("Early");
                                Console.WriteLine("{0}:00 hours before the start", dif);
                            }
                            //100% ok
                            else if (MinOnArrive > MinOnExam)
                            {
                                int dife = MinOnArrive - MinOnExam;
                                int difer = MinOnExam + 60;
                                int difere = difer - MinOnArrive;
                                int dif = HourOnExam - 1 - HourOnArrive;

                                if (MinOnExam == 0)
                                {
                                    if (dif != 0)
                                    {
                                        int diferent = HourOnExam - HourOnArrive;
                                        Console.WriteLine("Early");
                                        Console.WriteLine("{0}:{1} minutes before the start", dif, difere);
                                    }
                                    else
                                    {
                                        dife = 60 - MinOnArrive;
                                        Console.WriteLine("Early");
                                        Console.WriteLine("{0} minutes before the start", dife);
                                    }
                                }
                                else if (dif != 0)
                                {
                                    int diferent = HourOnExam - HourOnArrive;
                                    Console.WriteLine("Early");
                                    Console.WriteLine("{0}:{1} minutes before the start", dif, difere);
                                }

                                else if (dif == 0)
                                {
                                    Console.WriteLine("Early");
                                    Console.WriteLine("{0}:{1} hours before the start", dif, difere);
                                }

                                else
                                {
                                    Console.WriteLine("Early");
                                    Console.WriteLine("{0} minutes before the start", difere);
                                }
                            }
                            else if (MinOnArrive < MinOnExam)
                            {
                                int dif = (HourOnArrive * 60) + MinOnArrive;
                                int dife = HourOnExam * 60 + MinOnExam;
                                int difer = Math.Abs(dife - dif);
                                int difere = difer / 60;
                                int diferen = difer % 60;

                                Console.WriteLine("Early");
                                Console.WriteLine("{0}:{1} hours befor the start", difere, diferen);
                            }
                        }
                    }
                }
            }

        }
    }
}
