using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    [SerializeField] string _sceneName;
    [SerializeField] float _waitingTime;

    private void Start()
    {

    }

    IEnumerator ChangeScene(string name)
    {
        yield return new WaitForSeconds(_waitingTime);
        SceneManager.LoadScene(name);
    }

    public void ChangeSceneAsync()
    {
        StartCoroutine(ChangeScene(_sceneName));
    }

    public void SceneReload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {

    }
}
