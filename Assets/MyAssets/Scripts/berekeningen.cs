using UnityEngine;

public class berekeningen : MonoBehaviour
{
    [SerializeField] float inputA = 0f;
    [SerializeField] float inputB = 0f;
    [SerializeField] float result = 0f;
    [SerializeField] bool add = false;
    [SerializeField] bool subtract = false;
    [SerializeField] bool multiply = false;
    [SerializeField] bool divide = false;
    //private en public variables/properties
    //public float voorbeeld;
    //variables zijn standaard altijd private.

    void Start()
    {
        //Een if statement is een operator waar we een conditie aan kunnen geven.
        //als de conditie juist is of "true", word de codeblok uitgevoerd.
        // == is niet hetzelfde als =. == is een vergelijking conditie en = schrijft een waarde in een variable.
        if (add == true) //(add)is hetzelfde als (add==true),//(!add)is hetzelfde als (add==false)
        {
            result = inputA + inputB;
        }

        if (subtract == true)
        {
            result = inputA - inputB;
        }

        if (multiply == true)
        {
            result = inputA * inputB;
        }

        if (divide == true)
        {
            result = inputA / inputB;
        }

        //  result = result+(inputA * inputB);
        print(result);
    }

}
