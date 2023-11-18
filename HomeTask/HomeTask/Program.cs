
#region Faktorial
Console.Write("Ededi daxil edin : ");
ulong number = (uint)Convert.ToUInt64(Console.ReadLine());
ulong faktorial = 1;

for (ulong i = 1; i <= number; i++)
{
    faktorial = faktorial * i;
}

Console.WriteLine("Faktorial = " + faktorial);

#endregion




#region Aylar və Fəsillər
Console.Write("Ay daxil edin : ");
string month = Console.ReadLine();
if (month == "Sentyabr")
{
    Console.WriteLine("Cavab : " + "Payiz");
}
else if (month == "Oktyabr")
{
    Console.WriteLine("Cavab : " + "Payiz");
}
else if (month == "Noyabr")
{
    Console.WriteLine("Cavab : " + "Payiz");
}
else if (month == "Dekabr")
{
    Console.WriteLine("Cavab : " + "Qis");
}
else if (month == "Yanvar")
{
    Console.WriteLine("Cavab : " + "Qis");
}
else if (month == "Fevral")
{
    Console.WriteLine("Cavab : " + "Qis");
}
else if (month == "Mart")
{
    Console.WriteLine("Cavab : " + "Yaz");
}
else if (month == "Aprel")
{
    Console.WriteLine("Cavab : " + "Yaz");
}
else if (month == "May")
{
    Console.WriteLine("Cavab : " + "Yaz");
}
else if (month == "Iyun")
{
    Console.WriteLine("Cavab : " + "Yay");
}
else if (month == "Iyul")
{
    Console.WriteLine("Cavab : " + "Yay");
}
else if (month == "Avqust")
{
    Console.WriteLine("Cavab : " + "Yay");
}
else
{
    Console.WriteLine("Zehmet olmasa düzgün ay daxil edin!");
}


#endregion





#region Ədədlərin mərtəbəsi
Console.Write("Ededi daxil edin : ");
int ədəd = (int)Convert.ToInt64(Console.ReadLine());
int mərtəbə = 0;
while (ədəd > 0)
{
    mərtəbə++;
    ədəd = ədəd / 10;
}

Console.WriteLine("Ededin mertebesi = " + mərtəbə);
#endregion