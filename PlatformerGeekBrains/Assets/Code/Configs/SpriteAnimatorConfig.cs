using System;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer
{
    public enum AnimState
    {
        IDLE,
        RUN,
        JUMP
    }

    [CreateAssetMenu(fileName = "SpriteAnimatorConfig", menuName = "Configs/Animation", order = 1)]
    public class SpriteAnimatorConfig : ScriptableObject
    {
        [Serializable]
        public sealed class SpriteSequens
        {
            public AnimState Track;
            public List<Sprite> Sprites = new List<Sprite>();
        }

        public List<SpriteSequens> Sequens = new List<SpriteSequens>();
    }
}

