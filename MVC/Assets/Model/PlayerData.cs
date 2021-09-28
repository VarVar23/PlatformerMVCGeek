using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data", fileName ="Config/Data", order = 1)]
public class PlayerData : ScriptableObject
{
    public float Speed;
    public float JumpForce;
}
