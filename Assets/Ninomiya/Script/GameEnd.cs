using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        EndGame();
    }
    private void EndGame() //�Q�[���������I��
    {
        //if(Input.GetKeyDown(KeyCode.Escape))
        //{
        //    UnityEditor.EditorApplication.isPlaying = false; //UnityEditor�̎��s���~����
        //}
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();// �Q�[�����I������
        }
    }
}
