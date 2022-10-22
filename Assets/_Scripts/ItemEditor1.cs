using UnityEngine;
using UnityEditor;

namespace Course
{
    [UnityEditor.CustomEditor(typeof(Item))]
    public class ItemEditor : Editor
    {
        private Item currentTarget;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            currentTarget = (Item)target;
            GUILayout.Space(10);
            EditorGUI.BeginDisabledGroup(EditorApplication.isPlaying);
            string buttonText = EditorApplication.isPlaying ? "Consume (Only in Editor Mode" : "Consume";
            if (isTargetReady())
            {

                if (!EditorApplication.isPlaying)
                {
                    GUILayout.Box($"Data: {currentTarget.data.title} " +
                                  $"(${currentTarget.data.price})");
                }

                if (GUILayout.Button(buttonText, GUILayout.Height(30)))
                {
                    currentTarget.Consume();
                }

                EditorGUI.EndDisabledGroup();
            }
            else
            {
                EditorGUILayout.HelpBox($"Error: {GetErrorMessage()}",MessageType.Error);
            }
        }

        private bool isTargetReady()
        {
            return
                currentTarget.data &&
                currentTarget.itemImg &&
                currentTarget.itemPriceTxt &&
                currentTarget.itemTitleTxt;
            
        }

        private string GetErrorMessage()
        {
            if (!currentTarget.data) return "Data Empty!";
            if (!currentTarget.itemImg) return "Image Reference Empty!";
            if (!currentTarget.itemTitleTxt) return "Title Reference Empty!";
            if (!currentTarget.itemPriceTxt) return "Price Reference Empty!";
            return "UnKnow";
        }
    }
}
