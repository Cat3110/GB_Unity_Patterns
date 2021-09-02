using UnityEngine;


namespace Asteroids.Player
{
    public sealed class PlayerInitializator
    {
        #region ClassLifeCycles

        public PlayerInitializator(GameController gameController, PlayerModel playerModel)
        {
            var spawnedPlayer =
                Object.Instantiate(playerModel.PlayerPrefab, playerModel.StartPosition, Quaternion.identity);
            playerModel.PlayerView = spawnedPlayer;

            var playerInput = new PlayerInput();
            var playerHealthController = new HealthController(spawnedPlayer, playerModel.Health);
            var playerController = new PlayerController(playerModel, playerInput, playerHealthController);
            
            gameController.AddUpdatable(playerInput);
            gameController.AddUpdatable(playerController);
            gameController.AddFixedUpdatable(playerController);
            gameController.AddFixedUpdatable(playerHealthController);
        }

        #endregion
    }
}