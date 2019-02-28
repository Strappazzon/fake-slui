while(1){

	$procname = Get-Process slui -ErrorAction SilentlyContinue
	if($procname){}

	else{
		Start-Process -FilePath "C:\PATH\TO\EXECUTABLE\slui.exe"
	}

	Remove-Variable procname
	Start-Sleep 120 #Check if slui is open every this amount of time (seconds)
}
