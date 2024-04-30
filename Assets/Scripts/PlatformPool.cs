using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPool : MonoBehaviour
{
    [SerializeField] GameObject platformPrefab;
    [SerializeField] GameObject playerPrefab;
    [SerializeField] GameObject fatalPlatformPrefab;

    [SerializeField] float distanceBetweenPlatforms;

    List<GameObject> platforms = new List<GameObject>();

    Vector2 platformPosition;
    Vector2 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        GeneratePlatform();
    }

    // Update is called once per frame
    void Update()
    {
        if (platforms[platforms.Count - 1].transform.position.y < Camera.main.transform.position.y + ScreenCalculator.instance.Height)
        {
            PlatformPlace();
        }
    }

    void GeneratePlatform()
    {
        platformPosition = new Vector2(0, 0);
        playerPosition = new Vector2(0, 0.5f);

        GameObject player = Instantiate(playerPrefab, playerPosition, Quaternion.identity);
        GameObject firstPlatform = Instantiate(platformPrefab, platformPosition, Quaternion.identity);

        player.transform.parent = firstPlatform.transform;
        platforms.Add(firstPlatform);
        NextPlatformPosition();
        firstPlatform.GetComponent<Platform>().Move = true;

        for (int i = 0; i < 8; i++)
        {
            GameObject platform = Instantiate(platformPrefab, platformPosition, Quaternion.identity);

            platforms.Add(platform);
            platform.GetComponent<Platform>().Move = true;

            NextPlatformPosition();
        }

        GameObject fatalPlatform = Instantiate(fatalPlatformPrefab, platformPosition, Quaternion.identity);
        fatalPlatform.GetComponent<FatalPlatform>().Move = true;
        platforms.Add(fatalPlatform);
        NextPlatformPosition();
    }

    void PlatformPlace()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject temp;
            temp = platforms[i + 5];

            platforms[i + 5] = platforms[i];
            platforms[i] = temp;
            platforms[i + 5].transform.position = platformPosition;

            NextPlatformPosition();
        }
    }

    void NextPlatformPosition()
    {
        platformPosition.y += distanceBetweenPlatforms;
        float random = Random.Range(0.0f, 1.0f);

        if (random < 0.5f)
        {
            platformPosition.x = ScreenCalculator.instance.Width / 2;
        }
        else
        {
            platformPosition.x = -ScreenCalculator.instance.Width / 2;
        }
    }
}
