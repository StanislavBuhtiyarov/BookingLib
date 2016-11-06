﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UZProvider
{
    interface IHttpRequestExecutor<T>: IDisposable
    {
        string Cookies { get; }

        Task InitConnection();

        Task<string> GetAsync(string addressSuffix);

        Task<string> PostAsync(string addressSuffix, T model);
    }
}
