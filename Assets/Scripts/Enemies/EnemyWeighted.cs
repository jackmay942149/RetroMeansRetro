using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyWeighted
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private int weight;

    public GameObject Enemy
    {
        get { return enemy; }
        set { enemy = value; }
    }

    public int Weight
    {
        get { return weight; }
        set {weight = value; } 
    }
}
