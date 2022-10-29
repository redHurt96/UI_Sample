using System;
using System.Collections.Generic;
using System.Linq;
using ModularUi.Scripts.Tests;

namespace ModularUi.Scripts.Core
{
    public class UIManager
    {
        public readonly List<IUiComponent> ShownComponents = new();
        
        private readonly ComponentsCreator _creator = new();
        
        public void Show(IScreen screen, IScreenModel model)
        {
            ShowComponents(screen, model);
            HideUselessComponents(screen);
        }

        private void ShowComponents(IScreen screen, IScreenModel model)
        {
            foreach (Type type in screen.Components)
            {
                IUiComponent component;

                if (ShownComponents.Exists(x => x.GetType() == type))
                {
                    component = ShownComponents
                        .Find(x => x.GetType() == type);
                }
                else
                {
                    component = _creator.Get(type);
                    ShownComponents.Add(component);
                }

                component.SetupModel(model);
                component.Show();
            }
        }

        private void HideUselessComponents(IScreen screen)
        {
            IUiComponent[] componentsToHide = ShownComponents
                .Where(x => !screen.Components.Contains(x.GetType()))
                .ToArray();

            foreach (IUiComponent component in componentsToHide)
            {
                component.Hide();
                ShownComponents.Remove(component);
            }
        }
    }
}