using UnityEngine;

namespace Asteroids.Interfaces
{
    public interface iMove
    {
        float Speed { get;  }
        void Move(float horizontal, float vertical);
    }
}