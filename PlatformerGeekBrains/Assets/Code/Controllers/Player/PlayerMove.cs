using UnityEngine;

namespace Platformer
{
    public class PlayerMove
    {
        private LevelObjectView _playerView;
        private InputManager _input;
        private Constance _constance;
        private Vector3 _vectorRight;

        public PlayerMove(LevelObjectView playerView, InputManager input, Constance constance)
        {
            _vectorRight = Vector3.right;

            _playerView = playerView;
            _input = input;
            _constance = constance;
        }
            
        public void Update()
        {
            Move();
        }

        private void Move()
        {
            _playerView.TransformView.position += _vectorRight * _constance.PlayerSpeed * _input.Horizontal;
        }
    }
}

