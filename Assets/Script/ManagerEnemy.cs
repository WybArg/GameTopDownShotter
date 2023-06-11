using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEnemy : MonoBehaviour
{

    public float respawnTime;
    private float time;
    public GameObject createEnemy;
    public Player limitedPlatform;
    public Transform targetPlayer;
    private Enemy prefabEnemy;

    void Start()
    {
 
    }



    void Update()
    {
        time += Time.deltaTime;

        if(time >= respawnTime)
        {
            Vector3 posEnemy = Vector3.zero;

            posEnemy.x = Random.Range(-limitedPlatform.platformSize.x, limitedPlatform.platformSize.x);
            posEnemy.z = Random.Range(-limitedPlatform.platformSize.y, limitedPlatform.platformSize.y);

            Instantiate(createEnemy, posEnemy,Quaternion.identity);

            Enemy prefabEnemy = createEnemy.GetComponent<Enemy>();
            prefabEnemy.target = targetPlayer;
            time = 0;
        }

    }


}
