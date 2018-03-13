using ExchangeSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsole
{
    public class TestInstance
    {
        public void Test1()
        {
            string symbol = "ETHUSDT";

            ExchangeAPI api = new ExchangeBinanceAPI();
            ExchangeInfo exchInfo = new ExchangeInfo(api, symbol);

            bool exit = false;

            do
            {
                exchInfo.Update();
                Console.WriteLine(exchInfo.TradeInfo.Ticker.Last);

                api.RateLimit.WaitToProceed();
            }
            while (!exit);

            //SimplePeakValleyTrader trader = new SimplePeakValleyTrader();
            //trader.Initialize(binanceETI);
        }
    }
}
