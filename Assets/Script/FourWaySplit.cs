using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FourWaySplit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y >= 360)
        {
            SceneManager.LoadScene(8);
        }
        if (gameObject.transform.position.y <= 30)
        {
            SceneManager.LoadScene(7);
        }
    }
}
