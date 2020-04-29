using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject obstacle;

    // Use this for initialization
    private void Start()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}