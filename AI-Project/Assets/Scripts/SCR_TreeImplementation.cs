using System.Collections.Generic;
using UnityEngine;

public class SCR_TreeImplementation : MonoBehaviour
{
    [Header("Reference")]
    [Tooltip("Root node of the tree")]
    [SerializeField] SCR_Node root;

    // public void Tree()
    // {
    //     root = new SCR_Node();
    // }

    // public void Tree(SCR_Node root)
    // {
    //     this.root = root;
    // }

    // public SCR_Node GetRootNode()
    // {
    //     return root;
    // }

    // public void SetRootNode(SCR_Node root)
    // {
    //     this.root = root;
    // }

    // public void AddChildNode(SCR_Node parentNode, SCR_Node childNode)
    // {
    //     parentNode.GetChildArray().add(childNode);
    // }

    
    
}

public class SCR_Node : MonoBehaviour
{
    SCR_GameState state;
    SCR_Node parent;
    List<SCR_Node> children;
}
