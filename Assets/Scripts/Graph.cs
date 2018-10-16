using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour {

    public Transform pointPrefab;
    // Use this for initialization

    private void Awake()
    {
        for(int i = 0; i < 10; i++)
        {
            Vector3 scale = Vector3.one / 5f;
            Vector3 position;
          //  position.y = 0f;
            position.z = 0f;

            Transform point = Instantiate(pointPrefab);
            
            position.x = (i + 0.5f) / 5f - 1f;
            position.y = position.x;
            point.localPosition = position;
            point.localScale = scale;
        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
