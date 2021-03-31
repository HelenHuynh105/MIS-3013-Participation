using System;
using System.IO;

namespace CVSFILE
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("sales_data_sample.csv");

            double Sum2003 = 0;
            double Sum2004 = 0;
            double Sum2005 = 0;

            double[] sumMonths = new double[13];
            //sumMonths[0] = 0;   0 isn't a month, won't use this one
            sumMonths[1] = 0;
            sumMonths[2] = 0;
            sumMonths[3] = 0;
            sumMonths[4] = 0;
            sumMonths[5] = 0;
            sumMonths[6] = 0;
            sumMonths[7] = 0;
            sumMonths[8] = 0;
            sumMonths[9] = 0;
            sumMonths[10] = 0;
            sumMonths[11] = 0;
            sumMonths[12] = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                string currentLineOfFile = lines[i];
                string[] pieces = currentLineOfFile.Split(",");

                string status = pieces[6];
                double sales = Convert.ToDouble(pieces[4]);
                int month = Convert.ToInt32(pieces[8]);
                int year = Convert.ToInt32(pieces[9]);

                if (status == "Shipped")
                {

                    sumMonths[month] += sales;
                    switch (year)
                    {
                        case 2003:
                            Sum2003 += sales;
                            break;
                        case 2004:
                            Sum2004 += sales;
                            break;
                        case 2005:
                            Sum2005 += sales;
                            break;
                    }
                }
            }

            //ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE

            Console.WriteLine($"The sum for 2003 is {Sum2003.ToString("C")}");
            Console.WriteLine($"The sum for 2004 is {Sum2004.ToString("C")}");
            Console.WriteLine($"The sum for 2005 is {Sum2005.ToString("C")}");

            for (int i = 1; i < sumMonths.Length; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine($"The sum for all January's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"The sum for all February's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"The sum for all March's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 4)
                {
                    Console.WriteLine($"The sum for all April's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 5)
                {
                    Console.WriteLine($"The sum for all May's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 6)
                {
                    Console.WriteLine($"The sum for all June's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 7)
                {
                    Console.WriteLine($"The sum for all July's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 8)
                {
                    Console.WriteLine($"The sum for all August's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 9)
                {
                    Console.WriteLine($"The sum for all September's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 10)
                {
                    Console.WriteLine($"The sum for all October's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 11)
                {
                    Console.WriteLine($"The sum for all November's is {sumMonths[i].ToString("C")}");
                }
                else//12
                {
                    Console.WriteLine($"The sum for all December's is {sumMonths[i].ToString("C")}");
                }

            }
        }
    }
}

