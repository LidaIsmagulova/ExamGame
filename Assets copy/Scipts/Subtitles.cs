using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour
{
    public GameObject textBox;
    void Start()
    {
        StartCoroutine(TheSequence());
    }
    IEnumerator TheSequence()
    {
        yield return new  WaitForSeconds(1);
        textBox.GetComponent<Text>().text="Hi!,i think you wonder where are you.I will explain you everything...";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<Text>().text="";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text="Looks like you in the maze,so you need to go through it...";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text="";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text="And at the end you have to find a house.Don't forget to collect the coins!";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<Text>().text="";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text="Good Luck!";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text="";


        
        






    }
 
}
