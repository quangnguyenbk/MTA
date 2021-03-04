using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int usedKW = 1200;
            int totalMoney = 0;
            if ( usedKW <= 100)
            {
                totalMoney = usedKW * 450;
            } else if (usedKW <= 200)
            {
                totalMoney = (usedKW - 100) * 600 + 100 * 450;
            } else if (usedKW <= 300)
            {
                totalMoney = (usedKW - 200) * 750 + 100 * 600 + 100 * 450;
            } else if (usedKW <= 500)
            {
                totalMoney = (usedKW - 300) * 900 + 100 * 750 + 100 * 600 + 100 * 450;
            } else if (usedKW <= 1000)
            {
                totalMoney = (usedKW - 500) * 1000 + 200 * 900 + 100 * 750 + 100 * 600 + 100 * 450;
            } else if (usedKW > 1000)
            {
                totalMoney = (usedKW - 1000) * 1200 + 500 * 1000 + 200 * 900 + 100 * 750 + 100 * 600 + 100 * 450;
            } else
            {
                Console.WriteLine("khong hop le");
                return;
            }

            Console.WriteLine("money before VAT: " + totalMoney);
            Console.WriteLine("money after VAT: " + totalMoney * 1.1);
        }
    }
}
