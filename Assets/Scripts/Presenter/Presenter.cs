namespace ResourceClicker
{
    //������� ����� ��� �������� ����������� ������� ������
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