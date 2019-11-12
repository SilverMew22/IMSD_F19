using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTwoSpheresDoSomething : MonoBehaviour
{
    Transform myChildTheFirstSphere;
    Transform myChildTheSecondSphere;

    float timer;

    void Start()
    {
        myChildTheFirstSphere = transform.GetChild(0);
        myChildTheSecondSphere = transform.GetChild(1);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 5)
            timer = 0;

        if (timer >= 0 && timer < 2.5f)
        {
            //Do something with the first sphere
            MoveATransformUpward(myChildTheFirstSphere);
            Debug.Log(TheHeightOfThisGameObject(myChildTheFirstSphere.gameObject));
        }

        if (timer >= 2.5f && timer < 5.0f)
        {
            //Do something with the second sphere
            MoveATransformUpward(myChildTheSecondSphere);
            Debug.Log(TheHeightOfThisGameObject(this.gameObject));
        }
    }

    void MoveATransformUpward(Transform theTransformThatIWantToMoveUpward)
    {
        theTransformThatIWantToMoveUpward.position += Vector3.up * Time.deltaTime;
    }

    float TheHeightOfThisGameObject(GameObject g)
    {
        float theHeight =  g.transform.position.y;
        return theHeight;
    }

    void MakeAWallOfIce(Vector3 where)
    {
        //Check if I can make a wall

        //Check if the wall fits


        if (DoIHaveEnoughEnergy() && DoesTheWallFit())
        {
            MakeWall();
        }
        //Make the wall
        //Push all the badguys out of the wall
    }

    bool DoIHaveEnoughEnergy()
    {
        return true;
    }

    bool DoesTheWallFit()
    {
        return true;
    }

    void MakeWall()
    {

    }
}
