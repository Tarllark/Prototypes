using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        UI.transform.Find("counter").GetComponent<Text>().text = (int.Parse(UI.transform.Find("counter").GetComponent<Text>().text) + 1).ToString();
        Destroy(coin);
    }

}
