using ModularUi.Scripts.Core;
using UnityEngine;

namespace ModularUi.Scripts.Tests
{
    public class GachaScrollComponent : MonoBehaviour, IUiComponent
    {
        private IScreenModel _model;

        public void SetupModel(IScreenModel model)
        {
            _model = model;
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}