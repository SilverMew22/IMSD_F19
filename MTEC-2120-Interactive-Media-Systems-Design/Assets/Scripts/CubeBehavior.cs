using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{ public float decimalNumber;

    // Start is called before the first frame update
    void Start()
    {
        decimalNumber = 1.111f;
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(makeDecimalNumberBiggerandPrnintIt());
        //Debug.Log(GiveMeTheSum());
        MoveMyObjectAlongAVector(this.transform, Vector3.up * Time.deltaTime);
    }
    //float makeDecimalNumberBiggerandPrnintIt() {
        //decimalNumber += .0001f;
        // Debug.Log(decimalNumber);
        //return 0;
       //}
    float GiveMeTheSum(float numberA,float numberB) {
        float numberSum = numberA + numberB;
        return numberSum;
    }
void MoveMyObjectAlongAVector(Transform theTransformThatNeedsToBeMoved,Vector3 theDirectionItShouldMove)
{ theTransformThatNeedsToBeMoved.position += theDirectionItShouldMove; }

}
