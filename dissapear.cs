using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissapear : MonoBehaviour
{
    private int score = 0;

    public UnityEngine.UI.Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        score = Convert.ToInt16(textScore.text);
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            score += 1;
            textScore.text = score.ToString();
            Destroy(gameObject);
        }
    }
}
