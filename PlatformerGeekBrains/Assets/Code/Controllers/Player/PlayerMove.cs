using UnityEngine;

namespace Platformer
{
    public class PlayerMove
    {
        private CheckCollision _checkCollision;
        private LevelObjectView _playerView;
        private InputManager _input;
        private Constance _constance;

        public PlayerMove(LevelObjectView playerView, InputManager input, Constance constance)
        {
            _playerView = playerView;
            _input = input;
            _constance = constance;
            _checkCollision = new CheckCollision(playerView.ColliderView);
        }
            
        public void Update()
        {
            _checkCollision.Update();
            Move();
        }

        private void Move()
        {
            if(!((_checkCollision.LeftCollider && _input.Horizontal < 0) || (_checkCollision.RightCollider && _input.Horizontal > 0)))
            {
                _playerView.Rigidbody2DView.velocity = new Vector2(_constance.PlayerSpeed * _input.Horizontal,
                                                   _playerView.Rigidbody2DView.velocity.y);
            }
        }
    }
}

