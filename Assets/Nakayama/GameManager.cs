using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] static public int _ngPoint;

    void Start()
    {
    }
    void Update()
    {

    }
    public void Good()
    {
        _ngPoint = 1;
    }

    public void NotGood()
    {
        _ngPoint -= 1;
    }
    public void VeryNotGood()
    {
        _ngPoint -= 3;
    }
}
