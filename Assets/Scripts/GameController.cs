using System;
using System.Collections.Generic;
using Asteroids.Interfaces;
using UnityEngine;


namespace Asteroids
{
    public class GameController : MonoBehaviour
    {
        #region PrivateData

        private List<iUpdatable> _updatables = new List<iUpdatable>();

        #endregion


        #region UnityMethods

        private void Update()
        {
            foreach (var t in _updatables)
            {
                t.UpdateTick();
            }
        }

        #endregion
    }
}

