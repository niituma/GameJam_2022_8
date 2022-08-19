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

    [SerializeField, Tooltip("ゲーム開始時にFadeInする")] bool _isStartFadeIn = true;
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
    /// FadeOutを開始する関数
    /// </summary>
    /// <param name="name"> Scene遷移するときのScene先の名前</param>
    public void OnFadeOut(string name)
    {
        fadeImage.gameObject.SetActive(true);  // a)パネルの表示をオンにする
        _sceneName = name;
        alfa = 0f;
        _isFadeOut = true;
    }
    void StartFadeIn()
    {
        alfa -= _fadeInSpeed * Time.deltaTime;                //a)不透明度を徐々に下げる
        fadeImage.color = new Color(red, green, blue, alfa);    //b)変更した不透明度パネルに反映する
        if (alfa <= 0)
        {
            _isFadeIn = false;
            fadeImage.gameObject.SetActive(false);
            _fadeInFinish = true;
        }
    }
    void StartFadeOut()
    {
        alfa += _fadeOutSpeed * Time.deltaTime;         // b)不透明度を徐々にあげる
        fadeImage.color = new Color(red, green, blue, alfa);    // c)変更した透明度をパネルに反映する
        if (alfa >= 1)
        {
            _isFadeOut = false;  //d)パネルの表示をオフにする
            SceneManager.LoadSceneAsync(_sceneName);
        }
    }
}
