using ResourceClicker.Resources;
using System.Collections.Generic;
using UnityEngine;

namespace ResourceClicker
{
    //Базовый класс для хранения информации и посылания команд на её отрисовку
    public abstract class Model : IResourcesModel, IResourcesChanger
    {
        public Dictionary<string, int> Resources { get; protected set; }
        public int TotalResources { get; protected set; }

        public Model(Resource[] resources, bool needLoadData)
        {
            TotalResources = 0;

            Resources = new Dictionary<string, int>(resources.Length);
            foreach (Resource resource in resources)
                Resources.Add(resource.Name, 0);
            
            if (needLoadData)
                LoadData();
        }

        public void ChangeResourceValue(string resource, int value)
        {
            Resources[resource] += value;
            TotalResources += value;
            Save();
        }

        protected abstract void LoadData();

        protected void Save()
        {
            foreach (var resource in Resources.Keys)
                PlayerPrefs.SetInt(resource, Resources[resource]);
        }
    }
}