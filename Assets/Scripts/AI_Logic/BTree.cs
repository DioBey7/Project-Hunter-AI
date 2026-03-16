using UnityEngine;

public abstract class BTree : MonoBehaviour
{
    private BTNode _root = null;

    protected virtual void Start()
    {
        _root = SetupTree();
    }

    protected virtual void Update()
    {
        if (_root != null)
            _root.Evaluate();
    }

    protected abstract BTNode SetupTree();
}