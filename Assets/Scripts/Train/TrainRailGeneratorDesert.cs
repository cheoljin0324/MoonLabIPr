using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TrainRailGeneratorDesert : MonoBehaviour
{
    [SerializeField]
    private GameObject _railPrefab = null;

    [SerializeField]
    private Vector3 _railOffset = Vector3.zero;

    [SerializeField]
    private float _railSpacing = 3.672f;
    
    private Queue<GameObject> _railQueue = new Queue<GameObject>();

    private void Start()
    {
        GenerateRails(23, 4);
    }

    void Update()
    {
        if (Mathf.Abs(_railQueue.Peek().transform.position.x - transform.position.x) >= 65f)
        {
            Debug.Log("update");
            PoolRail();
        }
    }

    private void PoolRail()
    {
        GameObject rail = _railQueue.Dequeue();
        rail.transform.position = _railQueue.Last().transform.position + (new Vector3(_railSpacing, 0f, 0f));

        _railQueue.Enqueue(rail);
    }

    private void GenerateRails(int count, int afterRail)
    {
        for (int i = 0; i < count; ++i)
        {
            GenerateRail(transform.position + _railOffset + new Vector3((_railSpacing * afterRail) - (_railSpacing * i), 0f, 0f), new Vector3(-90f, 90f, 0f));
        }
        SortRailQueue();
    }

    private void GenerateRail(Vector3 position, Vector3 euler)
    {
        GameObject rail = Instantiate(_railPrefab, position, Quaternion.Euler(euler));
        _railQueue.Enqueue(rail);
    }

    private void SortRailQueue()
    {
        _railQueue = new Queue<GameObject>(_railQueue.OrderBy(x => x.transform.position.x));
    }
}
