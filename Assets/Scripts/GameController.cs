using System.Collections.Generic;
using Asteroids.Interfaces;
using Asteroids.Player;
using UnityEngine;


namespace Asteroids
{
    public sealed class GameController : MonoBehaviour
    {
        #region PrivateData

        [SerializeField] private PlayerModel _playerModel;

        private List<iUpdatable> _updatables = new List<iUpdatable>();
        private List<iFixedUpdatable> _fixedUpdatables = new List<iFixedUpdatable>();

        #endregion


        #region UnityMethods

        private void Start()
        {
            new PlayerInitializator(this, _playerModel);
        }

        private void Update()
        {
            foreach (var t in _updatables)
            {
                t.UpdateTick();
            }
        }

        private void FixedUpdate()
        {
            foreach (var t in _fixedUpdatables)
            {
                t.FixedUpdateTick();
            }
        }

        #endregion


        #region Methods

        public void AddUpdatable(iUpdatable iUpdatable)
        {
            _updatables.Add(iUpdatable);
        }

        public void AddFixedUpdatable(iFixedUpdatable iFixedUpdatable)
        {
            _fixedUpdatables.Add(iFixedUpdatable);
        }

        #endregion
    }
}

