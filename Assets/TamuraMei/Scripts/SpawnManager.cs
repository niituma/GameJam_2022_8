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
    [SerializeField] int _firstLevel; //レベルが1になるときのコンボ数
    [SerializeField] int _secondLevel; //レベルが2になるときのコンボ数
    [SerializeField] int _thirdLevel; //レベルが2になるときのコンボ数
    [SerializeField] int _levelUp; //レベルが上がった時に周期がどれくらい早くなるか
    ComboCount _comboCount;

    void Start()
    {
        _comboCount = FindObjectOfType<ComboCount>();
        _spawnTime = Random.Range(2, 5);
        Debug.Log(_spawnTime);
    }

    void Update()
    {

        if(GameObject.Find(_spawned.name) == null)
        {
            _spawnTime -= Time.deltaTime;
            int i = 0;

            //カウントの数によってレベルが変わっていく
            if (_comboCount.Combo == 0)
            {
                i = 0;
            }
            else if (_comboCount.Combo == _firstLevel)
            {
                i += _levelUp;
            }
            else if (_comboCount.Combo == _secondLevel)
            {
                i += _levelUp;
            }
            else if (_comboCount.Combo == _thirdLevel)
            {
                i += _levelUp;
            }

            if (_spawnTime < i)
            {
                //スポーンさせて、次の周期を決める
                GameObject latest = Instantiate(_spawned, this.transform.position, Quaternion.identity);
                latest.name = _spawned.name;
                _spawnTime = Random.Range(_spawnTimeMin, _spawnTimeMax);
                Debug.Log(_spawnTime);
            }

        }
        else
        {
            return;
        }

    }
}
