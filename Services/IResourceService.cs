using System.Collections.Generic;
using ResourceAggregator.Models;

namespace ResourceAggregator.Services
{
    public interface IResourceService
    {
        IEnumerable<Resource> GetAllResources();
        Resource GetResourceById(int id);
        void AddResource(Resource resource);
        void UpdateResource(Resource resource);
        void DeleteResource(int id);
    }
}
