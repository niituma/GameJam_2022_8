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
    private void EndGame() //ゲームを強制終了
    {
        //if(Input.GetKeyDown(KeyCode.Escape))
        //{
        //    UnityEditor.EditorApplication.isPlaying = false; //UnityEditorの実行を停止する
        //}
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();// ゲームを終了する
        }
    }
}
