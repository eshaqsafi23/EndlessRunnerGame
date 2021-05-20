using UnityEngine;

public class RaipeTileSpawner : MonoBehaviour
{
    public GameObject RoadTileTEST;
    Vector3 NextSpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(RoadTileTEST, NextSpawnPoint, Quaternion.identity);
        NextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 300; i++)
        {
            SpawnTile();
        }
    }
}