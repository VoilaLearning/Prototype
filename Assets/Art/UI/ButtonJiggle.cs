using UnityEngine;
using System.Collections;

public class ButtonJiggle : MonoBehaviour {

    public Vector3 targetAngle = new Vector3(0f, 0f, 0f);

    public Vector3 originAngle = new Vector3(0f, 0f, 0f);

    private Vector3 currentAngle;

    void Start()

    {
        currentAngle = transform.eulerAngles;

        StartCoroutine(MoveToOrigin());
    }

    void Update()
    {
        if (currentAngle.x > originAngle.x)
        StartCoroutine(MoveToOrigin());
        Debug.Log("Uh Oh I slipped");

    }


    IEnumerator MoveToOrigin()
    {

            yield return new WaitForSeconds(0.5f);
        print(Time.time);

            currentAngle = new Vector3(
                Mathf.LerpAngle(currentAngle.x, targetAngle.x, Time.deltaTime),
                Mathf.LerpAngle(currentAngle.y, targetAngle.y, Time.deltaTime),
                Mathf.LerpAngle(currentAngle.z, targetAngle.z, Time.deltaTime));

            transform.eulerAngles = currentAngle;

    }

    

}
