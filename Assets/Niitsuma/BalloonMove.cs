using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMove : MonoBehaviour
{
    /// <summary>íeÇ™îÚÇ‘ë¨Ç≥</summary>
    [SerializeField] float _speed = 3f;
    /// <summary>íeÇÃê∂ë∂ä˙ä‘ÅiïbÅj</summary>
    [SerializeField] float _lifeTime = 5f;
    [SerializeField] float _amplitube = 1.5f;
    [SerializeField] float _SpeedY = 3f;
    float _timer;

    Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, _lifeTime);
    }
    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        _rb.velocity = new Vector2(_speed, Mathf.Sin(_timer * _SpeedY) * _amplitube);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<PlayerController>().CatchBalloon();
            Destroy(this.gameObject);
        }
    }

}
