using Runtime.UI.Responsive_UI;
using UnityEditor;
using UnityEngine;
namespace UIEditor.ResponsiveUIEditor
{
    [CustomEditor(typeof(ResponsiveUIManager))]
    public class ResponsiveUIManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            var uiManager = (ResponsiveUIManager)target;
            if (GUILayout.Button("Assign Changed Resolution Event"))
            {
                uiManager.SubscribeToChangedResolution();
            }
        }
    }
}
