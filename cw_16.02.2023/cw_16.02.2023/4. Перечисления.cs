using System;
class EnumDemo
{
    enum Day_Of_Week { Sunday, Monday, Thuesday, Wednesday, Thursday, Friday, Saturday };
    public static void Main()
    {
        string[] day_of_week = { "�����������", "�����������", "�������", "�����", "�������", "�������", "�������" };
        Day_Of_Week i; // ��������� ���������� ������������� ����.
        // ���������� ���������� i ��� ������ ���� ������ ������������
        for (i = Day_Of_Week.Sunday; i <= Day_Of_Week.Saturday; i++)
        {
            Console.WriteLine(i + " - ��� " + day_of_week[(int)i]);
        }
        Console.WriteLine();

        if (Enum.IsDefined(typeof(Day_Of_Week), (int)4))
        // ��� ����� �������� ��� ��������� (��������, 30) IsDefined ������ false
        {
            Day_Of_Week d = (Day_Of_Week)4;
            Console.WriteLine(d);
        }
        i = (Day_Of_Week)Enum.Parse(typeof(Day_Of_Week), "Thursday");
        Console.WriteLine(i);
    }
}
