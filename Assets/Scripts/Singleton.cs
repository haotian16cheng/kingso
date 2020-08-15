using UnityEngine;
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if(!_instance)
            {
                _instance = FindObjectOfType<T>();
                if(!_instance)
                {
                    GameObject singleton = new GameObject(typeof(T).ToString());
                    _instance= singleton.AddComponent<T>();
                }
               
            }
            return _instance;
        }
    }
    protected virtual void OnDestroy()
    {
        _instance = null;
    }
}
