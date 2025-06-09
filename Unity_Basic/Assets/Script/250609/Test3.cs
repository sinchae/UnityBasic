using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    // Start is called before the first frame update

    /*
    void Start()
    {
        // 확률이 10%면 로그에 '각청'을 뽑았다!
        // 확률이 20%면 로그에 '모나'를 뽑았다!
        // 확률이 30%면 로그에 '치치'를 뽑았다!

        if (Random.Range(0, 100) < 10) //10% 확률
        {
            Debug.Log("각청을 뽑았다!");
        }
        else if (Random.Range(0, 100) < 20) //20%의 확률
        {
            Debug.Log("모나를 뽑았다!");
        }
        else if (Random.Range(0, 100) < 30) //30%의 확률
        {
            Debug.Log("치치를 뽑았다!");
        }
        else
        {
            Debug.Log("아무것도 뽑지 못했다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}   
    */
    
        void Start()
    {

        // 확률이 10%면 로그에 '각청'을 뽑았다!
        // 확률이 20%면 로그에 '모나'를 뽑았다!
        // 확률이 30%면 로그에 '치치'를 뽑았다!

        int randomValue = Random.Range(0, 101); // 0부터 99까지의 랜덤 값 생성

        if (randomValue <= 10) //1~10 -> 10% 확률
        {
            Debug.Log("각청을 뽑았다!");
        }
        else if (randomValue <= 20) //20%의 확률
        {
            Debug.Log("모나를 뽑았다!");
        }
        else if (randomValue <= 30) //30%의 확률
        {
            Debug.Log("치치를 뽑았다!");
        }
        else
        {
            Debug.Log("아무것도 뽑지 못했다.");
        }
    }

    void Update()
    {

    }
}