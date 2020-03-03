using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN = 200f;
    private const int STARTING_PLATFORM_NUMBER = 5;
    private Vector3 PLATFORM_START_AND_TRANSFORM_DIFFERENCE = new Vector3(0, 0, 50);

    [SerializeField] private List<Transform> partList;
    [SerializeField] private Transform startingPlatrform;
    [SerializeField] private GameObject player;

    private Vector3 lastEndPlatformPosition;

    void Update()
    {
        if(PLAYER_DISTANCE_SPAWN > Vector3.Distance(player.transform.position, lastEndPlatformPosition))
        {
            SpawnLevelPart();
        }
    }

    private void Awake()
    {
        lastEndPlatformPosition = startingPlatrform.Find("PlatformEnd").position + PLATFORM_START_AND_TRANSFORM_DIFFERENCE;
        
        for(int i = 0; i < STARTING_PLATFORM_NUMBER; i++)
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        Transform chosenPart = partList[Random.Range(0, partList.Count)];
        Transform lastEndPlatform = SpawnPlatform(chosenPart, lastEndPlatformPosition);
        lastEndPlatformPosition = lastEndPlatform.Find("PlatformEnd").position + PLATFORM_START_AND_TRANSFORM_DIFFERENCE;
    }

    private Transform SpawnPlatform(Transform part, Vector3 spawnPoint)
    {
        Transform platformTransform = Instantiate(part, spawnPoint, Quaternion.identity);
        return platformTransform;
    }
}
