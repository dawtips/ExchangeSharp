using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeSharp.Traders
{
    public class TrailingStopLossTrader : Trader
    {
        public readonly decimal TrailingPercentage;

        bool TrailingIndicatorSet
        {
            get
            {
                return TrailingPercentage != 0m;
            }
        }

        public TrailingStopLossTrader(decimal percentage)
        {
            TrailingPercentage = percentage;
        }

        public override void Initialize(ExchangeTradeInfo info)
        {
            base.Initialize(info);
        }

        protected override void ProcessTrade()
        {
            throw new NotImplementedException();
        }
    }
}
