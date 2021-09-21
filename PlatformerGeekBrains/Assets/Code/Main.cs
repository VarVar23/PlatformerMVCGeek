using UnityEngine;

namespace Platformer
{
    public class Main : MonoBehaviour
    {
        private InputManager _inputManager;
        private Constance _constance;

        [SerializeField] private SpriteAnimatorConfig _playerConfig;
        [SerializeField] private LevelObjectView _playerView;
        [SerializeField] private LevelObjectView _gunView;
        [SerializeField] private SpriteAnimatorControllers _playerAnimationController;
        [SerializeField] private BulletView _bulletView;
        [SerializeField] private GameObject _bulletPrefab;

        private Player _player;
        private Gun _gun;
        

        private void Start()
        {
            _constance = new Constance();
            _inputManager = new InputManager(_constance);
            _player = new Player(_playerView, _inputManager, _constance);
            _gun = new Gun(_playerView, _gunView, _constance, _bulletPrefab);

            //_playerConfig = Resources.Load<SpriteAnimatorConfig>("Configs/Resourse/SpriteAnimatorConfig");

            if (_playerConfig)
            {
                _playerAnimationController = new SpriteAnimatorControllers(_playerConfig);
            }

            if(_playerView)
            {
                _playerAnimationController.StartAnimation(_playerView.SpriteRendererView, AnimState.RUN, true, 0.1f);
            }
        }


        void Update()
        {
            _playerAnimationController.Update();

            _inputManager.Update();
            _player.Update();
            _gun.Update();
        }
    }
}

