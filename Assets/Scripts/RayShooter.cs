using UnityEngine;

public class RayShooter : MonoBehaviour
{
    private Camera _camera;
    private AudioSource audioSource;

    void Start()
    {
        _camera = GetComponent<Camera>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }

            Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
            Ray ray = _camera.ScreenPointToRay(point);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit " + hit.transform.name);

                ReactiveTarget target = hit.transform.GetComponent<ReactiveTarget>();

                if (target != null)
                {
                    target.ReactToHit();
                }
            }
        }
    }
}