using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoleSpawner : MonoBehaviour
{
    [SerializeField] private Mole MolePrefab;
    [SerializeField] private RectTransform PlayArea;

    private float randomX;
    private float randomY;

    public void SpawnMole()
    {
        randomX = Random.Range(1 , PlayArea.rect.width);
        randomY = Random.Range(1 , PlayArea.rect.height);
        Mole tempMole = Instantiate(MolePrefab, transform);
        tempMole.transform.position = new Vector3 (randomX, randomY, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnMole();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
