﻿using System.Threading;
using System.Threading.Tasks;

namespace XProject.Contract.Service
{
    public interface IBootstrapperService
    {
        /// <summary>
        ///     Initial Database, Background Services and so on.
        /// </summary>
        Task InitialAsync(CancellationToken cancellationToken = default);

        /// <summary>
        ///     Rebuild caching, configuration.
        /// </summary>
        Task RebuildAsync(CancellationToken cancellationToken = default);
    }
}