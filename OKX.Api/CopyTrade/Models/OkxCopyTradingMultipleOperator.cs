﻿namespace OKX.Api.Account;

/// <summary>
/// OkxMultipleOperation
/// </summary>
public class OkxCopyTradingMultipleOperation
{
    /// <summary>
    /// Instrument ID setted successfully
    /// </summary>
    [JsonProperty("succInstId")]
    public string SuccessInstrumentIds{ get; set; } = "";

    /// <summary>
    /// Instrument ID setted unsuccessfully
    /// </summary>
    [JsonProperty("failInstId")]
    public string FailInstrumentIds { get; set; } = "";

    /// <summary>
    /// Result
    /// </summary>
    [JsonProperty("result"), JsonConverter(typeof(OkxCopyTradingMultipleOperationStatusConverter))]
    public OkxCopyTradingMultipleOperationStatus Result { get; set; }
}
