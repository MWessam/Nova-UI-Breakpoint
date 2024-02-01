using Nova;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace Runtime.UI.Responsive_UI
{
    [ExecuteAlways]
    public class ResponsiveUIManager : MonoBehaviour
    {
        [SerializeField]
        private Breakpoints[] _breakPoints;
        private Breakpoints _currentBreakpoint;
        
        /// <summary>
        ///  Check resolution, if it reaches breakpoint, update ui template.
        /// </summary>
        /// <param name="resolution"> Resolution handed by the window resizer event.</param>
        private void CheckBreakpoint(Vector2 resolution)
        {
            foreach (var breakPoint in _breakPoints)
            {
                _currentBreakpoint ??= _breakPoints[0];
                if (!Breakpoints.IsBreakpointChange(resolution, breakPoint) || breakPoint.BreakpointName == _currentBreakpoint.BreakpointName)
                    continue;
                breakPoint.UIRoot.gameObject.SetActive(true);
                _currentBreakpoint.UIRoot.gameObject.SetActive(false);
                _currentBreakpoint = breakPoint;
                return;
            }
        }
        public void SubscribeToChangedResolution()
        {
            WindowResizeManager.AssignResizeMethod(CheckBreakpoint);
            _currentBreakpoint = null;
        }
    }
}