using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Enemy[] enemies;

    // Start is called before the first frame update
    void Start()
    {
      enemies = FindObjectsOfType<Enemy>();
      SetDamagePointsTo(0);
      SetRandomValueToDamagePoints();
      DeactivateEnemiesWithDPLessThan(7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDamagePointsTo(int newValue){
        for(int i = 0; i < enemies.Length; i++){
            enemies[i].damagePoints = newValue;
        }
    }

    void SetRandomValueToDamagePoints()
    {
        //int x = Random.Range(min, max + 1);
        for(int i = 0; i < enemies.Length; i++){
            enemies[i].damagePoints = Random.Range(0,16);
        }
    }

    void DeactivateEnemiesWithDPLessThan(int Value){
        for(int i = 0; i < enemies.Length; i++){
            if(enemies[i].damagePoints < Value){
                enemies[i].gameObject.SetActive(false);
            }
        }
    }
}
