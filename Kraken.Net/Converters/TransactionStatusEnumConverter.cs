using System.Collections.Generic;
using CryptoExchange.Net.Converters;
using Kraken.Net.Objects;

namespace Kraken.Net.Converters
{
    internal class TransactionStatusEnumConverter : BaseConverter<KrakenTransactionStatusEnum>
    {
        public TransactionStatusEnumConverter() : this(true) { }
        public TransactionStatusEnumConverter(bool quotes) : base(quotes) { }

        protected override List<KeyValuePair<KrakenTransactionStatusEnum, string>> Mapping => new List<KeyValuePair<KrakenTransactionStatusEnum, string>>
        {
            new KeyValuePair<KrakenTransactionStatusEnum, string>(KrakenTransactionStatusEnum.Initial, "Initial"),
            new KeyValuePair<KrakenTransactionStatusEnum, string>(KrakenTransactionStatusEnum.Pending, "Pending"),
            new KeyValuePair<KrakenTransactionStatusEnum, string>(KrakenTransactionStatusEnum.Settled, "Settled"),
            new KeyValuePair<KrakenTransactionStatusEnum, string>(KrakenTransactionStatusEnum.Success, "Success"),
            new KeyValuePair<KrakenTransactionStatusEnum, string>(KrakenTransactionStatusEnum.Failure, "Failure"),
        };
    }
}
