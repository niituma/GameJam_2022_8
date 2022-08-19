using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>�^�X�N�ƒʍs�l���X�|�[��������</summary>
public class SpawnManager : MonoBehaviour
{
    [Tooltip("�X�|�[���������")] float _spawnTime;
    [SerializeField] int _spawnTimeMin;
    [SerializeField] int _spawnTimeMax;
    [SerializeField, Tooltip("�X�|�[��������Q�[���I�u�W�F�N�g")] GameObject _spawned;
    [SerializeField] int _firstLevel; //���x����1�ɂȂ�Ƃ��̃R���{��
    [SerializeField] int _secondLevel; //���x����2�ɂȂ�Ƃ��̃R���{��
    [SerializeField] int _thirdLevel; //���x����2�ɂȂ�Ƃ��̃R���{��
    [SerializeField] int _levelUp; //���x�����オ�������Ɏ������ǂꂭ�炢�����Ȃ邩
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

            //�J�E���g�̐��ɂ���ă��x�����ς���Ă���
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
                //�X�|�[�������āA���̎��������߂�
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
