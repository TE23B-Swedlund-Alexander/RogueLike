using UnityEngine;

public class camerares : MonoBehaviour
{
   
public float unitsToShowHorizontally = 22;
public float unitsToShowVertically=10;

private void Update()
{
    float screenWidth = unitsToShowHorizontally;

    float screenHeight = unitsToShowVertically;

    float orthographicSize = screenHeight / 2f;

    Camera.main.orthographicSize = orthographicSize;

    Camera.main.aspect = screenWidth / screenHeight;
}

}
