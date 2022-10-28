using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Core
{
    internal class ComponentsCreator
    {
        public IUiComponent Create(Type type) =>
            Object
                .Instantiate(Resources.Load(type.Name) as GameObject)
                .GetComponent<IUiComponent>();
    }
}