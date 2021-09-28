using UnityEngine;


namespace Platformer
{
    public class BulletSpawn 
    {
        private BulletMove[] _bullets;
        private GameObject[] _bulletsView;
        private Constance _constance;
        private LevelObjectView _gun;
        private float _time;
        private int _index;

        public BulletSpawn(Constance constance, GameObject prefabBullet, LevelObjectView gun)
        {
            _constance = constance;
            _bullets = new BulletMove[_constance.CountBulletInArray];
            _bulletsView = new GameObject[_constance.CountBulletInArray];
            _gun = gun;
            _time = 0;
            _index = 0;

            CreateArray(prefabBullet);
        }

        public void Update()
        {
            if(_time > 0)
            {
                _time -= Time.deltaTime;
            }
            else
            {
                _time = _constance.TimeSpawnBullet;
                Spawn();
            }    
        }

        private void CreateArray(GameObject prefabBullet)
        {
            for (int i = 0; i < _constance.CountBulletInArray; i++)
            {
                _bulletsView[i] = GameObject.Instantiate(prefabBullet, _gun.TransformView.position, Quaternion.identity);
                _bullets[i] = new BulletMove(_constance, _bulletsView[i].GetComponent<BulletView>());
            }
        }

        private void Spawn()
        {
            _bullets[_index].Shoot(_gun.TransformView.position, _gun.TransformView.up * _constance.BulletSpeed * (-1));
            _index++;

            if(_index == _constance.CountBulletInArray)
            {
                _index = 0;
            }
        }
    }
}
