using System.Diagnostics;

namespace Datastruktur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1
            string[] mitArray1 = { "sovs", "bacon", "kartofler", "chips", "cocio", "vand", "burger" };
            string ordd = "chips";
            Op1_1(mitArray1, ordd);
            //Opgave 2 med metoder
            string[] mitArray = { "sovs", "bacon", "kartofler", "chips", "cocio", "vand", "burger" };
            int deleteAt = 1;
            Op1_2(mitArray, deleteAt);
            //Opgave 1 i liste
            ListOp1();
            //Opgave 2 i list
            ListOp2();
            int indx = 3;
            string[] strang = { "kage", "sovs", "pap", "ur", "tv", "lys", "led" };
            string tilsat = "ord";
            Op_3(indx, tilsat, strang);
            //Opgave Hash_1
            string soeg = "word";
            Hash_1_1(soeg); //laver en hash-tabel og søger
            Console.WriteLine();
            //Opgave 1 med stack er svaret bare 4.
            //Opgave 2 med stack
            Stack_2();
            //Svaret på opgave queue. er 2.
        }
        static private int Op1_1(string[] mitArray1, string ordd)
        {
            Console.WriteLine();
            for (int i = 0; i < mitArray1.Length; i++)
            {
                if (mitArray1[i] == ordd)
                {
                    return i;
                }
            }
            return -1;
        }
        static (string[], bool) Op1_2(string[] mitArray, int deleteAt)

        {
            string[] tempArray = new string[mitArray.Length - 1];
            if (mitArray.Length > deleteAt)
            {
                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (i < deleteAt)
                    {
                        tempArray[i] = mitArray[i];
                    }
                    else
                    {
                        tempArray[i] = mitArray[i + 1];
                    }
                }

                mitArray = tempArray;
                return (mitArray, true);
            }
            else
            {
                return (mitArray, false);
            }
        }
        static private void ListOp1()
        {
            List<int> talList = new List<int>() { 10, 20, 30 };
            talList.Add(40);
            talList.Add(15);
            talList.Sort();
            talList.Reverse();
            //Den sætter 40 i slutningen af listen. så sætter den 15 i slutningen. så sortere den. så går den omvendt.
        }
        static private void ListOp2()
        {
            List<char> snakkeList = new List<char>() { 'S', 'n', 'a', 'a', 'k', 'k', 'e',' ', 'b', 'a', 'g', 'v', 'e', 'n', 'd', 't' };
            snakkeList.Reverse();
            for (int i = 0; i < snakkeList.Count; i++)
                Console.WriteLine(snakkeList[i].ToString());
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
            for (int i = myStack.Count; i > 0; i--)
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }
} //yes
