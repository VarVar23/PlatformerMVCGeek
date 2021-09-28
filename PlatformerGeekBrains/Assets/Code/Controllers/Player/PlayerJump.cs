using UnityEngine;

namespace Platformer
{
    public class PlayerJump
    {
        private CheckCollision _checkCollisionPlayer;
        private LevelObjectView _playerView;
        private InputManager _inputManager;
        private Constance _constance;
        private bool _doJump;

        public PlayerJump(LevelObjectView playerView, InputManager inputManager, Constance constance)
        {
            _playerView = playerView;
            _inputManager = inputManager;
            _constance = constance;

            _checkCollisionPlayer = new CheckCollision(playerView.ColliderView);
        }

        public void Update()
        {
            _doJump = _inputManager.Jump > 0;
            _checkCollisionPlayer.Update();

            if (_doJump && _checkCollisionPlayer.DownCollider)
            {
                StartJump();
            }
        }

        private void StartJump()
        {
            _playerView.Rigidbody2DView.velocity = new Vector3(_playerView.Rigidbody2DView.velocity.x, _constance.PlayerJumpSpeed);
        }
    }
}
