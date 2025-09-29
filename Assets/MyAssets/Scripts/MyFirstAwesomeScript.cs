using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class MyFirstAwesomeScript : MonoBehaviour
{
    //een variable is eender welke vorm van value type met een naam die we kunnen gebruiken.
    //variable bovenaan in eek klasse noemen we "property"
    //een global variable of een "property" leeft van de "stack".
    int a = 6;//een int gaat altijd over een rond  getal. 0
    float b;//een float gaat altijd over een komma getal. 0000000000.000000
    double d;//een double is dubbel zo groot als een float.0000000000.0000000000000000000000
             //doubles hebben we meestal niet nodig.

    //Reference types en value types
    //value type
    int integer;
    float floatingpoint;
    double doublefloat;
    bool aanuit;
    string regeltekst = "deze tekst";
    char enkeltekstteken;

    //reference types
    public GameObject go;
    private GameObject privatego;
    Transform trans;
    Light lamp;
    AudioSource audiobron;


    void Start()
    {
        privatego = go;
        //Local variable is een variable die we IN de methode aanmaken en ook alleen voor die
        //methode toegankelijk is.
        //Een local variable leeft op de "stack"
        //de stack is ons "cache geheugen op de cpu"
        int c = a; //als a de waarde 6 heeft schrijven deze waarde in c, c is dus ook gelijk aan6.

        print(a);
        print(c);//Zowel a als c zullen in dit geval 6 printen.

        //regeltekst is een value type en kan overschreven worden, go en privatego zijn references en wijzen 
        //dus beiden naar het originele object in go.

        go.name = "nieuwe naam";
        go.name = regeltekst;

        print(regeltekst);
        regeltekst = "jij bent nu deze waarde";
        print(regeltekst);

        go.name = regeltekst;
        privatego.name = "private naam";

        print(go.name);

    }


    void Update()
    {

    }
}
