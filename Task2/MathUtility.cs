using System;

public static class MathUtility
{
    public static int ���������(int a, int b)
    {
        return a + b;
    }
    public static int ³�������(int a, int b)
    {
        return a - b;
    }
    public static int ��������(int a, int b)
    {
        return a * b;
    }
    public static double ĳ�����(int a, int b)
    {
        if (b == 0)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            throw new DivideByZeroException("�������: ĳ����� �� ����!");
        }
        return (double)a / b;
    }
}