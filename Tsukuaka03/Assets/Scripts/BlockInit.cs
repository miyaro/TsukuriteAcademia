using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockInit : MonoBehaviour
{
    [SerializeField] GameObject blockPrefab;
    [SerializeField] GameObject blocks;

    // Start is called before the first frame update
    void Start()
    {
        blocks.transform.position = new Vector3(1, 0, 0);
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                GameObject block = Instantiate(blockPrefab, blocks.transform);
                block.transform.position = new Vector3(i*1.2f, j*0.8f, 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
