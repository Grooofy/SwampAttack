using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private Transform _shootPoint;
    
    public int Money { get; private set;  }

    private Animator _animation;
    private Weapon _currentWeapon;
    
    private int _currentHealth;

    private void Start()
    {
        _animation = GetComponent<Animator>();
        _currentWeapon = _weapons[0];
        _currentHealth = _health;
    }

    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentWeapon.Shoot(_shootPoint);
        }
    }

    public void OnEnemyDied(int reward)
    {
        Money += reward;
    }
}
