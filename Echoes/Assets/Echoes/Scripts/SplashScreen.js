var customTexture:GUITexture;
var nextScene = "HubRoom";
var delayTime : float = 2.0f;
private var startTime : float;

function Start(){
	startTime = Time.time;
}

function OnGUI () {

	var buttonHeight : int = 100;
	var buttonWidth : int = 200;

	customTexture.pixelInset.x = 0;
	customTexture.pixelInset.y = 0;
	customTexture.pixelInset.width = Screen.width;
	customTexture.pixelInset.height = Screen.height;
}

function Update () {
	if(Time.time - startTime < delayTime) return;
	if(Input.anyKeyDown)
		Application.LoadLevel (nextScene);
}