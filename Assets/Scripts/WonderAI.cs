using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    public float speed = 3.0f;
    public float obstacleRange = 10.0f;
    public float fireForce = 15.0f;
    public GameObject fireballPrefab;

    private GameObject _fireball;

    void Update()
    {
        Vector3 origin = transform.position + Vector3.up * 0.5f;
        Ray ray = new Ray(origin, transform.forward);
        RaycastHit hit;

        if (Physics.SphereCast(ray, 0.5f, out hit, obstacleRange))
        {
            GameObject hitObject = hit.transform.gameObject;

            Debug.Log("Enemy sees: " + hitObject.name + " tag=" + hitObject.tag);

            if (hitObject == gameObject)
            {
                return;
            }

            if (hitObject.CompareTag("Player"))
            {
                Debug.Log("Enemy found Player");

                if (_fireball == null)
                {
                    Debug.Log("Enemy fires");

                    _fireball = Instantiate(fireballPrefab);
                    _fireball.transform.position = transform.position + transform.forward * 1.5f + Vector3.up * 0.8f;
                    _fireball.transform.rotation = transform.rotation;

                    Rigidbody rb = _fireball.GetComponent<Rigidbody>();
                    rb.linearVelocity = transform.forward * fireForce;
                }
            }
            else if (hit.distance < obstacleRange)
            {
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
        }

        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}