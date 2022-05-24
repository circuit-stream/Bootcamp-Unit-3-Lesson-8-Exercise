using UnityEngine;

public class GenericChallenge1 : MonoBehaviour
{
    private void GenericMethod<T>() where T : MonoBehaviour
    {
        GameObject newObj = new GameObject("New GameObject");

        T newComponent = newObj.AddComponent<T>();
        newComponent.enabled = false;

        Debug.Log($"Created new gameObject with a {typeof(T)} component attached to it.");
    }

    private void Start()
    {
        GenericMethod<ExampleMonoBehaviour1>();
        GenericMethod<ExampleMonoBehaviour2>();
    }
}
