using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int maxHP = 3;
    public int currentHP;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDmg(int amount)
    {
        currentHP -= amount;

        if (currentHP <= 0)
        {
            anim.SetBool("IsDead", true);
        }
    }

    public void Heal(int amount)
    {
        currentHP += amount;

        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }
    }
}
