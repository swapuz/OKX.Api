﻿namespace OKX.Api.Block;

/// <summary>
/// OKX Block RFQ
/// </summary>
public class OkxBlockRfq
{
    /// <summary>
    /// The timestamp the RFQ was created. Unix timestamp format in milliseconds.
    /// </summary>
    [JsonProperty("cTime")]
    public long CreateTimestamp { get; set; }

    /// <summary>
    /// The timestamp the RFQ was created.
    /// </summary>
    [JsonIgnore]
    public DateTime CreateTime => CreateTimestamp.ConvertFromMilliseconds();

    /// <summary>
    /// The timestamp the RFQ was last updated. Unix timestamp format in milliseconds.
    /// </summary>
    [JsonProperty("uTime")]
    public long? UpdateTimestamp { get; set; }

    /// <summary>
    /// The timestamp the RFQ was last updated.
    /// </summary>
    [JsonIgnore]
    public DateTime? UpdateTime => UpdateTimestamp?.ConvertFromMilliseconds();

    /// <summary>
    /// The status of the RFQ.
    /// Valid values can be active canceled pending_fill filled expired traded_away failed.
    /// traded_away only applies to Maker
    /// </summary>
    [JsonProperty("state")]
    public OkxBlockState State { get; set; }

    /// <summary>
    /// Reasons of state. Valid values can be mmp_canceled.
    /// </summary>
    [JsonProperty("reason")]
    public string Reason { get; set; } = string.Empty;

    /// <summary>
    /// The list of counterparties traderCode the RFQ was broadcast to.
    /// </summary>
    [JsonProperty("counterparties")]
    public List<string> Counterparties { get; set; } = [];

    /// <summary>
    /// The timestamp the RFQ expires. Unix timestamp format in milliseconds.
    /// If all legs are options, the RFQ will expire after 10 minutes; otherwise, the RFQ will expire after 2 minutes.
    /// </summary>
    [JsonProperty("validUntil")]
    public long? ValidUntilTimestamp { get; set; }

    /// <summary>
    /// The timestamp the RFQ expires.
    /// If all legs are options, the RFQ will expire after 10 minutes; otherwise, the RFQ will expire after 2 minutes.
    /// </summary>
    [JsonIgnore]
    public DateTime? ValidUntilTime => ValidUntilTimestamp?.ConvertFromMilliseconds();

    /// <summary>
    /// Client-supplied RFQ ID. This attribute is treated as client sensitive information. It will not be exposed to the Maker, only return empty string.
    /// </summary>
    [JsonProperty("clRfqId")]
    public string ClientRfqId { get; set; } = string.Empty;

    /// <summary>
    /// Whether the RFQ can be partially filled provided that the shape of legs stays the same.
    /// </summary>
    [JsonProperty("allowPartialExecution")]
    public bool AllowPartialExecution { get; set; }

    /// <summary>
    /// A unique identifier of taker.
    /// </summary>
    [JsonProperty("traderCode")]
    public string TraderCode { get; set; } = string.Empty;

    /// <summary>
    /// The unique identifier of the RFQ generated by system.
    /// </summary>
    [JsonProperty("rfqId")]
    public string RfqId { get; set; } = string.Empty;

    /// <summary>
    /// An Array of objects containing each leg of the RFQ.
    /// </summary>
    [JsonProperty("legs")]
    public List<OkxBlockLegResponse> Legs { get; set; } = [];
}
