using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coletrane.Cameras
{
    public class CTTopDownCamera : MonoBehaviour
    {
        public Transform target;
        public float height = 10f;
        public float distance = 20f;

        #region Main Methods
        // Start is called before the first frame update
        void Start()
        {
            HandleCamera();
        }

        // Update is called once per frame
        void Update()
        {
            HandleCamera();
        }
        #endregion

        #region Helper Methods
        protected virtual void HandleCamera()
        {
            if (!target) return;

            // Build world position vector
            Vector3 worldPosition = (Vector3.forward * -distance) + (Vector3.up * height);

            // Move camera
            Vector3 finalPosition = (new Vector3(target.position.x, 0f, target.position.z)) + worldPosition;
            Debug.DrawLine(target.position, finalPosition, Color.blue);

            transform.position = finalPosition;
            transform.LookAt(target.position - new Vector3(0f, 0f, height / 7.5f));
        }
        #endregion
    }
}
