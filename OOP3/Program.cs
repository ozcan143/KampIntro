using OOP3;
using System.Collections.Generic;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasıtKrediManager = new TasıtKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
IKrediManager esnafKrediManager= new EsnafKredisiManager();

ILoggerService databaseloggerService = new DataBaseLoggerService();
ILoggerService fileLogerService = new FileBaseLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(esnafKrediManager, new List<ILoggerService>() { smsLoggerService, databaseloggerService });
    

List<IKrediManager>krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasıtKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);


