using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] AnimalPrefabs;

    private float _startDelayTime = 3;
    private float _IntervelDelayTime = 1.8f;

    // Start is called before the first frame update
    void Start()
    {
         // it wait for "_startDelayTime" seconds then starts execution
        InvokeRepeating("SpawnRandomAnimal", _startDelayTime , _IntervelDelayTime);
    }

    void SpawnRandomAnimal() {
        int animalIndex = Random.Range(0,AnimalPrefabs.Length);
        Vector3 animalPosition = new Vector3(Random.Range(-14,15) , 0 , 30);
     
        Instantiate(AnimalPrefabs[animalIndex], animalPosition , AnimalPrefabs[animalIndex].transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    
       
    }
}
