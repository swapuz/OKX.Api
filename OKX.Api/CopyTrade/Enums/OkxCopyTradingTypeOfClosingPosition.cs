﻿namespace OKX.Api.CopyTrade;

/// <summary>
/// OKX Copy Trading Sub Position Type
/// </summary>
public enum OkxCopyTradingTypeOfClosingPosition
{
    /// <summary>
    /// Close position partially
    /// </summary>
    [Map("1")]
    ClosePositionPartially = 1,

    /// <summary>
    /// Close all
    /// </summary>
    [Map("2")]
    CloseAll = 2
}