using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int damage;

    public virtual void Attack()
    {
        Debug.Log("Enemy is attacking!");
    }

    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Enemy took " + damage + " damage!");
    }
}

public class MeleeEnemy : Enemy
{
    public override void Attack()
    {
        Debug.Log("Melee Enemy is attacking with a sword!");
    }
}

public class RangedEnemy : Enemy
{
    public override void Attack()
    {
        Debug.Log("Ranged Enemy is attacking with a bow!");
    }
}