using System.Diagnostics;
using System.Collections.Generic;
namespace _151126TirgulFunc_Action
{
    public class Button
    {
        public Action OnClick;
        public Button (Action onClick)
        {
            OnClick = onClick;
        }
        public void SimulateClick()
        {
            Console.WriteLine("Button was clicked");
            OnClick.Invoke();
        }
    }
    internal class Program
    {
        public static void SaveData()
        {
            Console.WriteLine("Saving data");
        }
        public static void TurnLightOn()
        {
            Console.WriteLine("And User said, let there be light!");
        }
        static void Main(string[] args)
        {
            //משימה 1 (מסנן מספרים):
            int[] arr = new int[] { 174, 45, 1, 2, 3, 6, 7, 8, 11, 16, 0 };
            List<int> l=FilterNumbers(arr, IsEven);
            foreach (int a in l)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
            l = FilterNumbers(arr, BiggerThanTen);
            foreach(int a in l)
            {
                Console.Write($"{a} ");
            }
            //משימה 2 (כפתור):
            Console.WriteLine();
            Action c = SaveData;
            c += TurnLightOn;
            Button b = new Button(c);
            b.SimulateClick();
        }
        public static List<int> FilterNumbers(int[] arr, Predicate<int> a)
        {
            List<int> result = new List<int>();
            for (int i=0; i<arr.Length; i++)
            {
                if (a(arr[i]))
                {
                    result.Add(arr[i]);
                }
            }
            return result;
        }
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        public static bool BiggerThanTen(int num)
        {
            return num > 10;
        }
    }
}
