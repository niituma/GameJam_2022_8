using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] static public int _scorePoint;
    [SerializeField] int _oneScore = 100;
    [SerializeField] Text _score;
    

    void Start()
    {
    }
    void Update()
    {
        _score.text = $"Score:{_scorePoint}";
    }

    public void PlusScore() 
    {
        _scorePoint += _oneScore;
    }
}
