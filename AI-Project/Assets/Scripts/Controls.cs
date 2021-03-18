using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    [Header("Prefabs")]
    [Tooltip("Prefab for X")] [SerializeField] GameObject xPrefab;
    [Tooltip("Prefab for O")] [SerializeField] GameObject oPrefab;

    [Header("Bools")]
    [Tooltip("Is it the players turn")] public bool isPlayersTurn = true;

    /// <summary>
    /// Function to check for input.
    /// </summary>
    /// <param name="spawnLocation"> Spawn location of the X or O </param>
    public void Click(Transform spawnLocation)
    {
        if (isPlayersTurn)
        {
            Instantiate(xPrefab, spawnLocation);
            isPlayersTurn = false;
        }
        else
        {
            Instantiate(oPrefab, spawnLocation);
            isPlayersTurn = true;
        }
    }
}
