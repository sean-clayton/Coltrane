using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Coletrane.Cameras
{
    public class CTCameraMenu : MonoBehaviour
    {
        [MenuItem("Coletrane/Cameras/Top Down Camera")]
        public static void CreateTopDownCamera()
        {
            GameObject[] selectedGameObjects = Selection.gameObjects;

            if (selectedGameObjects.Length != 2)
            {
                EditorUtility.DisplayDialog("Camera Tools", "You need to select two objects in order to add a top down camera.", "OK");
                return;
            }
            if (!selectedGameObjects[0].GetComponent<Camera>() || !selectedGameObjects[0].GetComponent<Camera>())
            {
                EditorUtility.DisplayDialog("Camera Tools", "You must select ONE camera.", "OK");
                return;
            }

            GameObject camera;
            Transform target;
            if (selectedGameObjects[0].GetComponent<Camera>())
            {
                camera = selectedGameObjects[0].gameObject;
                target = selectedGameObjects[1].transform;
            }
            else
            {
                camera = selectedGameObjects[1].gameObject;
                target = selectedGameObjects[0].transform;
            }
            AttachTopDownScript(selectedGameObjects[0].gameObject, selectedGameObjects[1].transform);
        }

        static void AttachTopDownScript(GameObject camera, Transform target)
        {
            CTTopDownCamera cameraScript = camera.AddComponent<CTTopDownCamera>();
            cameraScript.target = target.transform;
        }
    }

}
