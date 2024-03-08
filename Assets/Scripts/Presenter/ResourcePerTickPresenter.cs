using ResourceClicker.Resources;

namespace ResourceClicker
{
    public class ResourcePerTickPresenter : Presenter, IResourcePerTick
    {


        public ResourcePerTickPresenter(IResourcesModel model, IResourcesChanger changer, View view)
            : base(model, changer, view)
        {
        }

        public void Tick(float deltaTime)
        {

        }
    }
}
