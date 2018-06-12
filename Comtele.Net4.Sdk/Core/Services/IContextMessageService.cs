﻿using Comtele.Net4.Sdk.Core.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Comtele.Net4.Sdk.Core.Services
{
    public interface IContextMessageService
    {
        ServiceResult<object> Send(string sender, string contextRuleName, params string[] receivers);
        Task<ServiceResult<object>> SendAsync(string sender, string contextRuleName, params string[] receivers);

        ServiceResult<object> Schedule(string sender, string contextRuleName, DateTime scheduleDate, params string[] receivers);
        Task<ServiceResult<object>> ScheduleAsync(string sender, string contextRuleName, DateTime scheduleDate, params string[] receivers);

        ServiceResult<List<ContextReportResource>> GetReport(DateTime startDate, DateTime endDate);
        ServiceResult<List<ContextReportResource>> GetReport(DateTime startDate, DateTime endDate, string sender);
        ServiceResult<List<ContextReportResource>> GetReport(DateTime startDate, DateTime endDate, string sender, string contextRuleName);

        Task<ServiceResult<List<ContextReportResource>>> GetReportAsync(DateTime startDate, DateTime endDate);
        Task<ServiceResult<List<ContextReportResource>>> GetReportAsync(DateTime startDate, DateTime endDate, string sender);
        Task<ServiceResult<List<ContextReportResource>>> GetReportAsync(DateTime startDate, DateTime endDate, string sender, string contextRuleName);
    }
}
