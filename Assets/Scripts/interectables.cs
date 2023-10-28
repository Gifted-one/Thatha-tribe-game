using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interectables : MonoBehaviour
{
    public GameObject Player;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Food")
        {

        }

        if (collision.gameObject.tag == "Wood")
        {

        }

        if (collision.gameObject.tag == "Potions")
        {

        }
    }
}
