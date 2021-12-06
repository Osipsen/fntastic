Console.WriteLine("Введите строку");
String stroka = Console.ReadLine().ToLower();
String stroka2 = "";
for (int i = 0, F = 0, N = stroka.Length; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (stroka[i] == stroka[j]) F=F+1;
        if (F > 1)
        {
            stroka2 = stroka2+ ")";
            break;
        };
    }
    if (F == 1) stroka2 = stroka2 + "(";
    F= 0;
}
Console.WriteLine(stroka2);