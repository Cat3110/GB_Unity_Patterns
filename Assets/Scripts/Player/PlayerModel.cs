using  UnityEngine;


namespace Asteroids.Player
{
    [CreateAssetMenu(fileName = "PlayerModel", menuName = "Data/PlayerModel")]
    public sealed class PlayerModel : ScriptableObject
    {
        #region PrivateData

        [SerializeField] private GameObject _playerPrefab;
        [SerializeField] private Vector3 _startPosition;
        [SerializeField] private float _speed;
        [SerializeField] private DefaultBulletModel _defaultBulletModel;
        [SerializeField] private float _health;
        [SerializeField] private float _accelerationSpeed;
        [SerializeField] private int _rotationOffset;

        private GameObject _playerView;

        #endregion
        

        #region Properties

        public GameObject PlayerPrefab => _playerPrefab;
        public Vector3 StartPosition => _startPosition;
        public float Speed => _speed;
        public DefaultBulletModel DefaultBulletModel => _defaultBulletModel;
        public float Health => _health;
        public float AccelerationSpeed => _accelerationSpeed;
        public int RotationOffset => _rotationOffset;

        public GameObject PlayerView
        {
            get => _playerView;
            set => _playerView = value;
        }

        #endregion
    }
}