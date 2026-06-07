using UnityEngine;
using System.Collections.Generic;
public class CardPool
{
    readonly Queue<CardView> _pool = new Queue<CardView>();
    readonly CardView _prefab;
    readonly Transform _parent;
    public CardPool(CardView prefab, Transform parent, int capacity)
    {
        _prefab = prefab;
        _parent = parent;
        for (int i = 0; i < capacity; i++) CreateNewInstance();
    }
    CardView CreateNewInstance()
    {
        var instance = Object.Instantiate(_prefab, _parent);
        instance.gameObject.SetActive(false);
        _pool.Enqueue(instance);
        return instance;
    }
    public CardView Get()
    {
        var instance = _pool.Count > 0 ? _pool.Dequeue() : CreateNewInstance();
        instance.gameObject.SetActive(true);
        return instance;
    }
    public void Release(CardView instance)
    {
        instance.gameObject.SetActive(false);
        _pool.Enqueue(instance);
    }
}