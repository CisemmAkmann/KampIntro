using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
                     
            IKrediManager tasitKrediManager = new TasitKrediManager();
                      
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService smsLoggerService = new SmsLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService);

            
            basvuruManager.BasvuruYap(esnafKrediManager, smsLoggerService);

            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());


            //basvuruManager.BasvuruYap(tasitKrediManager, new DatabaseLoggerService()); -- bu şekilde de yapılabilir.


            // interface onu implement eden class ın referans numarasını tutabilir.

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager , tasitKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
