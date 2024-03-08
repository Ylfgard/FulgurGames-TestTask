using System.Collections.Generic;

namespace ResourceClicker
{
    public interface IResourcesModel
    {
        Dictionary<string, int> Resources { get; }
        int TotalResources { get; }
    }
}