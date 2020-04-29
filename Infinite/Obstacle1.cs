using UnityEngine;

public class Obstacle1 : MonoBehaviour
{
    public int damage = 1;

    public float speed = 5;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //other.GetComponent<Player1_Controller>().health -= damage;
            //Debug.Log(other.GetComponent<Player1_Controller>().health);

            //GameManager.instance.health -= damage;
            //Debug.Log(GameManager.instance.health);

            GameMng.health -= damage;
            Debug.Log(GameMng.health);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}