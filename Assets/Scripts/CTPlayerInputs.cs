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
        public Vector3 cursorNormal { get; private set; }

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
            Gizmos.DrawSphere(cursorPosition, 0.5f);
        }
        #endregion

        #region Helper Methods
        protected virtual void HandleInputs()
        {
            Ray screenRay = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(screenRay, out hit))
            {
                cursorPosition = hit.point;
                cursorNormal = hit.normal;
            }
        }
        #endregion
    }
}
