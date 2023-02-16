using System;

namespace ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            char keyChar;
            do
            {
                // Console.ReadKey() �������� ��������� ������� ������������� ������ ��� �������������� �������. 
                // ������� ������� ������������ � ���� �������. 
                ConsoleKeyInfo info = Console.ReadKey();
                // ConsoleKeyInfo ��������� ������� ������� �������, ������� ������, �������������� ���� ��������, 
                // � ��������� ����������� ������ CTRL, SHIFT � ALT.
                key = info.Key; // ���������� ������� �������, �������������� ������� �������� ConsoleKeyInfo.
                Console.WriteLine(key);
            } while (key != ConsoleKey.Escape);

            do
            {
                ConsoleKeyInfo info = Console.ReadKey();
                keyChar = info.KeyChar;
                Console.WriteLine(keyChar); // ���������� ������ �������, �������������� ������� �������� ConsoleKeyInfo.
            } while (keyChar != 27);

        }
    }
}