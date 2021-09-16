using UnityEngine;

namespace Platformer
{
    public class LevelObjectView : MonoBehaviour
    {
        public Transform TransformView;
        public SpriteRenderer SpriteRendererView;
        public BoxCollider2D BoxColliderView;
        public Rigidbody2D Rigidbody2DView;

        void Start()
        {
            TransformView = GetComponent<Transform>();
            SpriteRendererView = GetComponent<SpriteRenderer>();
        }
    }
}

