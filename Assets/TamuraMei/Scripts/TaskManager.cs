using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>出現するタスクの処理</summary>
public class TaskManager : MonoBehaviour
{
    [SerializeField] float _limit;

    void Start()
    {
        
    }

    void Update()
    {
        _limit -= Time.deltaTime;

        if(_limit < 0)
        {
            Destroy(gameObject);
        }
    }
}
