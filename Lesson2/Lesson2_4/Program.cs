using System;

namespace Lesson2_4
{
    class Program
    {
        private struct Receipt
        {
            public uint number;
            public DateTime time;
            public uint shiftNumber;
            public uint terminalNumber;

            public uint goodsCount;
            public decimal goodsPrice;

            public decimal ndsTax;

            public decimal cache;
            public decimal nonCache;

            public decimal TotalPrice
            {
                get => goodsPrice * goodsCount;
            }

            public decimal NdsAmount
            {
                get => ndsTax * TotalPrice / 100;
            }

            // here it is the same as TotalPrice but it can be something different
            public decimal Result
            {
                get => TotalPrice;
            }

            public decimal OddMoney
            {
                get => cache + nonCache - Result;
            }
        }

        static void Main(string[] args)
        {
            const int MAX_COUNT = 10;
            const int MAX_PRICE = 100000;
            const int MAX_CACHE = 1000000;

            Random rnd = new Random();

            Receipt receipt = new Receipt
            {
                number         = (uint) rnd.Next(1, Int32.MaxValue),
                time           = DateTime.Now,
                shiftNumber    = (uint) rnd.Next(1, 99),
                terminalNumber = (uint) rnd.Next(1, Int32.MaxValue),

                goodsCount = (uint) rnd.Next(1, MAX_COUNT),
                goodsPrice = Convert.ToDecimal(Math.Round(rnd.NextDouble() * MAX_PRICE, 2)),

                ndsTax = (decimal) rnd.Next(0, 20),

                cache    = (decimal) rnd.Next(1, MAX_CACHE),
                nonCache = (decimal) rnd.Next(1, MAX_CACHE),
            };

            string receiptText = $@"
                    ООО ""С 7 Трэвел Ритэйл""
109316, Регион 77, Москва, Волгоградский проспект, дом 42, корпус 9
                        ИНН 7701607660
                Место расчётов: http://www.s7.ru
                    Кассовый чек №{receipt.number:0000000000}
Приход                                             {receipt.time:dd.MM.yyy hh:mm}
Смена                                                            {receipt.shiftNumber,2}
применяемая система налогообложения                             ОСН
номер автомата                                        KKT{receipt.terminalNumber:0000000000}
признак расчетов в сети Интернет                                 да
Авиабилеты
                                                     {receipt.goodsCount,2} х {receipt.goodsPrice,9:0.00}
Наименование поставщика                    АО Авиакомпания ""Сибирь""
ИНН поставщика                                           5448100656
общая стоимость позиции с учетом скидок и наценок       {receipt.TotalPrice:11,0.00}
Ставка НДС                                                      {receipt.ndsTax,2}%
Сумма НДС                                                 {receipt.NdsAmount,9:0.00}
предмет расчета                                              ПЛАТЕЖ
способ расчета                                        ПОЛНЫЙ РАСЧЕТ
единица измерения                                            услуга
признак агента по предмету расчета                            АГЕНТ
Итог                                                      {receipt.Result,9:0.00}
НАЛИЧНЫМИ                                                 {receipt.cache,9:0.00}
БЕЗНАЛИЧНЫМИ                                              {receipt.nonCache,9:0.00}
СДАЧА                                                    {receipt.OddMoney,10:0.00}
            ";

            Console.WriteLine(receiptText);
        }
    }
}
