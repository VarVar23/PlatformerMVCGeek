using UnityEngine;

namespace Platformer
{
    class CheckCollision
    {
        private ContactPoint2D[] _arrayPoints = new ContactPoint2D[10];
        private int _countPoints;
        private Collider2D _collider2D;

        public bool LeftCollider { get; private set; }
        public bool RightCollider { get; private set; }
        public bool DownCollider { get; private set; }

        public CheckCollision(Collider2D collider2D)
        {
            _collider2D = collider2D;
        }

        public void Update()
        {
            _countPoints = _collider2D.GetContacts(_arrayPoints);

            LeftCollider = false;
            DownCollider = false;
            RightCollider = false;

            for (int i = 0; i < _countPoints; i++)
            {
                if (_arrayPoints[i].normal.y == 1) DownCollider = true;
                if (_arrayPoints[i].normal.x == 1) LeftCollider = true;
                if (_arrayPoints[i].normal.x == -1) RightCollider = true;
            }
        }
    }

}

