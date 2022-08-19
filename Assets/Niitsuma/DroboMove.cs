using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroboMove : MonoBehaviour
{
    Vector3 _thiefPos = new Vector3();
    float _mozomozo = 0.1f;
    void Start()
    {
        _thiefPos = this.transform.position;
    }
    void Update()
    {

        transform.position = new Vector3(_mozomozo * Mathf.Sin(Time.time * 8) + _thiefPos.x, _thiefPos.y, _thiefPos.z);
    }
}
