using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids
{
    public class RotationShip : iRotation
    {
        #region PrivateData

        private readonly Transform _transform;
        private int _rotationOffset;
        
        #endregion


        #region ClassLifeCycles

        public RotationShip(Transform transform, int rotationOffset)
        {
            _transform = transform;
            _rotationOffset = rotationOffset;
        }

        #endregion


        #region Method

        public void Rotation(Vector3 direction)
        {
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            _transform.transform.rotation = Quaternion.AngleAxis(angle + _rotationOffset, Vector3.forward);
        }

        #endregion
    }
}