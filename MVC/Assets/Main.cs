using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private PlayerData _data;
    [SerializeField] private View _view;
    private PlayerMove _playerMove;
    private InputManager _inputManager;
    private PlayerJump _playerJump;


    private void Start()
    {
        _inputManager = new InputManager();
        _playerJump = new PlayerJump(_view.Rigidbody,_data, _inputManager);
        _playerMove = new PlayerMove(_data, _view, _inputManager);
        Debug.Log(_playerMove.PlayerSpeed);
    }

    private void FixedUpdate()
    {
        _inputManager.FixUpdateInput();
        _playerMove.FixUpdate();
    }

    private void Update()
    {
        _playerJump.Update();
        _inputManager.Update();
    }

}
