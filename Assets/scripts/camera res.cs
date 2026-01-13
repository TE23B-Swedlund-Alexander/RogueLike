using UnityEngine;

public class camerares : MonoBehaviour
{
   
public float unitsToShowHorizontally = 12;

private void Update()
{
    float screenWidth = unitsToShowHorizontally;

    float screenHeight = 10;

    float orthographicSize = screenHeight / 2f;

    Camera.main.orthographicSize = orthographicSize;

    Camera.main.aspect = screenWidth / screenHeight;
}

}
