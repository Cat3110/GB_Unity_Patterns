using Asteroids.Interfaces;
using UnityEngine;


namespace Asteroids
{
    public class VelocityMove : iMove
    {
        #region PrivateData

        private readonly Rigidbody _rigidbody;

        #endregion


        #region Properties

        public float Speed { get; protected set; }

        #endregion


        #region ClassLifeCycles

        public VelocityMove(Rigidbody rigidbody, float speed)
        {
            _rigidbody = rigidbody;
            Speed = speed;
        }

        #endregion


        #region Methods

        public void Move(float horizontal, float vertical)
        {
            _rigidbody.velocity = new Vector3(horizontal * Speed, vertical * Speed, 0);
        }

        #endregion
        
    }
}