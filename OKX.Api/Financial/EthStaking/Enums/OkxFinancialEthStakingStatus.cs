﻿namespace OKX.Api.Financial.EthStaking;

/// <summary>
/// OKX Financial Eth Staking Status
/// </summary>
public enum OkxFinancialEthStakingStatus
{
    /// <summary>
    /// Pending
    /// </summary>
    [Map("pending")]
    Pending = 1,

    /// <summary>
    /// Success
    /// </summary>
    [Map("success")]
    Success = 2,

    /// <summary>
    /// Failed
    /// </summary>
    [Map("failed")]
    Failed = 3,
}