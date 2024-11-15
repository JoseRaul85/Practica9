using UnityEngine;

public class ScriptBaile : MonoBehaviour
{
    [SerializeField] Animator anim;

    void Start()
    {
       
    }

    public void ActivarBaile1()
    {
        anim.Play("Baile1");
    }

    public void ActivarBaile2()
    {
        anim.Play("Baile2");
    }

    public void ActivarTriste()
    {
        anim.Play("Triste");
    }
}
