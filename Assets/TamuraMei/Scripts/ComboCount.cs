using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>コンボ数をカウントするだけ</summary>
public class ComboCount : MonoBehaviour
{
    [SerializeField] static int _combo; //コンボ数

    public int Combo { get => _combo; set => _combo = value; }
}
