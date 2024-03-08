namespace ResourceClicker
{
    //Ѕазовый класс дл€ объектов выполн€ющих игровую логику
    public abstract class Presenter
    {
        protected IResourcesModel _model;
        protected IResourcesChanger _changer;
        protected View _view;

        public Presenter(IResourcesModel model, IResourcesChanger changer, View view)
        {
            _model = model;
            _changer = changer;
            _view = view;
        }
    }
}