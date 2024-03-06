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

        private void Awake()
        {
            var model = new ResourceModel(_resourceView, resources);
            var presenter = new OnePerClickPresenter(model);
            _resourceView.Init(presenter, model);
        }
    }
}