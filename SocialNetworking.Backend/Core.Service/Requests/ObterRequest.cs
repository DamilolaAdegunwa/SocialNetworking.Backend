﻿using Core.Service.Core;
using Domain.Entity;

namespace Core.Service.Requests
{
    public class ObterRequest<TResponse> : IRequestUser<TResponse>
    {
        public User User { get; set; }
        public ulong Id { get; set; }
        public string Parameter { get; set; }
    }
}
