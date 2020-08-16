using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject flag;

   // UnityAction unityAction = new UnityAction();
    UnityEvent unityEvent = new UnityEvent();

    void Start()
    {
        //unityEvent.AddListener(unityAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getDes()
    {
        setFlagVis(false);
        unityEvent?.Invoke();
      //  unityAction();

    }

    void setFlagVis(bool isVis)
    {
        flag.SetActive(isVis);
    }

    public void setEvent(UnityAction action)
    {
        unityEvent.AddListener(action);
        // unityAction += action;
    }

}
