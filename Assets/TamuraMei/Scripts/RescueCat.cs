using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
/// <summary>”L‚¿‚á‚ñ‚ðƒLƒƒƒbƒ`</summary>
public class RescueCat : TaskBase
{
    AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public override void Action()
    {

        if(_player.HaveLadder)
        {
            _audioSource.PlayOneShot(_audioSource.clip); //Cat
            _player.UsedLadder();
            Clear();
        }
        else
        {
            return;
        }
        
    }
}
