using UnityEngine;
using UnityEngine.Serialization;

public class ProgressBar : Bar
{
     [SerializeField] private Spawner _spawner;

    private void OnEnable()
    {
        _spawner.EnemyContChanget += OnValueChanged;
        Slider.value = 0;
    }

    private void OnDisable()
    {
        _spawner.EnemyContChanget -= OnValueChanged;
    }
}