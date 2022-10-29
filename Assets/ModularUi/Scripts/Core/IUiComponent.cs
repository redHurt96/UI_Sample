using ModularUi.Scripts.Tests;

namespace ModularUi.Scripts.Core
{
    public interface IUiComponent
    {
        void SetupModel(IScreenModel model);
        void Show();
        void Hide();
    }
}