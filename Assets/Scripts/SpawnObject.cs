using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnObject : MonoBehaviour
{

    private Vector2 _pos;
    public Camera mainCam;
    private float _minX, _minY, _maxX, _maxY;
    
    public GameObject myGameObjectToRespawn;
    public int numberOfGameObj = 10;
    public List<GameObject> listOfSpawned;
    
    // Start is called before the first frame update
    void Start()
    {
        listOfSpawned = new List<GameObject>();
        SetMinAndMax();
        SpawnObj();
    }


    private void SetMinAndMax()
    {
        Vector2 bounds = mainCam.ScreenToWorldPoint(new Vector3(0, 0, 0));

        _minX = -bounds.x;
        _minY = -bounds.y;
        _maxX = bounds.x;
        _maxY = bounds.y;
    }
    

    private void SpawnObj()
    {
        for (int i = 0; i < numberOfGameObj; i++)
        {
            _pos = new Vector2(Random.Range(_minX, _maxX), Random.Range(_minY, _maxY));
            print(_pos.x);
            GameObject obj = Instantiate(myGameObjectToRespawn, _pos, Quaternion.identity);
            obj.transform.parent = transform;
            listOfSpawned.Add(obj);
            

            //SlimeBehavior slimeScript = obj.GetComponent<SlimeBehavior>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
