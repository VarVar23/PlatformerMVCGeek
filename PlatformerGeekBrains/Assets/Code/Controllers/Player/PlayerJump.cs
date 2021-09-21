using UnityEngine;

namespace Platformer
{
    public class PlayerJump
    {
        private LevelObjectView _playerView;
        private InputManager _inputManager;
        private Constance _constance;
        private float _velocity;
        private bool _doJump;
        private Vector3 _vectorUp;

        public PlayerJump(LevelObjectView playerView, InputManager inputManager, Constance constance)
        {
            _vectorUp = Vector3.up;

            _playerView = playerView;
            _inputManager = inputManager;
            _constance = constance;
        }

        public void Update()
        {
            _doJump = _inputManager.Jump > 0;

            if (_doJump && CheckGround())
            {
                StartJump();
            }
            else if(_velocity < 0)
            {
                StopJump();
            }
            else if(!CheckGround())
            {
                Flying();
            }
        }


        private bool CheckGround()
        {
            return _playerView.transform.position.y <= _constance.GroundLevel && _velocity <= 0;
        }

        private void StartJump()
        {
            _velocity = _constance.StartJumpSpeed;
        }

        private void StopJump()
        {
            _velocity = 0;
            var playerPosition = _playerView.TransformView.position;
            var vectorGround = new Vector3(playerPosition.x, _constance.GroundLevel, playerPosition.z);
            playerPosition = vectorGround;
        }

        private void Flying()
        {
            _velocity += _constance.G * Time.deltaTime;
            _playerView.TransformView.position += _vectorUp * _velocity;
        }
    }
}
