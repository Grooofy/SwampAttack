using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent((typeof(Player)))]
public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private Player _player;

    private void OnEnable()
    {
        _player.Shooting += PlayShootAnimation;
        _player.Idle += PlayIdleAnimation;
    }

    private void OnDisable()
    {
        _player.Shooting -= PlayShootAnimation;
        _player.Idle -= PlayIdleAnimation;
    }

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _player = GetComponent<Player>();
    }

    private void PlayShootAnimation()
    {
        _animator.Play("Shoot");
    }

    private void PlayIdleAnimation()
    {
        _animator.Play("Idle");
    }
    
}