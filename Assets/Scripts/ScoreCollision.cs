using UnityEngine;

public class ScoreCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("ScoreCollider"))
        {
            Score.AddPoint();
            collider.gameObject.SetActive(false);
            Vector3 pos = collider.transform.position;
            pos.x += 10;
            collider.transform.position = pos;
            collider.gameObject.SetActive(true);
        }
    }
}
