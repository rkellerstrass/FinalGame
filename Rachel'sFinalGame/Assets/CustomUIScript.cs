using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomUIScript : MonoBehaviour
{
    public GameObject Player;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        healthText.text = "Health: " + Player.GetComponent<HealthSystemAttribute>().health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + Player.GetComponent<HealthSystemAttribute>().health.ToString();
    }
}
