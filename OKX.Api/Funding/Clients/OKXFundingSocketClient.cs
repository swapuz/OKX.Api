﻿namespace OKX.Api.Funding;

/// <summary>
/// OKX WebSocket Api Funding Account Client
/// </summary>
public class OkxFundingSocketClient(OKXWebSocketApiClient root)
{
    // Internal
    internal OKXWebSocketApiClient _ { get; } = root;

    // TODO: Deposit info channel
    // TODO: Withdrawal info channel
}