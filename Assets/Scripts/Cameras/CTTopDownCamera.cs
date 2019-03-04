using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coletrane.Cameras
{
    public class CTTopDownCamera : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float height = 10f;
        [SerializeField] private float distance = 20f;
        [SerializeField] private float angle = 45f;
        [SerializeField] private float smoothness = 0.5f;

        private Vector3 refVelocity;

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

            // Build rotated vector
            Vector3 rotatedVector = Quaternion.AngleAxis(angle, Vector3.up) * worldPosition;

            // Move camera
            Vector3 flatTargetPosition = target.position;
            flatTargetPosition.y = 0f;

            Vector3 finalPosition = flatTargetPosition + rotatedVector;
            Debug.DrawLine(target.position, finalPosition, Color.blue);

            transform.position = Vector3.SmoothDamp(transform.position, finalPosition, ref refVelocity, smoothness);
            transform.LookAt(flatTargetPosition);
        }
        #endregion
    }
}
