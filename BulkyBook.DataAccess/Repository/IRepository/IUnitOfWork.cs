using System;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IApplicationUserRepository ApplicationUser { get; }
        ICompanyRepository Company { get; }
        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; }
        ISP_Call SP_Call { get; }
        void Save();
    }
}
