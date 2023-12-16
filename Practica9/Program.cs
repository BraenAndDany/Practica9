using System;
using System.Collections.Generic;

class Programm
{

    
    public int[] SortBubble(int[] array)
    {
        int prove = 0;
        while (true)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    int curentKey = array[i-1];
                    array[i - 1] = array[i];
                    array[i] = curentKey;

                }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i - 1] < array[i]))
                {
                    prove++;
                }
            }
            if (prove == array.Length - 1)
            {
                break;
            }
            else if (prove != array.Length)
            {
                prove = 0;
            }      
        }
        return array;
    }
    public List<int> SortBubble(List<int> list)
    {
        int prove = 0;
        while (true)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] > list[i])
                {
                    int curentKey = list[i - 1];
                    list[i - 1] = list[i];
                    list[i] = curentKey;

                }
            }
            for (int i = 1; i < list.Count; i++)
            {
                if ((list[i - 1] < list[i]))
                {
                    prove++;
                }
            }
            if (prove == list.Count-1)
            {
                break;
            }
            else if (prove != list.Count)
            {
                prove = 0;
            }
        }
        return list;
    }
    public char[] SortBubble(char[] str) 
    {
        int prove = 0;
        while (true)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] > str[i])
                {
                    char curentKey = str[i - 1];
                    str[i - 1] = str[i];
                    str[i] = curentKey;

                }
            }
            for (int i = 1; i < str.Length; i++)
            {
                if ((str[i - 1] < str[i]))
                {
                    prove++;
                }
            }
            if (prove == str.Length - 1)
            {
                break;
            }
            else if (prove != str.Length)
            {
                prove = 0;
            }
        }
        return str;
    }
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 3, 2, 1, 9, 7, 6, 5, 8, 4, 10,11};
        int[] array = { 3, 2, 1, 9, 7, 6, 5, 8, 4 };
        char[] str = { 'f', 'b', 'c' };
        Programm program = new Programm();
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.Write(program.SortBubble(array)[i]);
        //}
        //for (int i = 0; i < list.Count; i++)
        //{
        //    Console.Write(program.SortBubble(list)[i]);
        //}
        for (int i = 0; i < str.Length; i++)
        {
            Console.WriteLine(program.SortBubble(str)[i]);
        }
    }
}