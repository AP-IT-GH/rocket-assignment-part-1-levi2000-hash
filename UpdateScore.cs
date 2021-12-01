using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
