using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassGrow : MonoBehaviour
{
    [SerializeField] private List<GameObject> _grassList;

    public float timeToSpawn = 10f;

    private void Start()
    {
        foreach (GameObject grass in _grassList)
        {
            grass.gameObject.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        StartCoroutine(GrassSpawn());
    }

    IEnumerator GrassSpawn()
    {
        foreach (GameObject grass in _grassList)
        {
            if (grass.activeSelf == false)
            {
                yield return new WaitForSeconds(timeToSpawn);
                grass.SetActive(true);
            }
        }
    }
}
