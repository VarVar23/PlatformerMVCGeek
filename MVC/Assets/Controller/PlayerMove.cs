using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove
{
    private PlayerData _playerData;
    private View _view;
    public float PlayerSpeed;
    private Rigidbody _rigidbody;
    private InputManager _inputManager;

    public PlayerMove(PlayerData playerData, View view, InputManager inputManager)
    {
        PlayerSpeed = playerData.Speed;
        _rigidbody = view.Rigidbody;
        _inputManager = inputManager;
    }

    public void FixUpdate()
    {

        if(_inputManager.Horizontal != 0)
        {
            _rigidbody.AddForce(Vector3.right * PlayerSpeed * _inputManager.Horizontal);
        }

        if (_inputManager.Vertical != 0)
        {
            _rigidbody.AddForce(Vector3.forward * PlayerSpeed * _inputManager.Vertical);
        }
    }
}
