using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Human
{
    grondmom,
    boy,
    thief,
    child
}
public class HumanEnum : MonoBehaviour
{

    [SerializeField] Human human;

    public Human Humanmode { get => human; }
}
