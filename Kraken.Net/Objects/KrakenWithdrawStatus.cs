using CryptoExchange.Net.Converters;
using Kraken.Net.Converters;
using Newtonsoft.Json;
using System;

namespace Kraken.Net.Objects
{
    /// <summary>
    /// Withdraw info
    /// </summary>
    public class KrakenWithdrawStatus
    {
        /// <summary>
        /// Method that will be used
        /// </summary>
        public string Method { get; set; } = string.Empty;
        /// <summary>
        /// Asset Class
        /// </summary>
        [JsonProperty("aclass")]
        public string AssetClass { get; set; } = string.Empty;
        /// <summary>
        /// Asset
        /// </summary>
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// Reference id
        /// </summary>
        [JsonProperty("refid")]
        public string ReferenceId { get; set; } = string.Empty;
        /// <summary>
        /// Transaction id
        /// </summary>
        [JsonProperty("txid")]
        public string TransactionId { get; set; } = string.Empty;
        /// <summary>
        /// Info about the transaction
        /// </summary>
        [JsonProperty("info")]
        public string TransactionInfo { get; set; } = string.Empty;
        /// <summary>
        /// The amount involved in the deposit
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// The fee paid for the deposit
        /// </summary>
        public decimal Fee { get; set; }
        /// <summary>
        /// The timestamp
        /// </summary>
        [JsonConverter(typeof(TimestampSecondsConverter))]
        [JsonProperty("time")]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Status of the transaction
        /// </summary>
        [JsonConverter(typeof(TransactionStatusEnumConverter))]
        public KrakenTransactionStatusEnum Status { get; set; }
    }
}
