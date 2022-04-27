using Invedia.DI.Attributes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XProject.Contract.Repository.Infrastructure;
using XProject.Contract.Repository.Interface;
using XProject.Contract.Repository.Models;
using XProject.Contract.Service.Interface;

namespace XProject.Service
{
    [ScopedDependency(ServiceType = typeof(IWorkingTimeService))]
    public class WorkingTimeService : Base.Service, IWorkingTimeService
    {
        private readonly IWorkingTimeRepository _workingDailyRepo;
        private readonly IUnitOfWork _uof;
        public WorkingTimeService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _workingDailyRepo = serviceProvider.GetRequiredService<IWorkingTimeRepository>();
            _uof = serviceProvider.GetRequiredService<IUnitOfWork>();
        }

        public void Create(WorkingTime model)
        {
            _workingDailyRepo.Add(model);
            _uof.SaveChanges();
        }
    }
}
