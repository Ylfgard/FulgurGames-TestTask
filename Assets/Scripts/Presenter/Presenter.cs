namespace ResourceClicker
{
    //Ѕазовый класс дл€ объектов выполн€ющих игровую логику
    public abstract class Presenter
    {
        protected Model _model;

        public Presenter(Model model)
        {
            _model = model;
        }

        public abstract void OnResourceButtonClicked(string resource);
    }
}