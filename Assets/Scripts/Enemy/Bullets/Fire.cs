using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Bullet))]
public class Fire : MonoBehaviour
{
    [SerializeField] private float _timeLife;
    private void OnEnable()
    {
        StartCoroutine(Destroy());
    }

    private IEnumerator Destroy()
    {
        WaitForSeconds delay = new WaitForSeconds(_timeLife);

        yield return delay;
        Destroy(gameObject);
    }
}