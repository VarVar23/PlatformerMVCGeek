using UnityEngine;


namespace Platformer
{
    public class BulletMove
    {
        private BulletView _bulletView;
        private Constance _constance;
        private Vector3 _velocity;
        private Vector3 _vectorUp;

        public BulletMove(Constance constance, BulletView bulletView)
        {
            _vectorUp = Vector3.up;
            _constance = constance;
            _bulletView = bulletView;
            _bulletView.SetVisible(false);
        }

        public void Update()
        {
            if (CheckGround())
            {
                _velocity = new Vector3(_velocity.x, _velocity.y * (-1), _velocity.z);
                SetVelocity(_velocity);

                var position = _bulletView.TransformView.position;
                _bulletView.TransformView.position = new Vector3(position.x, _constance.GroundLevel + _constance.RadiusBullet, position.z);
            }
            else
            {
                SetVelocity(_velocity + _vectorUp * _constance.G * Time.deltaTime);
                _bulletView.TransformView.position += _velocity * Time.deltaTime;
            }
        }

        public void Shoot(Vector3 position, Vector3 velocity)
        {
            _bulletView.TransformView.position = position;
            SetVelocity(velocity);
            _bulletView.SetVisible(true);
        }

        private bool CheckGround()
        {
            return _bulletView.transform.position.y <= _constance.GroundLevel && _velocity.y <= 0;
        }

        private void SetVelocity(Vector3 velocity)
        {
            _velocity = velocity;
            var angle = Vector3.Angle(Vector3.right, _velocity);
            var axis = Vector3.Cross(Vector3.right, _velocity);
            _bulletView.TransformView.rotation = Quaternion.AngleAxis(angle, axis);
        }
    }
}
