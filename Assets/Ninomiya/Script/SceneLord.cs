using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLord : MonoBehaviour
{
    [SerializeField] GameObject _game;
    [SerializeField] GameObject _game1;
    // Start is called before the first frame update
 
    public void scenelord(string scenename) //����Scene�ǂݍ���
    {
        GameManager._ngPoint = 0;
        ScoreScript._scorePoint = 0;
        SceneManager.LoadScene(scenename);
    }
    public void SwtchLight() //��������ւ̐؂�ւ�
    {
        if(_game && _game1)
        {
            _game.SetActive(false);
            _game1.SetActive(true);
        }
    }
}
