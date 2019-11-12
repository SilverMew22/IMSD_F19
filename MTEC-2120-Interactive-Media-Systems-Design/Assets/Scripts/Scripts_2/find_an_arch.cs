using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class find_an_arch : MonoBehaviour
{
    Transform myChildTheFirstSphere;
    Transform myChildTheSecondCube;

    float timer;

    void Start()
    {
        myChildTheFirstSphere = transform.GetChild(0);
        myChildTheSecondCube = transform.GetChild(1);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 5)
            timer = 0;

        if (timer >= 0 && timer < 2.5f)
        {
            //Do something with the first sphere
            MoveATransformForward(myChildTheFirstSphere);
            MoveATransformBackward(myChildTheSecondCube);
            Debug.Log(TheHeightOfThisGameObject(myChildTheFirstSphere.gameObject));
        }

        if (timer >= 2.5f && timer < 5.0f)
        {
            //Do something with the second sphere
            MoveATransformForward(myChildTheFirstSphere);
            MoveATransformBackward(myChildTheSecondCube);
            Debug.Log(TheHeightOfThisGameObject(this.gameObject));
        }
    }


    void MoveATransformForward(Transform theTransformThatIWantToMoveForward)
    {
        theTransformThatIWantToMoveForward.position += Vector3.forward * Time.deltaTime;
    }

    void MoveATransformBackward(Transform theTransformThatIWantToMoveBackward)
    {
        theTransformThatIWantToMoveBackward.position -= Vector3.forward * Time.deltaTime;
    }

    float TheHeightOfThisGameObject(GameObject g)
    {
        float theHeight = g.transform.position.y;
        return theHeight;
    }

    
}
