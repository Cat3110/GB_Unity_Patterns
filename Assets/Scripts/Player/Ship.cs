using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids.Player
{
    public class Ship : iMove, iRotation
    {
        #region PrivateData

        private iMove _moveImplementation;
        private iRotation _rotationImplementation;

        #endregion


        #region Properties

        public float Speed => _moveImplementation.Speed;

        #endregion


        #region ClassLifeCycles

        public Ship(iMove moveImplementation, iRotation rotationImplementation)
        {
            _moveImplementation = moveImplementation;
            _rotationImplementation = rotationImplementation;

        }

        #endregion


        #region Methods

        public void Move(float horizontal, float vertical)
        {
            _moveImplementation.Move(horizontal, vertical);
        }

        public void Rotation(Vector3 rotateDirection)
        {
            _rotationImplementation.Rotation(rotateDirection);
        }

        public void AddAcceleration()
        {
            if (_moveImplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.AddAcceleration();
            }
        }

        public void RemoveAcceleration()
        {
            if (_moveImplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.RemoveAcceleration();
            }
        }

        #endregion
    }
}