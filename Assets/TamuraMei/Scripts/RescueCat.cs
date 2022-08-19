using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(AudioSource))]
/// <summary>�L�������L���b�`</summary>
public class RescueCat : TaskBase
{
    AudioSource _audioSource;
    [SerializeField]
    AudioClip _clip;

    new void Start()
    {
        base.Start();
        _audioSource = FindObjectOfType<AudioSource>();
    }

    public override void Action()
    {

        if(_player.HaveLadder)
        {
            _audioSource.PlayOneShot(_clip); //Cat
            _player.UsedLadder();
            Clear();
        }
        else
        {
            return;
        }
        
    }
}
