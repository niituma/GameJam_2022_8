using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EbiMove : MonoBehaviour
{
    Vector3 _ebifuraiPos = new Vector3();
    [SerializeField] float _ebispd = 15;
    void Start()
    {
        _ebifuraiPos = this.transform.position;
    }
    void Update()
    {

        transform.position += new Vector3(_ebispd * Time.deltaTime, 0,0);
        if (this.transform.position.x < -25) Destroy(this.gameObject);
    }
}
