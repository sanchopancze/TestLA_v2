using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class press_any_key : MonoBehaviour {

    public GameObject ps_portal;
    public Transform ps_portal_spawn;
    Animator anim;


 

    void Start () {
		anim = GetComponent <Animator> ();
		anim.enabled = false;
		StartCoroutine(WaitFunc ());

	}
	

	void Update () {
		if(Input.anyKey)
			anim.SetTrigger ("any_key");
        
    }

	IEnumerator WaitFunc () {
		yield return new WaitForSeconds(3f);
        Instantiate(ps_portal, ps_portal_spawn.position, Quaternion.identity);
        anim.enabled = true;
    }
}
