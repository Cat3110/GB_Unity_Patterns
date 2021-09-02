using System;
using Asteroids.Interfaces;
using UnityEngine;


namespace Asteroids
{
    public class CollisionDetection : MonoBehaviour
    {
        #region PrivateData

        private bool _isCollisionDetected;

        #endregion


        #region Properties

        public bool IsCollisionDetected => _isCollisionDetected;

        #endregion


        #region UnityMethods

        private void OnCollisionEnter(Collision other)
        {
            _isCollisionDetected = true;
        }

        private void OnCollisionExit(Collision other)
        {
            _isCollisionDetected = false;
        }

        #endregion
    }
}

