using UnityEngine;

public class Node
{
    public int gridX;
    public int gridY;
    public bool isWalkable;
    public int terrainCost;
    public Vector3 worldPosition;

    public int gCost;
    public int hCost;
    public Node parent;

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
}