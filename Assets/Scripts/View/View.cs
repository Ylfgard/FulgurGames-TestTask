using ResourceClicker.Resources;
using TMPro;
using UnityEngine;

namespace ResourceClicker
{
    //Базовый класс отвечающих за отображение объектов
    public abstract class View : MonoBehaviour
    {
        [SerializeField] protected TextMeshProUGUI _textTotal;

        protected Presenter _presenter;
        protected Model _model;

        public void Init(Presenter presenter, Model model)
        {
            _presenter = presenter;
            _model = model;
        }

        public abstract void DisplayResource(string resource, int count);

        public virtual void DisplayTotal(int totalResources)
        {
            _textTotal.text = totalResources.ToString();
        }
    }
}
