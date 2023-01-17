using Traversal.Core.UnitOfWorks;
using Traversal.Repository.Concretes;

namespace Traversal.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TraversalContext _context;

        public UnitOfWork(TraversalContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
