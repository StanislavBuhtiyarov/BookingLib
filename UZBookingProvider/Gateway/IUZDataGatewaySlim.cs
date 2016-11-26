﻿using System;
using System.Threading.Tasks;
using CITR.UZBookingProvider.Domain;

namespace CITR.UZBookingProvider.Gateway
{
    public interface IUZDataGatewaySlim: IDisposable
    {
        Task<UZStationSet> GetStations(string request);
    }
}
