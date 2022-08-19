using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeSystem : MonoBehaviour
{
    [SerializeField] float _fadeInSpeed = 0.8f;
    [SerializeField] float _fadeOutSpeed = 0.01f;
    [SerializeField] bool _isFadeOut = default;
    bool _isFadeIn = default;

    [SerializeField, Tooltip("�Q�[���J�n����FadeIn����")] bool _isStartFadeIn = true;
    [SerializeField] Image fadeImage;
    [SerializeField] string _sceneName;
    float red, green, blue;
    float alfa;
    SceneManagerScript _sceneChanger;

    static public bool _fadeInFinish;

    private void Start()
    {
        _sceneChanger = GetComponent<SceneManagerScript>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;

        if (_isStartFadeIn) { OnFadeIn(); }
    }
    private void Update()
    {
        if (_isFadeOut)
        {
            StartFadeOut();
        }
        else if (_isFadeIn)
        {
            StartFadeIn();
        }
    }
    public void OnFadeIn()
    {
        fadeImage.gameObject.SetActive(true);
        alfa = 1f;
        _isFadeIn = true;
    }
    /// <summary>
    /// FadeOut���J�n����֐�
    /// </summary>
    /// <param name="name"> Scene�J�ڂ���Ƃ���Scene��̖��O</param>
    public void OnFadeOut(string name)
    {
        fadeImage.gameObject.SetActive(true);  // a)�p�l���̕\�����I���ɂ���
        _sceneName = name;
        alfa = 0f;
        _isFadeOut = true;
    }
    void StartFadeIn()
    {
        alfa -= _fadeInSpeed * Time.deltaTime;                //a)�s�����x�����X�ɉ�����
        fadeImage.color = new Color(red, green, blue, alfa);    //b)�ύX�����s�����x�p�l���ɔ��f����
        if (alfa <= 0)
        {
            _isFadeIn = false;
            fadeImage.gameObject.SetActive(false);
            _fadeInFinish = true;
        }
    }
    void StartFadeOut()
    {
        alfa += _fadeOutSpeed * Time.deltaTime;         // b)�s�����x�����X�ɂ�����
        fadeImage.color = new Color(red, green, blue, alfa);    // c)�ύX���������x���p�l���ɔ��f����
        if (alfa >= 1)
        {
            _isFadeOut = false;  //d)�p�l���̕\�����I�t�ɂ���
            SceneManager.LoadSceneAsync(_sceneName);
        }
    }
}
