using Nova;
using System;
using UnityEngine;
namespace Runtime.UI.Responsive_UI
{
    [ExecuteInEditMode]
    public class WindowResizeManager : MonoBehaviour
    {
        public static event Action<Vector2> OnWindowResize;
        private int _currentWidth;
        private int _currentHeight;
        private void Update()
        {
            if (_currentWidth == Screen.width && _currentHeight == Screen.height)
                return;
            _currentHeight = Screen.height;
            _currentWidth = Screen.width;
            Vector2 newResolution = new Vector2(_currentWidth, _currentHeight) * (150 / Screen.dpi);
            OnWindowResize?.Invoke(newResolution);
            Debug.Log(newResolution);
        }
        public static void AssignResizeMethod(Action<Vector2> checkBreakpoint)
        {
            OnWindowResize = null;
            OnWindowResize += checkBreakpoint;
        }
    }
}