using UnityEngine;


namespace Asteroids.Player
{
    public class PlayerBarrel
    {
        #region PrivateData

        private DefaultBulletModel _defaultBulletModel;

        #endregion


        #region ClassLifeCycles

        public PlayerBarrel(DefaultBulletModel defaultBulletModel)
        {
            _defaultBulletModel = defaultBulletModel;
        }

        #endregion
        
        
        #region Methods

        public void Shoot(Transform playerTransform)
        {
            var temAmmunition = Object.Instantiate(_defaultBulletModel.DefaultBulletPrefab, playerTransform.position, playerTransform.rotation);
            temAmmunition.GetComponent<Rigidbody>().AddForce(playerTransform.up * _defaultBulletModel.BulletForce);
        }

        #endregion
    }
}