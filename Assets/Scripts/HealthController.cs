using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    [Tooltip("The scene that is loaded when you die")] [SerializeField]
    private string deathScene;

    private void Start()
    {
        GameManger.CurrentHealthUpdate.AddListener(pushBack);
    }

    private void Update()
    {
        if (GameManger.currentHealth <= 0)
        {
            SceneManager.LoadScene(deathScene);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Damaging")
        {
            Debug.Log("Damage Detected");

            GameManger.currentHealth -= 1;
        }
    }

    private void pushBack()
    {
        BaseEnemy[] enemies = FindObjectsOfType<BaseEnemy>();

        foreach (BaseEnemy enemy in enemies)
        {
            if ((enemy.transform.position - gameObject.transform.position).magnitude <= 5)
            {
                enemy.state = "push back";
                enemy.state_time = 0;
            }
        }
    }
}
