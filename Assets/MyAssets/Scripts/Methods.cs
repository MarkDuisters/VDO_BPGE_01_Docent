using UnityEngine;

public class Methods : MonoBehaviour
{

    void Start()
    {
        MyMethod();

        MyMethodParameter(5f, 8f);
        MyMethodParameter(5f, 8f);
        MyMethodParameter(11f, 42224f);
        MyMethodParameter(54235424f, 452f);

        print(MyFloatMethod());
        print(MyMethodOutParameter(3f, 8f));
        print(MyMethodOutParameter(554f, 8778f));
        print(MyMethodOutParameter(387f, 548f));
    }

    //lege methode zonder parameters. Word gebruikt om gewone code uit te voeren.
    void MyMethod()
    {
        print("ik print MyMethod");
    }

    //Zelfde als hierboven, echter met 2 input variables die in de methode gebruikt kunnen worden.
    void MyMethodParameter(float a, float b)
    {
        print(a / b);
    }

    //Deze methode kan een float representeren en dus ook weggeschreven worden in een float value variable.
    float MyFloatMethod()
    {
        float a = 6f;
        float b = 9;
        return a * b;
    }

    //Zelfde als hierboven maar met opniuew 2 parameters die we lokaal kunnen gebruiken.
    float MyMethodOutParameter(float a, float b)
    {
        return a / b;
    }
}
