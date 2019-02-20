using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PickUp : MonoBehaviour
{

    [SerializeField]
    GameObject UI;
    [SerializeField]
    GameObject plane;

    GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        coin = gameObject;
        StartCoroutine("rotate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        UI.transform.Find("counter").GetComponent<Text>().DOText((int.Parse(UI.transform.Find("counter").GetComponent<Text>().text) + 1).ToString(), 5);
        Destroy(coin);
    }

    IEnumerator rotate()
    {
        while(true)
        {
            coin.transform.DORotate(new Vector3(0, 180, 0), 10);
            yield return new WaitForSeconds(15);
        }
    }

}
