using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyCollect : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Candy1(Clone)");
        {
            Destroy(gameObject);
            CandyCounter();
        }
    }

    public int CandyCounter()
    {
        int candyCount = 10;
        return candyCount;
    }
}
