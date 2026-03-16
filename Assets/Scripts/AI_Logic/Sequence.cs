using System.Collections.Generic;

public class Sequence : BTNode
{
    public Sequence() : base() { }
    public Sequence(List<BTNode> children) : base(children) { }

    public override NodeState Evaluate()
    {
        bool anyChildIsRunning = false;

        foreach (BTNode node in children)
        {
            switch (node.Evaluate())
            {
                case NodeState.Failure:
                    state = NodeState.Failure;
                    return state;
                case NodeState.Success:
                    continue;
                case NodeState.Running:
                    anyChildIsRunning = true;
                    continue;
                default:
                    state = NodeState.Success;
                    return state;
            }
        }

        state = anyChildIsRunning ? NodeState.Running : NodeState.Success;
        return state;
    }
}  

