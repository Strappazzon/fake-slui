while(1){
	$procname = Get-Process slui -ErrorAction SilentlyContinue

	if ($procname) {
		return
	} else {
		Start-Process -FilePath "C:\PATH\TO\EXECUTABLE\slui.exe"
	}

	Remove-Variable procname
	# Check if 'slui' is running every X seconds
	Start-Sleep 120
}
