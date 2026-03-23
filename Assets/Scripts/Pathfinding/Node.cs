using UnityEngine;

public class Node : IHeapItem<Node>
{
    public int gridX;
    public int gridY;
    public bool isWalkable;
    public int terrainCost;
    public Vector3 worldPosition;

    public int gCost;
    public int hCost;
    public Node parent;
    private int _heapIndex;

    public Node(bool isWalkable, Vector3 worldPosition, int gridX, int gridY, int terrainCost)
    {
        this.isWalkable = isWalkable;
        this.worldPosition = worldPosition;
        this.gridX = gridX;
        this.gridY = gridY;
        this.terrainCost = terrainCost;
    }

    public int fCost
    {
        get { return gCost + hCost; }
    }

    public int HeapIndex
    {
        get { return _heapIndex; }
        set { _heapIndex = value; }
    }

    public int CompareTo(Node nodeToCompare)
    {
        int compare = fCost.CompareTo(nodeToCompare.fCost);
        if (compare == 0)
        {
            compare = hCost.CompareTo(nodeToCompare.hCost);
        }
        return -compare;
    }
}

public interface IHeapItem<T> : System.IComparable<T>
{
    int HeapIndex { get; set; }
}