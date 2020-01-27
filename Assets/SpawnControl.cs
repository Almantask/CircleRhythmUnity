﻿using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    private int _currentEnemy;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        print(timer);
        if(MapButton.Map.Enemies.Count == _currentEnemy) return;
        if (timer > MapButton.Map.Enemies[_currentEnemy].SpawnTime)
        {
            GameObject enemyInstance = Instantiate(enemy, enemy.transform.parent , false);
            enemyInstance.transform.localPosition = new Vector2(MapButton.Map.Enemies[_currentEnemy].XLocation,MapButton.Map.Enemies[_currentEnemy].YLocation);
            enemyInstance.SetActive(true);
            enemyInstance.GetComponent<EnemyControl>().CurrentEnemy = _currentEnemy;
            _currentEnemy++;
        }
    }
}
