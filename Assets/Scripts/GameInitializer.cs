using UnityEngine;
using ResourceClicker.Resources;

namespace ResourceClicker
{
    //Входная точка в программу
    //Проводит стартовую инициализацию объектов
    internal class GameInitializer : MonoBehaviour
    {
        [SerializeField] private ResourceTextView _resourceView;
        [SerializeField] private Resource[] resources;
        [SerializeField] private bool _needLoadData;

        private void Awake()
        {
            var model = new ResourceModel(resources, _needLoadData);
            var presenter = new OnePerClickPresenter(model, model, _resourceView);
            _resourceView.Init(presenter, model);
        }
    }
}