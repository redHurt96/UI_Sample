using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ModularUi.Scripts.Core
{
    internal class ComponentsCreator
    {
        private readonly List<IUiComponent> _createdComponents = new();

        public IUiComponent Get(Type type)
        {
            IUiComponent component = null;
            
            if (!_createdComponents.Exists(x => x.GetType() == type))
            {
                component = Create(type);
                _createdComponents.Add(component);
            }
            else
            {
                component = _createdComponents.Find(x => x.GetType() == type);
            }

            return component;
        }

        private IUiComponent Create(Type type)
        {
            GameObject origin = Resources.Load(type.Name) as GameObject;
            origin.SetActive(false);
            
            GameObject instance = Object.Instantiate(origin);
            
            return instance.GetComponent<IUiComponent>();
        }
    }
}