using System;
using System.Collections.Generic;
using Implementation;

namespace Core
{
    public class UIManager
    {
        private readonly ComponentsCreator _creator = new();
        
        public void Show(ShopScreen screen, ShopScreenModel shopScreenModel)
        {
            foreach (Type type in screen.Components)
            {
                IUiComponent component = _creator.Create(type);
                ShownComponents.Add(component);
            }
        }

        public List<IUiComponent> ShownComponents = new();
    }
}