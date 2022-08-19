using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] static public int _ngPoint;
    [SerializeField] Image img;
    float _imgalpha;
    float angle = 0;

    void Start()
    {
        img.color = Color.clear;
        //_ngPoint -= 1;

    }
    void Update()
    {
        if (_ngPoint < 0)
        {
            this.img.color = new Color(0.5f, 0f, 0f, _imgalpha);
            _imgalpha = Mathf.Sin(angle * (Mathf.PI / 180)) / 3;
            angle += 0.5f;
            if (angle > 360) angle -= 360;
        }
        else
        {
            this.img.color = Color.Lerp(this.img.color, Color.clear, Time.deltaTime);
        }


    }
    public void Good()
    {
        _ngPoint = 3;
    }

    public void NotGood()
    {
        _ngPoint -= 2;
    }
    public void VeryNotGood()
    {
        _ngPoint -= 5;
    }
}
