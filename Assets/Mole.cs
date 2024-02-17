using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{

    [SerializeField] public int scoreValue = 1;

    private Score scoreClassReference;

    public void DestroyObject()
    {
        Destroy(this.gameObject);
    }

    public void UpdateScore()
    {
        scoreClassReference.ScoreUp();
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreClassReference = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
