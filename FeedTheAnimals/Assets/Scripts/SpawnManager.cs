using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] AnimalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    void Update()
    {
        
        if(Time.frameCount % 400 == 0){
            int animalIndex = Random.Range(0,AnimalPrefabs.Length);
            Vector3 animalPosition = new Vector3(Random.Range(-14,15) , 0 , 30);
     
            Instantiate(AnimalPrefabs[animalIndex], animalPosition , AnimalPrefabs[animalIndex].transform.rotation);

        }
        
       
    }
}
