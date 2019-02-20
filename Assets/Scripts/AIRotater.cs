using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AIRotater : MonoBehaviour
{
    int rotation;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("rotate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator rotate()
    {
        while(true)
        {
            gameObject.transform.DORotate(new Vector3(0, 180, 0), 60);
            //yield return new WaitForSeconds(65);
            new WaitForSeconds(65);
        }
        
    }
}
