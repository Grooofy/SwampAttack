using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Bullet))]
public class LineFire : MonoBehaviour
{
    [SerializeField] private Fire _fire;
    [SerializeField] private float _delay;
    
    private void Start()
    {
        StartCoroutine(DateCreate());
    }

    private IEnumerator DateCreate()
    {
        int maxNumberFire = 7;
        WaitForSeconds delay = new WaitForSeconds(_delay);

        for (int i = 0; i < maxNumberFire; i++)
        {
            Instantiate(_fire, gameObject.transform.position, Quaternion.identity);
            yield return delay;
        }
        Destroy(gameObject);
    }
}