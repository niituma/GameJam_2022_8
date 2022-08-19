using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>タスクと通行人をスポーンさせる</summary>
public class SpawnManager : MonoBehaviour
{
    [Tooltip("スポーンする周期")] float _spawnTime;
    [SerializeField] int _spawnTimeMin;
    [SerializeField] int _spawnTimeMax;
    [SerializeField, Tooltip("スポーンさせるゲームオブジェクト")] GameObject _spawned;
    TaskBase _taskBase;

    void Start()
    {
        _taskBase = _spawned.GetComponent<TaskBase>();
        _spawnTime = Random.Range(_spawnTimeMin, _spawnTimeMax);
        Debug.Log(_spawnTime);
    }

    void Update()
    {
        _spawnTime -= Time.deltaTime;
        int i = 0;

        //カウントの数によってレベルが変わっていく
        if (_taskBase.Count == 0)
        {
            i = 0;
        }
        else if (_taskBase.Count == 10)
        {
            i = 2;
        }
        else if (_taskBase.Count == 20)
        {
            i = 4;
        }

        if (_spawnTime < i)
        {
            //スポーンさせて、次の周期を決める
            Instantiate(_spawned, this.transform.position, Quaternion.identity);
            _spawnTime = Random.Range(_spawnTimeMin, _spawnTimeMax);
            Debug.Log(_spawnTime);
        }   
    }
}
