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

    Vector2 _lastdir = new Vector2(0, 1);
    float _h, _v;
    Vector2 _dir;

    Rigidbody2D _rb;
    Animator _anim;

    public bool HaveLadder { get => _haveLadder;}
    public bool Haveballoon { get => _haveballoon;}

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Fire1"))
        {
            if (SearchAreaInTask()) { Action(); }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Panch();
        }
        _dir = new Vector2(_h, _v);

        AnimateDir();
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
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(new Vector2(transform.position.x + _lastdir.x , transform.position.y + _lastdir.y), _radius);
    }

    GameObject SearchAreaInTask()
    {
        var Obj 
            = Physics2D.OverlapCircleAll(transform.position, _radius, _taskLayer).OrderBy(e => Vector2.Distance(e.transform.position,this.transform.position)).FirstOrDefault();

        if(Obj == null) { return null; }

        return Obj.gameObject;
    }

    GameObject SearchAreaInHuman()
    {
        var Obj
            = Physics2D.OverlapCircleAll(new Vector2(transform.position.x + _lastdir.x, transform.position.y + _lastdir.y)
            , _radius, _taskLayer).Where(h => h.tag == "Human").OrderBy(e => Vector2.Distance(e.transform.position, this.transform.position)).FirstOrDefault();

        if (Obj == null) { return null; }

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
        SearchAreaInTask().GetComponent<TaskBase>()?.Action();
    }

    void Panch()
    {
        if (!SearchAreaInHuman()) { return; }
        Debug.Log(SearchAreaInHuman());
    }
    void AnimateDir()
    {
        if (Mathf.Abs(_dir.x) > 0.5f)
        {
            _lastdir.x = _dir.x;
            _lastdir.y = 0;
        }

        if (Mathf.Abs(_dir.y) > 0.5f)
        {
            _lastdir.y = _dir.y;
            _lastdir.x = 0;
        }
        _anim.SetFloat("DirX", _dir.x);
        _anim.SetFloat("DirY", _dir.y);
        _anim.SetFloat("LastDirX", _lastdir.x);
        _anim.SetFloat("LastDirY", _lastdir.y);
        _anim.SetFloat("Input", _dir.magnitude);
    }
}
