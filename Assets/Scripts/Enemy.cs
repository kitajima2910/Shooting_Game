using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        
        if (playerObject == null)
        {
            playerObject = FindObjectOfType<GameObject>();
        }

        if (playerObject != null)
        {
            playerTransform = playerObject.transform;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform != null)
        {
            Vector3 direction = playerTransform.position - transform.position;
            direction.Normalize();
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.SetActive(false);
            AudioManager.instance.PlayDeadClip();
            GameManager.instance.EnemySkillPlayer();
        }

        if (other.tag == "Bullet") {
            GameManager.instance.AddScore(1);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
