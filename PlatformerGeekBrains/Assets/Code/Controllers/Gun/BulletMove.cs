using UnityEngine;


namespace Platformer
{
    public class BulletMove
    {
        private BulletView _bulletView;
        private Constance _constance;

        public BulletMove(Constance constance, BulletView bulletView)
        {
            _constance = constance;
            _bulletView = bulletView;
            _bulletView.SetVisible(false);
        }

        public void Shoot(Vector3 position, Vector3 velocity)
        {
            _bulletView.TransformView.position = position;
            _bulletView.SetVisible(true);
            _bulletView.Rigidbody2DView.velocity = velocity * _constance.BulletSpeed;
        }
    }
}
