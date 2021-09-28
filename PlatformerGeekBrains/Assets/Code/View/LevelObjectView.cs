using UnityEngine;

namespace Platformer
{
    public class LevelObjectView : MonoBehaviour
    {
        public Transform TransformView;
        public SpriteRenderer SpriteRendererView;
        public Collider2D ColliderView;
        public Rigidbody2D Rigidbody2DView;

        void Awake()
        {
            TransformView = GetComponent<Transform>();
            SpriteRendererView = GetComponent<SpriteRenderer>();
            ColliderView = GetComponent<Collider2D>();
            Rigidbody2DView = GetComponent<Rigidbody2D>();
        }
    }
}

