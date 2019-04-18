using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField]
    GameObject car;
    [SerializeField]
    Transform respawnPoint;

    public void ResetCar()
    {
        car.transform.position = respawnPoint.transform.position;
        car.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        
    }
}
