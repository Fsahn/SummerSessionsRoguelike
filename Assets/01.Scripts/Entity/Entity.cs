using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    
    public virtual void Attack(Entity other)
    {
        var damage = 1; // ���� ��, �����δ� ���
        other.Damage(damage);
    }

    public virtual void Damage(float damage)
    {
        // HP ��� �ڵ� ����
    }
}
