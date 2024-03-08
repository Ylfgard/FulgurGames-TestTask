namespace ResourceClicker
{
    //������� ����� ��� �������� ����������� ������� ������
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