using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EbiSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject _ebifurai;
    [SerializeField]
    GameObject _neko;
    [SerializeField]
    float _spawnSycle = 18;
    float _keeptime;

    private void Start()
    {
        _keeptime = _spawnSycle;
    }

    void Update()
    {
        _spawnSycle -= Time.deltaTime;
        if (_spawnSycle <= 0)
        {
            Instantiate(_ebifurai, transform.position, Quaternion.identity);
            Instantiate(_neko, transform.position + new Vector3(3f, -1f, 0), Quaternion.identity);
            _spawnSycle += _keeptime;
        }
    }
}
