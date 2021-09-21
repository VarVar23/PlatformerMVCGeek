using UnityEngine;


namespace Platformer
{
    public class Gun
    {
        private GunRotate _gunRotate;
        private BulletSpawn _bulletSpawn;

        public Gun(LevelObjectView playerView, LevelObjectView gunView, Constance constance, GameObject bulletPrefab)
        {
            _gunRotate = new GunRotate(playerView, gunView);
            _bulletSpawn = new BulletSpawn(constance, bulletPrefab, gunView);
        }

        public void Update()
        {
            _gunRotate.Update();
            _bulletSpawn.Update();
        }
    }
}
