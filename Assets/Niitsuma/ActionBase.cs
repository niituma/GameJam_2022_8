using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBase : MonoBehaviour
{
    [SerializeField]
    protected bool _isAction = false;
    [SerializeField]
    protected PlayerController _player;
    void Start()
    {
        _player = FindObjectOfType<PlayerController>();
    }
    public virtual void Spawn()
    {

    }
    public virtual void Action()
    {

    }
}
