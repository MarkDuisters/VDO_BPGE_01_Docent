using UnityEngine;

public class Cube_behavior : MonoBehaviour
{
    //   [SerializeField] GameObject getCube;
    [SerializeField] Transform getCubeTransform;
    [SerializeField] float speed = 4f;
    void Start()
    {
        //      print(getCube.transform.position);
        print(getCubeTransform.position);
    }

    void Update()
    {

        //2+3*4=20
        //2+3*4=14
        Vector3 currentPosition = getCubeTransform.position;
        //currentPosition.z = currentPosition.z + speed * Time.deltaTime;
        currentPosition.z += speed * Time.deltaTime;
        getCubeTransform.position = currentPosition;

    }
}
