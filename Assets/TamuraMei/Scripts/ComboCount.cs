using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>�R���{�����J�E���g���邾��</summary>
public class ComboCount : MonoBehaviour
{
    [SerializeField] static int _combo; //�R���{��

    public int Combo { get => _combo; set => _combo = value; }
}
