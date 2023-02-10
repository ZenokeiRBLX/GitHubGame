using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyScript : MonoBehaviour
{

    MeleeEnemy meleeEnemy = new MeleeEnemy();
    

    // Start is called before the first frame update
    void Start()
    {
        meleeEnemy.health = 100;
        meleeEnemy.Attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
