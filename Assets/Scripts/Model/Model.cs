using ResourceClicker.Resources;
using System.Collections.Generic;

namespace ResourceClicker
{
    //Базовый класс для хранения информации и посылания команд на её отрисовку
    public abstract class Model
    {
        public Dictionary<string, int> Resources { get; protected set; }
        public int TotalResources { get; protected set; }

        protected View _view;

        public Model(View view, Resource[] resources)
        {
            _view = view;
            TotalResources = 0;

            Resources = new Dictionary<string, int>(resources.Length);
            foreach (Resource resource in resources)
                Resources.Add(resource.Name, 0);
        }

        public void ChangeResourceValue(string resource, int value)
        {
            Resources[resource] += value;
            TotalResources += value;

            _view.DisplayResource(resource, Resources[resource]);
            _view.DisplayTotal(TotalResources);
        }
    }
}