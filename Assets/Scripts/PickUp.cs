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
            yield return new WaitForSeconds(15);
            int goal = 180;
            if (coin.transform.position.y.Equals(180))
                goal = 0;
            else if (coin.transform.position.y.Equals(0))
                goal = 180;
            if (Random.value >= 0.5f)
                coin.transform.DOMove(new Vector3(0, goal, 0), 120);
            yield return new WaitForEndOfFrame();
        }
    }

}
