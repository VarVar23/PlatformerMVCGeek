using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private SpriteAnimatorConfig _playerConfig;
        [SerializeField] private float _speed = 10;
        [SerializeField] private LevelObjectView _playerView;
        [SerializeField] private SpriteAnimatorControllers _playerAnimationController;

        private void Start()
        {
            //_playerConfig = Resources.Load<SpriteAnimatorConfig>("PlayerAnim");
            
            if(_playerConfig)
            {
                _playerAnimationController = new SpriteAnimatorControllers(_playerConfig);
            }

            if(_playerView)
            {
                _playerAnimationController.StartAnimation(_playerView.SpriteRendererView, AnimState.RUN, true, _speed);
            }
        }


        void Update()
        {
            _playerAnimationController.Update();
        }
    }
}

