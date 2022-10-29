using ModularUi.Scripts.Tests;
using UnityEngine;

namespace ModularUi.Scripts.Core
{
    public class DescriptionComponent : MonoBehaviour, IUiComponent
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