﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.MerchandiseService.Models;

namespace OzonEdu.MerchandiseService.Services.Interfaces
{
    public interface IMerchandiseService
    {
        Task<MerchIssueRequestStatus> IssueMerchToEmployee(long employeeId, string merchPackName, CancellationToken token);

        Task<List<MerchPackInStatus>> GetIssuedMerchToEmployee(long employeeId, CancellationToken token);

        Task<MerchPack?> GetMerchPackContent(string merchPackName, CancellationToken token);
    }
}