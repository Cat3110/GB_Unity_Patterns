using UnityEngine;

namespace Asteroids
{
    public class AccelerationMove : VelocityMove
    {
        #region PrivateData
        
        private readonly float _accelerationSpeed;
        private float _defaultSpeed;
        
        #endregion
        

        #region ClassLifeCycles

        public AccelerationMove(Rigidbody rigidbody, float speed, float accelerationSpeed) : base(rigidbody, speed)
        {
            _defaultSpeed = speed;
            _accelerationSpeed = accelerationSpeed;
        }

        #endregion


        #region Methods

        public void AddAcceleration()
        {
            Speed = _accelerationSpeed;
        }

        public void RemoveAcceleration()
        {
            Speed = _defaultSpeed;
        }

        #endregion
        

    }
}