using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject gameOverCanvas;
    void OnCollisionEnter(Collision collision)
    {
        gameOverCanvas.SetActive(true);
    }
}
