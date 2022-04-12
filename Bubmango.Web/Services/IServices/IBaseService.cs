﻿using System;
using System.Threading.Tasks;
using Bupmango.Web.Models;

namespace Bubmango.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto responseModel { get; set; }

        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
