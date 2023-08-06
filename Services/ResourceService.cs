using System.Collections.Generic;
using System.Linq;
using ResourceAggregator.Data;
using ResourceAggregator.Models;

namespace ResourceAggregator.Services
{
    public class ResourceService : IResourceService
    {
        private readonly ApplicationDbContext _context;

        public ResourceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Resource> GetAllResources()
        {
            return _context.Resources.ToList();
        }

        public Resource GetResourceById(int id)
        {
            return _context.Resources.Find(id);
        }

        public void AddResource(Resource resource)
        {
            _context.Resources.Add(resource);
            _context.SaveChanges();
        }

        public void UpdateResource(Resource resource)
        {
            _context.Resources.Update(resource);
            _context.SaveChanges();
        }

        public void DeleteResource(int id)
        {
            var resource = _context.Resources.Find(id);
            if (resource != null)
            {
                _context.Resources.Remove(resource);
                _context.SaveChanges();
            }
        }
    }
}
