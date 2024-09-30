﻿namespace OKX.Api.Financial.OnChainEarn;

/// <summary>
/// OKX Financial OnChainEarning Type
/// </summary>
public enum OkxFinancialOnChainEarnEarningType
{
    /// <summary>
    /// Estimated earning
    /// </summary>
    [Map("0")]
    EstimatedEarning,

    /// <summary>
    /// Cumulative earning
    /// </summary>
    [Map("1")]
    CumulativeEarning,
}