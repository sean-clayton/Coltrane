using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Coletrane.Cameras
{
    [CustomEditor(typeof(CTTopDownCamera))]
    public class CTTopDownCameraEditor : Editor
    {
        private CTTopDownCamera targetCamera;

        void OnEnable()
        {
            targetCamera = (CTTopDownCamera)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
        }

        void OnSceneGUI()
        {
            if (!targetCamera.target) return;

            Transform cameraTarget = targetCamera.target;

            Handles.color = new Color(0f, 0f, 1f, 0.15f);
            Handles.DrawSolidDisc(targetCamera.target.position, Vector3.up, targetCamera.distance);

            Handles.color = new Color(0f, 0f, 1f, 0.75f);
            Handles.DrawWireDisc(targetCamera.target.position, Vector3.up, targetCamera.distance);

            Handles.color = new Color(1f, 0f, 0f, 0.75f);
            targetCamera.distance = Handles.ScaleSlider(targetCamera.distance, cameraTarget.position, -cameraTarget.forward, Quaternion.identity, targetCamera.distance, 1f);
            targetCamera.distance = Mathf.Clamp(targetCamera.distance, 5f, float.MaxValue);

            Handles.color = new Color(0f, 0f, 1f, 0.75f);
            targetCamera.height = Handles.ScaleSlider(targetCamera.height, cameraTarget.position, Vector3.up, Quaternion.identity, targetCamera.height, 1f);
            targetCamera.height = Mathf.Clamp(targetCamera.height, 5f, float.MaxValue);

            GUIStyle labelStyle = new GUIStyle();
            labelStyle.fontSize = 16;
            labelStyle.normal.textColor = Color.white;
            labelStyle.alignment = TextAnchor.UpperCenter;

            Handles.Label(cameraTarget.position + -(cameraTarget.forward * targetCamera.distance), "Distance", labelStyle);
            Handles.Label(cameraTarget.position + (Vector3.up * targetCamera.height), "Height", labelStyle);
        }
    }
}

