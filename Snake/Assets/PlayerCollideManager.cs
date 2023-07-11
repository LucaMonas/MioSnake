using UnityEngine;

public class PlayerCollideManager : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    //[SerializeField] Snake snake;
    [SerializeField] LifeManager lifeManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");

            Destroy(gameObject);

            scoreManager.ResetPoint();

            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food"))
        {
            Debug.Log("Add Point");

            scoreManager.AddPoint();
        }
        else
        {
            Debug.Log("Less Point" + other.gameObject.name);

            scoreManager.ResetPoint();
        }
    }
}
