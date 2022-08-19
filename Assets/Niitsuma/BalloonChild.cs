using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonChild : TaskBase
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
        if (!_player.Haveballoon) { return; }
        _audioSource.PlayOneShot(_clip);
        _player.PassBalloon();
        Clear();
    }
}
