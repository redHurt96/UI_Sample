using System.Collections;
using System.Linq;
using Core;
using Implementation;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ScreensTests
    {
        [UnityTest]
        public IEnumerator WhenScreenCalled_Appear_AllHisComponents()
        {
            var uiManager = new UIManager();
            var screen = new ShopScreen();
            var shopScreenModel = new ShopScreenModel();

            uiManager.Show(screen, shopScreenModel);
        
            yield return new WaitForSeconds(shopScreenModel.AppearTime);
            
            Assert.AreEqual(uiManager.ShownComponents.Count, screen.Components.Length);

            foreach (IUiComponent component in uiManager.ShownComponents)
                Assert.IsTrue(screen.Components.Any(x => x == component.GetType()));
        }

        [UnityTest]
        public IEnumerator WhenSecondScreenCalled_Shown_OnlyHisComponents()
        {
            
        }

        [UnityTest]
        public IEnumerator DoubleComponents_DoesntDisappear_WhenScreensChanging()
        {
            
        }
    }
}
