
namespace Platformer
{
    public class BulletView : LevelObjectView
    {
        public void SetVisible(bool visible)
        {
            //SpriteRendererView.enabled = visible;
            gameObject.SetActive(visible);
        }
    }
}

