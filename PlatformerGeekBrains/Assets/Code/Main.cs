using UnityEngine;

namespace Platformer
{
    public class Main : MonoBehaviour
    {
        private InputManager _inputManager;
        private Constance _constance;

        [SerializeField] private SpriteAnimatorConfig _playerConfig;
        [SerializeField] private LevelObjectView _playerView;
        [SerializeField] private SpriteAnimatorControllers _playerAnimationController;
        [SerializeField] private BulletView _bulletView;
        [SerializeField] private GameObject _bulletPrefab;
        [Space]
        [SerializeField] private LevelObjectView[] _gunsView;

        private Player _player;
        private Gun[] _guns;

        private void Start()
        {
            _constance = new Constance();
            _inputManager = new InputManager(_constance);
            _player = new Player(_playerView, _inputManager, _constance);

            _guns = new Gun[_gunsView.Length];
            for(int i = 0; i < _guns.Length; i++)
            {
                _guns[i] = new Gun(_playerView, _gunsView[i], _constance, _bulletPrefab);
            }
            

            //_playerConfig = Resources.Load<SpriteAnimatorConfig>("Configs/Resourse/SpriteAnimatorConfig");

            //if (_playerConfig)
            //{
            //    _playerAnimationController = new SpriteAnimatorControllers(_playerConfig);
            //}

            //if(_playerView)
            //{
            //    _playerAnimationController.StartAnimation(_playerView.SpriteRendererView, AnimState.RUN, true, 0.1f);
            //}
        }


        void Update()
        {
            //_playerAnimationController.Update();

            _inputManager.Update();
            _player.Update();

            for(int i = 0; i < _guns.Length; i++)
            {
                _guns[i].Update();
            }
        }
    }
}

