using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carCheckPoint : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    int bonus;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "ColliderBody")
        {
            player.GetComponent<carScript>().UpdateTimer(bonus);
            print("It works!!");
        }
        
    }

}
