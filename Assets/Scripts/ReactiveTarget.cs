using System.Collections;
using UnityEngine;

public interface IReactiveTarget
{
    void ReactToHit();
}

public class ReactiveTarget : MonoBehaviour, IReactiveTarget
{
    public void ReactToHit()
    {
        StartCoroutine(Die2());
    }

    private IEnumerator Die2()
    {
        int i = 0;

        while (i < 45)
        {
            transform.Rotate(-2, 0, 0);
            transform.Translate(0, -0.0111f, 0, Space.World);
            i++;
            yield return new WaitForFixedUpdate();
        }

        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}