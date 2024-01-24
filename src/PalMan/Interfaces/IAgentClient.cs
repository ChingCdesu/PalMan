﻿using PalMan.Configuration;
using PalMan.Shared.Abstract;
using PalMan.Shared.Models;

namespace PalMan.Interfaces;

public interface IAgentClient
{
    public Task<bool> PingAsync(PalManAgent agent);

    public Task<AgentResponse<TResponse>> RequestAsync<TRequest, TResponse>(PalManAgent agent, AgentRequest<TRequest> request) where TResponse : IAgentResponseData, new() where TRequest : IAgentRequestData, new();
}
