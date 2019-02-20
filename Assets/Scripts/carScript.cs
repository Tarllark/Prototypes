using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class carScript : MonoBehaviour
{
    float timer = 200;

    [SerializeField]
    GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        UI.GetComponent<Text>().text = timer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        timer -= Time.deltaTime;
        UI.GetComponent<Text>().text = timer.ToString();
    }
    
    public void UpdateTimer(int bonus)
    {
        timer += bonus;
        UI.GetComponent<Text>().text = timer.ToString();
        print("Bonus added");
    }
}
