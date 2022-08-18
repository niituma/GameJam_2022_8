using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 3f;

    float _h, _v;
    Vector2 _dir;

    Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Fire1"))
        {
            Action();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Panch();
        }
        _dir = new Vector2(_h, _v);
    }

    void Action()
    {
        Debug.Log("Action");
    }

    void Panch()
    {
        Debug.Log("Panch");
    }

    private void FixedUpdate()
    {
        float speed = _dir == Vector2.zero ? 0 : _speed;
        _rb.velocity = _dir.normalized * speed;
    }
}
