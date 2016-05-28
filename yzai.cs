using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.ThirdPerson
{
public class koyluyapay : MonoBehaviour {

	public GameObject talksekmesi;
	public float oyuncudis;
	public Transform player;
	public int durum;
		public Transform odun1 ; // değişken olan target
		public GameObject isimci; // isimi sürekli değişecek olan eleman bos obje
		public string firstname; // boş ismi
		public bool konusmadurumubende;
		public FirstPerson.FirstPersonController fpc;
		public Text ml;
		public bool cursor;
		public RuntimeAnimatorController racnorm;
		public RuntimeAnimatorController racisik;

		CursorLockMode clm;
		public Animator animtor;
	



	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
			
			Cursor.lockState = clm;
			if (cursor == true) {

				Cursor.visible = true;

				clm = CursorLockMode.None;




			}
				else
			{



				Cursor.visible = false;

					clm = CursorLockMode.Locked;
          //test ederken rahatsız edecektir test süresince kapatmanı tavsiye ederim
			

			}


			if (oyuncudis <= 3) {

				if(Input.GetButtonDown("talk")) {
				//"talk" kısmı inputlardan atanması gerekiyor
				talksekmesi.SetActive (true);
					konusmadurumubende = true;
					firstname = gameObject.name;
					fpc.enabled = false;
					cursor = true;





				}


			}

			if (Input.GetButtonUp ("talk") && konusmadurumubende == true) {
				talksekmesi.SetActive (false);
				gameObject.name = isimci.name;
				isimci.name = firstname;
				fpc.enabled = true;
				cursor = false;
			}



		oyuncudis = Vector3.Distance (transform.position, player.position);
// odun1 yazan kısma butondaki isim değiştirme functionına göre isim veriniz
		if (gameObject.name == "odun1") {

				gameObject.GetComponent<AICharacterControl> ().target = odun1;

		}

	
	}
}
}
