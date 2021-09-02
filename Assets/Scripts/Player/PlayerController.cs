using Asteroids.Interfaces;
using UnityEngine;


namespace Asteroids.Player
{
    public sealed class PlayerController : iUpdatable, iFixedUpdatable
    {
        #region PrivateData

        private PlayerModel _playerModel;
        private iMove _move;
        private PlayerInput _playerInput;
        private PlayerBarrel _playerBarrel;
        private HealthController _playerHealthController;
        private bool _isCollisionDetected;
        private Camera _camera;
        private RotationShip _rotationShip;
        private Ship _ship;
        
        #endregion
        
        
        #region ClassLifeCycles

        public PlayerController(PlayerModel playerModel, PlayerInput playerInput, HealthController playerHealthController)
        {
            _playerModel = playerModel;
            _playerInput = playerInput;
            _move = new AccelerationMove(_playerModel.PlayerView.GetComponent<UnityEngine.Rigidbody>(), _playerModel.Speed, _playerModel.AccelerationSpeed);
            _playerBarrel = new PlayerBarrel(_playerModel.DefaultBulletModel);
            _isCollisionDetected = _playerModel.PlayerView.GetComponent<CollisionDetection>().IsCollisionDetected;
            _playerHealthController = playerHealthController;
            _camera = Camera.main;
            _rotationShip = new RotationShip(_playerModel.PlayerView.transform, _playerModel.RotationOffset);
            _ship = new Ship(_move, _rotationShip);
        }

        #endregion


        #region Methods

        public void UpdateTick()
        {
            if(_playerInput.isFireButtonPressed)
                _playerBarrel.Shoot(_playerModel.PlayerView.transform);
        }
        
        
        public void FixedUpdateTick()
        {
            if (_playerInput.isAccelerationButtonPressed)
            {
                _ship.AddAcceleration();
            }
            else
            {
                _ship.RemoveAcceleration();
            }
            
            _ship.Move(_playerInput.Horizontal, _playerInput.Vertical);
            
            _ship.Rotation(_playerInput.MousePosition - _camera.WorldToScreenPoint(_playerModel.PlayerView.transform.position));
            
            if (_isCollisionDetected)
                _playerHealthController.GetDamage();
        }

        #endregion
    }
}