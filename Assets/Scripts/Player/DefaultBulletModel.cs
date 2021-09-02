using UnityEngine;

namespace Asteroids.Player
{
    [CreateAssetMenu(fileName = "DefaultBulletModel", menuName = "Data/DefaultBulletModel")]
    public class DefaultBulletModel : ScriptableObject
    {
        #region PrivateData

        [SerializeField] private GameObject _defaultBulletPrefab;
        [SerializeField] private float _bulletForce;

        #endregion


        #region Properties

        public GameObject DefaultBulletPrefab => _defaultBulletPrefab;
        public float BulletForce => _bulletForce;

        #endregion
    }
}