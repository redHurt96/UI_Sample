using System;

namespace ModularUi.Scripts.Core
{
    public class ShopScreen : IScreen
    {
        public Type[] Components => new Type[]
        {
            typeof(DescriptionComponent),
            typeof(ImageComponent),
        };
    }

    public interface IScreen
    {
        Type[] Components { get; }
    }
}