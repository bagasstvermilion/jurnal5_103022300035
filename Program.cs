using System;
using jurnal5_103022300035;
class Program
{
    static void Main()
    {
        PemrosesData pd = new PemrosesData();
        Console.WriteLine("Nilai terbesar adalah: " + pd.DapatkanNilaiTerbesar(10.30, 22.30, 00.35));

        Console.WriteLine();

        SimpleDataBase<double> sdb = new SimpleDataBase<double>();

        sdb.addNewData(10.30);
        sdb.addNewData(22.30);
        sdb.addNewData(00.35);

        sdb.printAllData();
    }
}
