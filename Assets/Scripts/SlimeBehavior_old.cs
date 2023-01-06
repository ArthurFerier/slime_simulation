using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class SlimeBehaviorold : MonoBehaviour
{
    public float speed = 3;
    public SpawnObject spawner;

    private List<GameObject> _listOfParticles;
    void Update()
    {
        Move();
    }

    void Move()
    {
        foreach (GameObject particle in _listOfParticles)
        {
            
        }
    }
}
