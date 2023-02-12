using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private int score = 0;
    private int reduceRate = 1;
    private int pointsPerObject = 10;
    public bool isGameGoing = false;

    private void Start()
    {
        isGameGoing= true;
        score = 100;
        StartCoroutine(ReduceCount());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlusPoint"))
        {
            UpdateScore(pointsPerObject);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Boundry"))
        {
            isGameGoing = false;
        }

    }

    IEnumerator ReduceCount()
    {
        while (isGameGoing && score > 0)
        {
            yield return new WaitForSeconds(reduceRate);
            UpdateScore(-reduceRate);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
