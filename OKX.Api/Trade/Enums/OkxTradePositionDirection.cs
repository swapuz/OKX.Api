﻿namespace OKX.Api.Trade;

/// <summary>
/// OKX Position Direction
/// </summary>
public enum OkxTradePositionDirection
{
    /// <summary>
    /// Long
    /// </summary>
    [Map("long")]
    Long = 1,

    /// <summary>
    /// Short
    /// </summary>
    [Map("short")]
    Short = -1,
}