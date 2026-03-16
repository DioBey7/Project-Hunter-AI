using System.Collections.Generic;

public abstract class BTNode
{
    protected NodeState state;
    public BTNode parent;
    protected List<BTNode> children = new List<BTNode>();

    public BTNode() { }

    public BTNode(List<BTNode> children)
    {
        foreach (BTNode child in children)
        {
            Attach(child);
        }
    }

    private void Attach(BTNode node)
    {
        node.parent = this;
        children.Add(node);
    }

    public abstract NodeState Evaluate();
}
