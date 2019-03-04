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
        public float angle = 45f;

        #region Main Methods
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Helper Methods
        protected virtual void HandleCamera()
        {

        }
        #endregion
    }
}
