using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coletrane.Player
{
    public class CTPlayerController : MonoBehaviour
    {
        public float moveSpeed;
        private Rigidbody playerRigidbody;
        private Vector3 moveInput;
        private Vector3 moveVelocity;

        #region Main Methods
        // Start is called before the first frame update
        void Start()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            HandleMovement();
        }

        // FixedUpdate is called every fixed framerate frame, if the MonoBehaviour is enabled.
        void FixedUpdate()
        {
            HandlePhysics();
        }
        #endregion

        #region Helper Methods
        void HandleMovement()
        {
            moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
            moveVelocity = moveInput * moveSpeed;
        }

        void HandlePhysics()
        {
            playerRigidbody.velocity = moveVelocity;
        }
        #endregion
    }
}
