using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Collider2D swordCollider;
    Vector2 rightAttackOffset;

    public float damage = 3;

    // Start is called before the first frame update
    void Start()
    {
        rightAttackOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackRight()
    {
        swordCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }
    
    public void AttackLeft()
    {
        swordCollider.enabled = true;
        transform.localPosition = new Vector2(rightAttackOffset.x* -1, rightAttackOffset.y);
    }

    public void AttackUp()
    {
        swordCollider.enabled = true;
        transform.localPosition = new Vector2(0, rightAttackOffset.y + 0.06f);
    }

    public void AttackDown()
    {
        swordCollider.enabled = true;
        transform.localPosition = new Vector2(0, rightAttackOffset.y - 0.06f);
    }

    public void StopAttack()
    {
        swordCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            // deal damage to the enemy
            Enemy enemy = other.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.Health -= damage;
            }
        }
    }
}
