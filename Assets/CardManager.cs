using UnityEngine;
using System.Collections;

public class CardManager : MonoBehaviour {

	public GameObject PreviousCard;
	public GameObject CurrentCard;
	public GameObject NextCard;

	public int arrayElement = 0;
	public string selectedCard;

	public string [] cardList = new string[3];

	public Sprite [] cardImages = new Sprite[3];

	void Start(){
		
	}

	void Update(){

		#region changeCardValue

		selectedCard = cardList [arrayElement];

		if (Input.GetKeyDown (KeyCode.RightArrow)) {

			if((arrayElement + 1) < cardList.Length){

				arrayElement ++;
			}else{

				arrayElement = 0;
			}
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			
			if(arrayElement > 0){
				
				arrayElement --;
			}else{
				
				arrayElement = cardList.Length - 1;
			}
		}

		#endregion

		#region changeCardImages

		CurrentCard.GetComponent<SpriteRenderer> ().sprite = cardImages[arrayElement];

		if((arrayElement + 1) < cardList.Length){
			
			NextCard.GetComponent<SpriteRenderer> ().sprite = cardImages[arrayElement + 1];
		}else{
			
			NextCard.GetComponent<SpriteRenderer> ().sprite = cardImages[0];
		}

		if(arrayElement > 0){
			
			PreviousCard.GetComponent<SpriteRenderer> ().sprite = cardImages[arrayElement - 1];
		}else{
			
			PreviousCard.GetComponent<SpriteRenderer> ().sprite = cardImages[cardList.Length - 1];
		}

		#endregion

		if(Input.GetKeyDown(KeyCode.Space)){

			Debug.Log("Used Card: " + selectedCard);
		}
	}
}