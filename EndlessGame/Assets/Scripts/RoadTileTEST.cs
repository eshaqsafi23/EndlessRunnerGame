using UnityEngine;

public class RoadTileTEST : MonoBehaviour
{
    RaipeTileSpawner groundSpawner;

    // Start is called before the first frame update
    private void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<RaipeTileSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }
}
