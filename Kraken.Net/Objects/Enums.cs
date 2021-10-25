namespace Kraken.Net.Objects
{
    /// <summary>
    /// The time interval of kline data
    /// </summary>
    public enum KlineInterval
    {
        /// <summary>
        /// 1m
        /// </summary>
        OneMinute,
        /// <summary>
        /// 5m
        /// </summary>
        FiveMinutes,
        /// <summary>
        /// 15m
        /// </summary>
        FifteenMinutes,
        /// <summary>
        /// 30m
        /// </summary>
        ThirtyMinutes,
        /// <summary>
        /// 1h
        /// </summary>
        OneHour,
        /// <summary>
        /// 4h
        /// </summary>
        FourHour,
        /// <summary>
        /// 1d
        /// </summary>
        OneDay,
        /// <summary>
        /// 1w
        /// </summary>
        OneWeek,
        /// <summary>
        /// 15d
        /// </summary>
        FifteenDays
    }

    /// <summary>
    /// Side of an order
    /// </summary>
    public enum OrderSide
    {
        /// <summary>
        /// Buy
        /// </summary>
        Buy,
        /// <summary>
        /// Sell
        /// </summary>
        Sell
    }

    /// <summary>
    /// Order type, limited to market or limit
    /// </summary>
    public enum OrderTypeMinimal
    {
        /// <summary>
        /// Limit order
        /// </summary>
        Limit,
        /// <summary>
        /// Symbol order
        /// </summary>
        Market
    }

    /// <summary>
    /// Order type
    /// </summary>
    public enum OrderType
    {
        /// <summary>
        /// Limit order
        /// </summary>
        Limit,
        /// <summary>
        /// Symbol order
        /// </summary>
        Market,
        /// <summary>
        /// Stop market order
        /// </summary>
        StopMarket,
        /// <summary>
        /// Stop limit order
        /// </summary>
        StopLimit,
        /// <summary>
        /// Stop loss order
        /// </summary>
        StopLoss,
        /// <summary>
        /// Take profit order
        /// </summary>
        TakeProfit,
        /// <summary>
        /// Stop loss profit order
        /// </summary>
        StopLossProfit,
        /// <summary>
        /// Stop loss profit limit order
        /// </summary>
        StopLossProfitLimit,
        /// <summary>
        /// Stop loss limit order
        /// </summary>
        StopLossLimit,
        /// <summary>
        /// Take profit limit order
        /// </summary>
        TakeProfitLimit,
        /// <summary>
        /// Trailing stop order
        /// </summary>
        TrailingStop,
        /// <summary>
        /// Trailing stop limit order
        /// </summary>
        TrailingStopLimit,
        /// <summary>
        /// Stop loss and limit order
        /// </summary>
        StopLossAndLimit,
        /// <summary>
        /// Settle position
        /// </summary>
        SettlePosition
    }

    /// <summary>
    /// Status of an order
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Pending
        /// </summary>
        Pending,
        /// <summary>
        /// Active, not (fully) filled
        /// </summary>
        Open,
        /// <summary>
        /// Fully filled
        /// </summary>
        Closed,
        /// <summary>
        /// Canceled
        /// </summary>
        Canceled,
        /// <summary>
        /// Expired
        /// </summary>
        Expired
    }

    /// <summary>
    /// The type of a ledger entry
    /// </summary>
    public enum LedgerEntryType
    {
        /// <summary>
        /// Deposit
        /// </summary>
        Deposit,
        /// <summary>
        /// Withdrawal
        /// </summary>
        Withdrawal,
        /// <summary>
        /// Trade change
        /// </summary>
        Trade,
        /// <summary>
        /// Margin
        /// </summary>
        Margin,
        /// <summary>
        /// Adjustment
        /// </summary>
        Adjustment,
        /// <summary>
        /// Transfer
        /// </summary>
        Transfer,
        /// <summary>
        /// Rollover
        /// </summary>
        Rollover,
        /// <summary>
        /// Settled
        /// </summary>
        Settled
    }

    /// <summary>
    /// System status info
    /// </summary>
    public enum SystemStatus
    {
        /// <summary>
        /// Kraken is operating normally. All order types may be submitted and trades can occur.
        /// </summary>
        Online,
        /// <summary>
        /// The exchange is offline. No new orders or cancellations may be submitted.
        /// </summary>
        Maintenance,
        /// <summary>
        /// Resting (open) orders can be cancelled but no new orders may be submitted. No trades will occur.
        /// </summary>
        CancelOnly,
        /// <summary>
        /// Only post-only limit orders can be submitted. Existing orders may still be cancelled. No trades will occur.
        /// </summary>
        PostOnly
    }

    /// <summary>
    /// Withdraw Status
    /// </summary>
    public enum KrakenTransactionStatusEnum
    {
        /// <summary>
        ///All time prior to the establishment of a live transaction.  This
        ///may include, for instance, the gathering of quotations for the
        ///potential execution of a financial transaction's settlement prior
        ///to actual settlement initiation, some process of selection of a
        ///settlement path based upon a collection of such quotations, or
        ///the period prior to receiving a positive response to the finally
        ///issued request to execute the transaction.
        /// </summary>
        Initial,
        /// <summary>
        /// Subsequent to execution, but prior to the completion of settlement-related processes.
        /// </summary>
        Pending,
        /// <summary>
        /// After settlement, but prior to asbolute completion.  For instance, the period for which a settled transaction remains
        /// exposed to third party cancellation or refund/reversal procedures.
        /// </summary>
        Settled,
        /// <summary>
        /// The transaction completed successfully.
        /// </summary>
        Success,
        /// <summary>
        /// The transaction did not complete successfully.
        /// </summary>
        Failure
    }

}
