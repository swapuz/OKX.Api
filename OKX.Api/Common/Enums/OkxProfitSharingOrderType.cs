﻿namespace OKX.Api.Common;

/// <summary>
/// OKX Profit Sharing Order Type
/// </summary>
public enum OkxProfitSharingOrderType
{
    /// <summary>
    /// Normal order
    /// </summary>
    [Map("0")]
    NormalOrder,

    /// <summary>
    /// Copy order without profit sharing
    /// </summary>
    [Map("1")]
    CopyOrderWithoutProfitSharing,

    /// <summary>
    /// Copy order with profit sharing
    /// </summary>
    [Map("2")]
    CopyOrderWithProfitSharing,

    /// <summary>
    /// Lead order
    /// </summary>
    [Map("3")]
    LeadOrder,
}