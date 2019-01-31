using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] public Transform playerSpawnPoints; // The parent of the spawn points
    [SerializeField] public bool respawn = false;
    CharacterController charControl;

    private Transform[] spawnPoints;
    private bool lastToggle = false;
    void Start() {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        charControl = GetComponent<CharacterController>();
    }

    void Update() {
        if (lastToggle != respawn) {
            Respawn();
            respawn = false;
            charControl.enabled = true;
        } else {
            lastToggle = respawn;
        }
    }

    private void Respawn() {
        int i = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[i].position;
        charControl.enabled = false;
    }
}
