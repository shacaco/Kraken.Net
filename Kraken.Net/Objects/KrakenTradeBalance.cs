using Newtonsoft.Json;

namespace Kraken.Net.Objects
{
    /// <summary>
    /// Trade balance info
    /// </summary>
    public class KrakenTradeBalance
    {
        /// <summary>
        /// Equivalent balance (combined balance of all currencies)
        /// </summary>
        [JsonProperty("eb")]
        public decimal CombinedBalance { get; set; }
        /// <summary>
        /// Trade balance (combined balance of all equity currencies)
        /// </summary>
        [JsonProperty("tb")]
        public decimal TradeBalance { get; set; }
        /// <summary>
        /// Margin amount of open positions
        /// </summary>
        [JsonProperty("m")]
        public decimal MarginOpenPositions { get; set; }
        /// <summary>
        /// Unrealized net profit/loss of open positions
        /// </summary>
        [JsonProperty("n")]
        public decimal OpenPositionsUnrealizedNetProfit { get; set; }
        /// <summary>
        /// Cost basis for open positions
        /// </summary>
        [JsonProperty("c")]
        public decimal OpenPositionsCostBasis { get; set; }
        /// <summary>
        /// Current floating valuation of open positions
        /// </summary>
        [JsonProperty("v")]
        public decimal OpenPositionsValuation { get; set; }
        /// <summary>
        /// Equity: trade balance + unrealized net profit/loss
        /// </summary>
        [JsonProperty("e")]
        public decimal Equity { get; set; }
        /// <summary>
        /// Free margin: Equity - initial margin (maximum margin available to open new positions)
        /// </summary>
        [JsonProperty("mf")]
        public decimal FreeMargin { get; set; }
        /// <summary>
        /// Margin level: (equity / initial margin) * 100
        /// </summary>
        [JsonProperty("ml")]
        public decimal MarginLevel { get; set; }
    }
}
