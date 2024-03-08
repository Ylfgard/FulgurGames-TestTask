using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceClicker
{
    //Отвечает за обработку нажатия кнопки ресурса
    public class OnePerClickPresenter : Presenter, IResourceClicker
    {
        public OnePerClickPresenter(IResourcesModel model, IResourcesChanger changer, View view)
            : base(model, changer, view)
        {
        }

        public void OnResourceButtonClicked(string resource)
        {
            _changer.ChangeResourceValue(resource, 1);

            _view.DisplayResource(resource, _model.Resources[resource]);
            _view.DisplayTotal(_model.TotalResources);
        }
    }
}
