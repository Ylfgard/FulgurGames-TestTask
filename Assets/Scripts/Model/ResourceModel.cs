using ResourceClicker.Resources;
using System.Linq;
using UnityEngine;

namespace ResourceClicker
{
    //Отвечает за хранение информации
    internal class ResourceModel : Model
    {
        public ResourceModel(Resource[] resources, bool needLoadData) 
            : base(resources, needLoadData)
        {
        }

        protected override void LoadData()
        {
            var tempResources = Resources.Keys.ToList();
            foreach (var resource in tempResources)
            {
                var count = PlayerPrefs.GetInt(resource);
                Resources[resource] = count;
                TotalResources += count;
            }
        }
    }
}
