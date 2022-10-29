using System;
using ModularUi.Scripts.Core;

namespace ModularUi.Scripts.Tests
{
    public class GachaScreen : IScreen
    {
        public Type[] Components => new Type[]
        {
            typeof(GachaScrollComponent),
            typeof(ImageComponent),
        };
    }
}