@echo off
if exist "%userprofile%\AppData\Local\Temp\Windows 93.exe" (
    echo "Recoms Decoy file here: This computer is infected by Remcos shadesoul"
                PAUSE
                exit
) 
if exist "%userprofile%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\PrivatacyCleanzer.vbs" (
    echo "Recoms persistence file here: This computer is infected by Remcos shadesoul"
                PAUSE
                exit
)
if exist "%userprofile%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\UniMP Softwares.vbs" (
    echo "Recoms persistence file here: This computer is infected by Remcos shadesoul"
                PAUSE
                exit
)
echo "Computer not infected by Remcos campaign shadesoul"
PAUSE
exit
