using UnityEngine;

public class PlayerJump
{
    private Rigidbody _rigidbody;
    private PlayerData _playerData;
    private InputManager _inputManager;

    public PlayerJump(Rigidbody rigidbody, PlayerData playerData, InputManager inputManager)
    {
        _rigidbody = rigidbody;
        _playerData = playerData;
        _inputManager = inputManager;
    }

    public void Update()
    {
        if(_inputManager.Jump && _rigidbody.velocity.y == 0)
        {
            _rigidbody.AddForce(Vector3.up * _playerData.JumpForce);
        }
    }
}
