﻿using OKX.Api.Financial.OnChainEarn.Converters;
using OKX.Api.Financial.OnChainEarn.Enums;

namespace OKX.Api.Financial.OnChainEarn.Models;

/// <summary>
/// OKX Financial On Chain Earn Offer
/// </summary>
public class OkxFinancialOnChainEarnOffer
{
    /// <summary>
    /// Currency type, e.g. BTC
    /// </summary>
    [JsonProperty("ccy")]
    public string Currency { get; set; }

    /// <summary>
    /// Product ID
    /// </summary>
    [JsonProperty("productId")]
    public string ProductId { get; set; }

    /// <summary>
    /// Protocol
    /// </summary>
    [JsonProperty("protocol")]
    public string Protocol { get; set; }

    /// <summary>
    /// Protocol type
    /// defi: on-chain earn
    /// </summary>
    [JsonProperty("protocolType")]
    public string ProtocolType { get; set; }

    /// <summary>
    /// Protocol term
    /// It will return the days of fixed term and will return 0 for flexible product
    /// </summary>
    [JsonProperty("term")]
    public int Term { get; set; }

    /// <summary>
    /// Estimated annualization
    /// If the annualization is 7% , this field is 0.07
    /// </summary>
    [JsonProperty("apy")]
    public decimal APY { get; set; }

    /// <summary>
    /// Whether the protocol supports early redemption
    /// </summary>
    [JsonProperty("earlyRedeem")]
    public bool EarlyRedeem { get; set; }

    /// <summary>
    /// Current target currency information available for investment
    /// </summary>
    [JsonProperty("investData")]
    public List<OkxFinancialOnChainEarnOfferInvestData> InvestData { get; set; } = [];

    /// <summary>
    /// Earning data
    /// </summary>
    [JsonProperty("earningData")]
    public List<OkxFinancialOnChainEarnOfferEarningData> EarningData { get; set; } = [];

    /// <summary>
    /// Product state
    /// </summary>
    [JsonProperty("state"), JsonConverter(typeof(OkxFinancialOnChainEarnOfferStateConverter))]
    public OkxFinancialOnChainEarnOfferState State { get; set; }

    /// <summary>
    /// Redemption Period, format in [min time,max time]
    /// </summary>
    [JsonProperty("redeemPeriod")]
    public List<string> RedeemPeriod { get; set; } = [];
}

/// <summary>
/// OKX Financial On Chain Earn Offer Invest Data
/// </summary>
public class OkxFinancialOnChainEarnOfferInvestData
{
    /// <summary>
    /// Investment currency, e.g. BTC
    /// </summary>
    [JsonProperty("ccy")]
    public string Currency { get; set; }

    /// <summary>
    /// Available balance to invest
    /// </summary>
    [JsonProperty("bal")]
    public decimal Balance { get; set; }

    /// <summary>
    /// Minimum subscription amount
    /// </summary>
    [JsonProperty("minAmt")]
    public decimal MinimumAmount { get; set; }

    /// <summary>
    /// Maximum available subscription amount
    /// </summary>
    [JsonProperty("maxAmt")]
    public decimal MaximumAmount { get; set; }
}

/// <summary>
/// OKX Financial On Chain Earn Offer Earning Data
/// </summary>
public class OkxFinancialOnChainEarnOfferEarningData
{
    /// <summary>
    /// Investment currency, e.g. BTC
    /// </summary>
    [JsonProperty("ccy")]
    public string Currency { get; set; }

    /// <summary>
    /// Earning type
    /// </summary>
    [JsonProperty("earningType"), JsonConverter(typeof(OkxFinancialOnChainEarnEarningTypeConverter))]
    public OkxFinancialOnChainEarnEarningType EarningType { get; set; }
}