using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public int health = 5;

    public void Hurt(int damage)
    {
        health -= damage;
        Debug.Log("Player hit. Health = " + health);

        if (health <= 0)
        {
            Debug.Log("Player died");
        }
    }
}