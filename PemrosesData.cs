using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal5_103022300035
{
    class PemrosesData
    {
    public PemrosesData() { }
        public T DapatkanNilaiTerbesar<T>(T a, T b, T c)
        {
            dynamic tempA = a;
            dynamic tempB = b;
            dynamic tempC = c;
            dynamic highest = tempA;
            if (tempA < tempB)
            {
                highest = tempB;
            }
            if (tempB < tempC)
            {
                highest = tempC;
            }
            return highest;
        }
    }

    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void addNewData(T data)
        {
            dynamic temp = (dynamic) data;
            dynamic tempDate = (dynamic) DateTime.Now;
            storedData.Add(temp);
            inputDates.Add(tempDate);
        }

        public void printAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i+1} berisi: {storedData[i]}, yang disimpan pada waktu UTC {inputDates[i]}");
            }
        }
    }

}
