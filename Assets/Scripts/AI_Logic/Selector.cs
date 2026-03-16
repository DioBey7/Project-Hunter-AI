using System.Collections.Generic;

public class Selector : BTNode
{
    public Selector() : base() { }
    public Selector(List<BTNode> children) : base(children) { }

    public override NodeState Evaluate()
    {
        foreach (BTNode node in children)
        {
            switch (node.Evaluate())
            {
                case NodeState.Failure:
                    continue;
                case NodeState.Success:
                    state = NodeState.Success;
                    return state;
                case NodeState.Running:
                    state = NodeState.Running;
                    return state;
                default:
                    continue;
            }
        }

        state = NodeState.Failure;
        return state;
    }
}
