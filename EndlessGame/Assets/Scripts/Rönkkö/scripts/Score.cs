using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    public AudioClip impact;
    public AudioSource audioSource;
    public TextMeshPro textMeshPro;
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collectible")
        {
            score++;
            audioSource.PlayOneShot(impact);
            Destroy(other.gameObject);
            Debug.Log("Score " + score);
            textMeshPro.text = "Score " + score;
        }
    }
}