using Asteroids.Interfaces;
using UnityEngine;


namespace Asteroids
{
    public class HealthController : iFixedUpdatable
    {

    #region PrivateData

    private GameObject _gameObject;
    private float _hp;

    #endregion


    #region Properties

    public float Hp => _hp;

    #endregion


    #region ClassLifeCycles

    public HealthController(GameObject gameObject, float hp)
    {
        _gameObject = gameObject;
        _hp = hp;
    }

    #endregion


    #region Methods

    public void GetDamage()
    {
        _hp--;
    }

    public void FixedUpdateTick()
    {
        if (_hp < 0)
            Object.Destroy(_gameObject);
    }

    #endregion

    }
}