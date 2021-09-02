using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids.Player
{
    public class PlayerInput : iUpdatable
    {
        #region PrivateData

        private float _horizontal;
        private float _vertical;
        private bool _isFireButtonPressed;
        private bool _isAccelerationButtonPressed;
        private Vector3 _mousePosition;

        #endregion


        #region Properties

        public float Horizontal => _horizontal;
        public float Vertical => _vertical;
        public bool isFireButtonPressed => _isFireButtonPressed;
        public bool isAccelerationButtonPressed => _isAccelerationButtonPressed;
        public Vector3 MousePosition => _mousePosition;

        #endregion
        
        public void UpdateTick()
        {
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");
            
            if (Input.GetButtonDown("Fire1"))
            {
                _isFireButtonPressed = true;
            }
            else
            {
                _isFireButtonPressed = false;
            }

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _isAccelerationButtonPressed = true;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _isAccelerationButtonPressed = false;
            }

            _mousePosition = Input.mousePosition;
        }
    }
}