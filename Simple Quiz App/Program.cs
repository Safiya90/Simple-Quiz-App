namespace Simple_Quiz_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string[] question = new string[]{
                "1- What is my name?",
                "2- What is my second name?",
                "2- What is my last name?",
                "3- What is my favourit color?",
                "4- What is my favourit drinks?"
            };
            string[,] option = new string[,]
            {
            { "A- Safiya", "B- Maryam", "C- Marwa", "D- Salwa" },
            { "A- Ali", "B- Khamis", "C- Salim", "D- Saeed" },
            { "A- Alalwi", "B- Almaskari", "C-Aloraimi", "D- Almusharrafi" },
            { "A- red", "B- blue", "C-black", "D- pink" },
            {"A- Juice","B- Spanish","C- Amricano","D- Mojito" },
            };
            string[] answer = new string[] { "A", "B", "D", "C" ,"C"};

            for (int i = 0; i < question.Length; i++)
            {
                Console.WriteLine(question[i]);
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(option[i, j]);
                }
                Console.WriteLine("please choose:");
                string youranswer = Console.ReadLine();
                if (youranswer == answer[i])
                {
                    Console.WriteLine("Correct");
                    sum++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            }
            switch (sum)
            {
                case 2:
                case 3:
                    Console.WriteLine($"Your score= {sum} and you are Good");
                    break;
                case 4:
                case 5:
                    Console.WriteLine($"Your score= {sum} and you are Good Excellent");
                    break;
                default:
                    Console.WriteLine($"Your score= {sum} and please Try Again");
                    break;
            }
        }
    }
}