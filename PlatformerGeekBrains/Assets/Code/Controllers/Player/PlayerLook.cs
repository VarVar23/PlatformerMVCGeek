using UnityEngine;

namespace Platformer
{
    public class PlayerLook
    {
        private LevelObjectView _playerView;
        private InputManager _inputManager;
        private Constance _constance;
        
        public PlayerLook(LevelObjectView playerView, InputManager inputManager, Constance constance)
        {
            _playerView = playerView;
            _inputManager = inputManager;
            _constance = constance;
        }

        public void Update()
        {
            if (_inputManager.Horizontal > 0)
            {
                _playerView.TransformView.localScale = _constance.LookRight;
            }
            else if (_inputManager.Horizontal < 0)
            {
                _playerView.TransformView.localScale = _constance.LookLeft;
            }
        }
    }
}

