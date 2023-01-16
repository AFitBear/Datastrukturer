namespace Datastrukturer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indx = 3;
            string[] strang = { "kage", "sovs", "pap", "ur", "tv", "lys", "led" };
            string tilsat = "ord";
            Op_3(indx, tilsat, strang);
            //Opgave Hash_1
            string soeg = "word";
            Hash_1_1(soeg); //laver en hash-tabel og søger
            Console.WriteLine();
            //Opgave 1 med stack er svaret bare 4.
            //Opgave 2
            Stack_2();
        }
        static private (bool, string[]) Op_3(int indx, string tilsat, string[] strang)
        {
            string[] temp = new string[strang.Length + 1];
            if (indx < temp.Length && indx! < 0)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (i < indx)
                    {
                        temp[i] = strang[i];

                    }
                    else if (i == indx)
                    {
                        temp[i] = tilsat;
                    }
                    else
                    {
                        temp[i] = strang[i - 1];
                    }
                }
                strang = temp;
                return (true, strang);
            }
            else { return (false, strang); }
        }
        static private string Hash_1_1(string soeg)
        {
            Dictionary<string, string> MyDict = new
            Dictionary<string, string>() { { "blender file","blend" }, { "word","doxc" }, { "application","exe" }, { "excel","xlsx" },
            { "text","txt" }, { "jpg file","jpg" }, { "png file","png" } ,{ "gif file","gif" }, { "powerpint","pptx" }, { "maple","mpl" } };
            Console.WriteLine(MyDict[soeg]);
            return MyDict[soeg];
        }
        static private void Stack_2()
        {
            //string snakk = { 'S', 'n', 'a', 'k', 'k', 'e', ' ', 'b', 'a', 'g', 'v', 'e', 'n', 'd' };
            string snakk = "Snakke bagvend";
            Stack<char> myStack = new Stack<char>();
            for (int i = 0; i < snakk.Length; i++)
            {
                myStack.Push(snakk[i]);
            }
            for (int i = 0; i < myStack.Count; i++)
            {
                Console.Write(myStack.Peek);
                Console.WriteLine(myStack.Pop());
            }
        }
            
    }
}
