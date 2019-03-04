using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coletrane.Player
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(CTPlayerInputs))]
    public class CTPlayerController : MonoBehaviour
    {
        private CTPlayerInputs input;

        [Header("Movement Properties")]
        public float moveSpeed = 15f;

        [Header("Rotation Properties")]
        public Transform rotationTransform;
        public float rotationLagSpeed = 10f;

        private Rigidbody playerRigidbody;
        private Vector3 moveInput;
        private Vector3 moveVelocity;
        private Vector3 finalRotationLookDir;
        private float angle;

        #region Main Methods
        // Start is called before the first frame update
        void Start()
        {
            playerRigidbody = GetComponent<Rigidbody>();
            input = GetComponent<CTPlayerInputs>();
        }

        // Update is called once per frame
        void Update()
        {
            HandleMovement();
        }

        // FixedUpdate is called every fixed framerate frame, if the MonoBehaviour is enabled.
        void FixedUpdate()
        {
            HandleLooking();
            HandlePhysics();
        }
        #endregion

        #region Helper Methods
        void HandleMovement()
        {
            moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
            moveVelocity = moveInput * moveSpeed;
        }

        void HandleLooking()
        {
            if (!rotationTransform) return;

            Vector3 playerLookDirection = input.cursorPosition - rotationTransform.position;
            playerLookDirection.y = 0f;

            finalRotationLookDir = Vector3.Lerp(finalRotationLookDir, playerLookDirection, Time.deltaTime * rotationLagSpeed);

            Debug.DrawRay(transform.position, transform.forward * 10f, Color.red, 0f, true);

            rotationTransform.rotation = Quaternion.LookRotation(finalRotationLookDir);
        }

        void HandlePhysics()
        {
            if (!playerRigidbody) return;

            playerRigidbody.velocity = moveVelocity;
        }
        #endregion
    }
}
