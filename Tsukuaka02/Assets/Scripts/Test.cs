using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int seisuu = 10;
    int seisuu2 = 3;
    int seisuu3 = 5;

    float shousuu = 0.3f;

    bool flag = true;

    string moji = "mojiretsu";

    const int Value = 10;

    // Start is called before the first frame update
    void Start()
    {
        /*
        for (int i = 0; i<5; i++)
        {
            Debug.Log(i);
        }


        if (seisuu == seisuu2)
        {
            //ifの条件に合致する時の処理
            Debug.Log("いっしょ！");
        }
        else if (seisuu != seisuu2)
        {
            //else if の条件に合致する時の処理
            Debug.Log("ちがう！");
        }
        else
        {
            //上記のどれにも合致しない時の処理
            Debug.Log("なぞ！");
        }
        */
        //Debug.Log(seisuu == seisuu || seisuu == seisuu3);
        //整数の計算をしています
        //Debug.Log(seisuu);
        //Debug.Log(seisuu2);

        //Debug.Log(seisuu + seisuu2);

        //Debug.Log(seisuu);
        //seisuu -= seisuu2;
        //Debug.Log(seisuu);

        /*
         * コメント
         * コメント
         */

        //Log();
    }

    void Log()
    {
        Debug.Log(seisuu);

        Debug.Log(shousuu);

        Debug.Log(flag);

        Debug.Log(moji);

        Debug.Log(Value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
