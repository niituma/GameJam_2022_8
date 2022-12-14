using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
/// <summary>風船を子供に渡す</summary>
public class CatchBalloon : TaskBase
{
    AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public override void Action()
    {

        if(_player.Haveballoon)
        {
            _audioSource.PlayOneShot(_audioSource.clip); //Balloon
            _player.PassBalloon();
            Clear();
        }
        else
        {
            return;
        }
        
    }
}
