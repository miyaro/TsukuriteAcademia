using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxIncreaser : MonoBehaviour
{
    public GameObject boxPrefab;
    public GameObject boxes;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i--)
        {
            GameObject box = Instantiate(boxPrefab, boxes.transform);
            box.transform.position = new Vector3(i * 2, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
