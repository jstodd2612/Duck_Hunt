using UnityEngine;
using System.Collections;

public class eventManager : MonoBehaviour {
	
	public delegate void ClickAction();
	public static event ClickAction OnClicked;
		
		
		void OnGUI()
		{
			if(GUI.Button(new Rect(Screen.width / 2 - -90, 10, 100, 50), "Auto-Kill"))
			{
				if(OnClicked != null)
					OnClicked();
			}
		}
	}