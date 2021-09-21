
namespace Platformer
{
    public class Player
    {
        private PlayerMove _playerMove;
        private PlayerJump _playerJump;
        private PlayerLook _playerLook;

        public Player(LevelObjectView playerView, InputManager inputManager, Constance constance)
        {
            _playerMove = new PlayerMove(playerView, inputManager, constance);
            _playerJump = new PlayerJump(playerView, inputManager, constance);
            _playerLook = new PlayerLook(playerView, inputManager, constance);
        }

        public void Update()
        {
            _playerMove.Update();
            _playerJump.Update();
            _playerLook.Update();
        }
    }
}
