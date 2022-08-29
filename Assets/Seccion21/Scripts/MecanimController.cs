using UnityEngine;
using System.Collections;

public class MecanimController : MonoBehaviour {

	public Animator animController;

	void Start () 
	{
		animController = GetComponent<Animator>();
	}
	

	void Update () 
	{
		Avanzar();
		Salto();
		Viento();
		Escala();
	}

	void Avanzar()
	{
		if (Input.GetButtonDown("Fire1"))
			
			animController.SetBool("Avanzar",true);
		
		if (Input.GetButtonDown("Fire2"))
			
			animController.SetBool("Avanzar",false);
	}

	void Salto()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			animController.SetTrigger("Salto");
	}

	void Viento()
	{
		if(Input.GetKeyDown(KeyCode.V))
			animController.SetFloat("Viento",0.5f);
		if(Input.GetKeyDown(KeyCode.B))
			animController.SetFloat("Viento",0.0f);
	}

	void Escala()
	{
		if(Input.GetKeyDown(KeyCode.S))
			animController.SetInteger("Escala",4);
		if(Input.GetKeyDown(KeyCode.D))
			animController.SetInteger("Escala",0);
	}

}
