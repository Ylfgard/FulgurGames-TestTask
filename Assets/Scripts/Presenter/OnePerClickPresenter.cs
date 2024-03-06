using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceClicker
{
    //Отвечает за обработку нажатия кнопки ресурса
    public class OnePerClickPresenter : Presenter
    {
        public OnePerClickPresenter(Model model) : base(model)
        {
        }

        public override void OnResourceButtonClicked(string resource)
        {
            _model.ChangeResourceValue(resource, 1);
        }
    }
}
