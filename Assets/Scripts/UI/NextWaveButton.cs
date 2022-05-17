using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextWaveButton : MonoBehaviour
{
   [SerializeField] private Spawner _spawner;
   [SerializeField] private Button _nextWaveButton;

   private void OnEnable()
   {
       _spawner.AllEnemySpawend += OnAllEnemySpawned;
       _nextWaveButton.onClick.AddListener(OnNextWaveButoonClick);
   }

   private void OnDisable()
   {
       _spawner.AllEnemySpawend -= OnAllEnemySpawned;
       _nextWaveButton.onClick.RemoveListener(OnNextWaveButoonClick);
   }

   public void OnAllEnemySpawned()
   {
       _nextWaveButton.gameObject.SetActive(true);
   }

   public void OnNextWaveButoonClick()
   {
       _spawner.NextWave();
       _nextWaveButton.gameObject.SetActive(false);
   }
}
