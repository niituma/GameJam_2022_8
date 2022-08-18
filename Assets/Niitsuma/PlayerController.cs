using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 3f;
    [SerializeField]
    float _radius = 3;
    [SerializeField]
    bool _haveLadder = false;
    [SerializeField]
    bool _haveballoon = false;
    [SerializeField]
    LayerMask _taskLayer;
    float _h, _v;
    Vector2 _dir;

    Rigidbody2D _rb;

    public bool HaveLadder { get => _haveLadder;}
    public bool Haveballoon { get => _haveballoon;}

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
            if (SearchAreaInEnemies()) { Action(); }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Panch();
        }
        _dir = new Vector2(_h, _v);
    }
    void FixedUpdate()
    {
        float speed = _dir == Vector2.zero ? 0 : _speed;
        _rb.velocity = _dir.normalized * speed;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, _radius);
    }

    GameObject SearchAreaInEnemies()
    {
        var Obj 
            = Physics2D.OverlapCircleAll(transform.position, _radius, _taskLayer).OrderBy(e => Vector2.Distance(e.transform.position,this.transform.position)).FirstOrDefault();

        if(Obj == null) { return null; }

        return Obj.gameObject;
    }

    public void CatchLadder()
    {
        _haveLadder = true;
    }
    public void CatchBalloon()
    {
        _haveballoon = true;
    }

    public void UsedLadder()
    {
        _haveLadder = false;
    }
    public void PassBalloon()
    {
        _haveballoon = false;
    }

    void Action()
    {
        SearchAreaInEnemies().GetComponent<ActionBase>().Action();
    }

    void Panch()
    {
        Debug.Log("Panch");
    }

}
