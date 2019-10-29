using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject [] spawnPoints = new GameObject [4];
    private float timer = 2f;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if(timer >= 3){
            timer = 0f;
            Instantiate(enemy,spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, Quaternion.identity);
        }
        
    }
}
