using UnityEngine;

public class GenericChallenge1 : MonoBehaviour
{
    // Any declaration of a Generict method must include an "<>" in it:
    // https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics
    // In this case, we are declaring a generic method with a "T" type parameter

    // To limit this method to only MonoBehaviours, we need to add type parameter contraints:
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
    // in this case: "where T : MonoBehaviour"
    private void GenericMethod<T>() where T : MonoBehaviour
    {
        GameObject newObj = new GameObject("New GameObject");

        // In this line we are calling another generic method: "AddComponent"
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
