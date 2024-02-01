using Nova;
using System.Linq;
using UnityEngine;
namespace Runtime.UI.Responsive_UI
{
    [System.Serializable]
    public class ResponsiveUIMenu
    {
        public string Name;
        public UIBlock2D CurrentUIMenu;
        public UIMenuTemplate[] MenuTemplates;
        private bool _currentUIState;
        
        public void ChangeTemplate(string breakPointBreakpointName)
        {
            _currentUIState = CurrentUIMenu.gameObject.activeSelf;
            CurrentUIMenu.gameObject.SetActive(false);
            CurrentUIMenu = MenuTemplates.First(x=>x.BreakpointName == breakPointBreakpointName).UITemplate;
            CurrentUIMenu.gameObject.SetActive(_currentUIState);
        }
    }
}