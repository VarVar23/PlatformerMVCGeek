using UnityEngine;

namespace Platformer
{
    public class Constance
    {
        #region Player

        public readonly float PlayerSpeed = 0.1f;

        #endregion

        #region Input

        public readonly string HORIZONTAL = "Horizontal";
        public readonly string JUMP = "Jump";

        #endregion

        #region Jump

        public readonly float GroundLevel = 0.5f;
        public readonly float StartJumpSpeed =.7f;
        public readonly float G = -13f;

        #endregion

        #region LookPlayer

        public readonly Vector3 LookLeft = new Vector3(-1, 1, 1);
        public readonly Vector3 LookRight = new Vector3(1, 1, 1);

        #endregion

        #region Gun

        public readonly int CountBulletInArray = 10;
        public readonly float TimeSpawnBullet = 2;
        public readonly float RadiusBullet = 0.5f;
        public readonly float BulletSpeed = 5f;

        #endregion
    }
}

