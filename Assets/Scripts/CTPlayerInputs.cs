using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coletrane.Player
{
    public class CTPlayerInputs : MonoBehaviour
    {
        [Header("Input Properties")]
        public Camera camera;

        public Vector3 cursorPosition { get; private set; }

        #region Main Methods
        // Update is called once per frame
        void Update()
        {
            if (!camera) return;

            HandleInputs();
        }

        /// <summary>
        /// Callback to draw gizmos that are pickable and always drawn.
        /// </summary>
        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(new Vector3(cursorPosition.x, cursorPosition.y - 1f, cursorPosition.z), 0.5f);
        }
        #endregion

        #region Helper Methods
        protected virtual void HandleInputs()
        {
            Ray screenRay = camera.ScreenPointToRay(Input.mousePosition);
            Plane cursorPlane = new Plane(Vector3.up, Vector3.zero);
            float rayLength;
            if (cursorPlane.Raycast(screenRay, out rayLength))
            {
                Vector3 pointToLookAt = screenRay.GetPoint(rayLength);
                cursorPosition = new Vector3(pointToLookAt.x, transform.position.y, pointToLookAt.z);
            }
        }
        #endregion
    }
}
