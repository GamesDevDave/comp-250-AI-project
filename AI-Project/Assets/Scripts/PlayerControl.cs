using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [Header("Prefabs")]
    [Tooltip("Prefab for X")] [SerializeField] GameObject xPrefab;

    public void PlayerClick(Transform spawnLocation)
    {
        Instantiate(xPrefab, spawnLocation);
    }
}
