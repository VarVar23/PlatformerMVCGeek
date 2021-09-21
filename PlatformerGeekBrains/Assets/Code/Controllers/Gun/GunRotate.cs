using UnityEngine;

namespace Platformer
{
    public class GunRotate
    {
        private LevelObjectView _playerView;
        private LevelObjectView _gunView;
        private Vector3 _vectorDown;

        public GunRotate(LevelObjectView playerView, LevelObjectView gunView)
        {
            _vectorDown = Vector3.down;

            _playerView = playerView;
            _gunView = gunView;
        }

        public void Update()
        {
            var dir = _playerView.TransformView.position - _gunView.TransformView.position;
            var angle = Vector3.Angle(_vectorDown, dir);
            var axis = Vector3.Cross(_vectorDown, dir);
            _gunView.TransformView.rotation = Quaternion.AngleAxis(angle, axis);
        }
    }
}

