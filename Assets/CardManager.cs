using UnityEngine;
using System.Collections;

public class CardManager : MonoBehaviour
{

	#region variables

	[Header("Card Holders")]

	public GameObject
		Card_3;
	public GameObject Card_2;
	public GameObject Card_1;
	public GameObject Card1;
	public GameObject Card2;
	public GameObject Card3;
	public GameObject Card4;
	[Header("Stored Card Variables")]
	public int
		arrayElement = 0;
	public string selectedCard;
	[Header("Card List")]
	public string[]
		cardList = new string[3];
	public Sprite[] cardImages = new Sprite[3];

	#endregion

	void Start ()
	{
		
	}

	void Update ()
	{

		//Debug.Log (cardList.Length);

		#region changeCardValue

		selectedCard = cardList [arrayElement];

		if (Input.GetKeyDown (KeyCode.RightArrow)) {

			if ((arrayElement + 1) < cardList.Length) {

				arrayElement ++;
			} else {

				arrayElement = 0;
			}
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			
			if (arrayElement > 0) {
				
				arrayElement --;
			} else {
				
				arrayElement = cardList.Length - 1;
			}
		}

		#endregion

		#region changeCardImages

		Card1.GetComponent<SpriteRenderer> ().sprite = cardImages [arrayElement];

		#region card4

		if ((arrayElement + 3) < cardList.Length) {

			Card4.GetComponent<SpriteRenderer> ().sprite = cardImages [arrayElement + 3];
		} else {

			Card4.GetComponent<SpriteRenderer> ().sprite = cardImages [arrayElement - 1];
		}

		#endregion

		#region card3

		if ((arrayElement + 2) < cardList.Length) {

			Card3.GetComponent<SpriteRenderer> ().sprite = cardImages [arrayElement + 2];
		} else {

			Card3.GetComponent<SpriteRenderer> ().sprite = cardImages [arrayElement - 2];
		}

		#endregion

		#region card2

		if ((arrayElement + 1) < cardList.Length) {
			
			Card2.GetComponent<SpriteRenderer> ().sprite = cardImages [arrayElement + 1];
		} else {
			
			Card2.GetComponent<SpriteRenderer> ().sprite = cardImages [0];
		}

		#endregion

		#region card-1

		if (arrayElement > 0) {
			
			Card_1.GetComponent<SpriteRenderer> ().sprite = cardImages [arrayElement - 1];
		} else {
			
			Card_1.GetComponent<SpriteRenderer> ().sprite = cardImages [cardList.Length - 1];
		}

		#endregion

		#region card-2


		if((arrayElement - 1 > 0)){

			Card_2.GetComponent<SpriteRenderer> ().sprite = cardImages[arrayElement - 2];
		}else{

			Card_2.GetComponent<SpriteRenderer> ().sprite = cardImages[arrayElement + 2];
		}

		#endregion

		#region card-3

		if ((arrayElement - 2 > 0)) {
			
			Card_3.GetComponent<SpriteRenderer> ().sprite = cardImages [arrayElement - 3];
		} else {

				
				Card_3.GetComponent<SpriteRenderer> ().sprite = cardImages [arrayElement + 1];

		}

		#endregion

		#endregion

		if (Input.GetKeyDown (KeyCode.Space)) {

			Debug.Log ("Used Card: " + selectedCard);
		}
	}
}