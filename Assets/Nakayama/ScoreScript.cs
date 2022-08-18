using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] static public int _scorePoint;
    [SerializeField] int _oneScore = 100;
    

    void Start()
    {
    }
    void Update()
    {
        
    }

    public void PlusScore() 
    {
        _scorePoint += _oneScore;
    }
}
