# RemcosDetector
[íslenska](README.md)

Last weekend (Oct 5-7 2018) a phishing attack was executed via an email that was sent in the name of the Icelandic police. 
This email was an attack vector for installation of the Remcos-shadesoul trojan, that can infect PCs running the Windows operating system. 
This tool, RemcosDetector, can detect whether the Remcos-shadesoul trojan has infected your computer.

If you received the email, followed the link and downloaded the file from the phishing site the email linked to, you can use this tool detect whether your computer has been infected.

## Detection
Usually we would not recommend running an .exe file directly from the internet. 
However, this tool detects whether three files are on the file system. The files we search for are the following:
* %userprofile%\AppData\Local\Temp\Windows 93.exe
* %userprofile%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\PrivatacyCleanzer.vbs
* %userprofile%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\UniMP Softwares.vbs

If this tool finds these files on your computer, we recommend you contact a computer technician.

## News
News about the phishing attack has been reported in the Icelandic media.
* [mbl.is](https://www.mbl.is/frettir/innlent/2018/10/07/svikapostur_sem_bodar_folk_i_skyrslutoku/)
* [frettabladid.is](https://www.frettabladid.is/frettir/folk-boa-i-skrslutoeku-i-svikaposti)
* [ruv.is](http://www.ruv.is/frett/nota-thjodskra-og-hafa-augastad-a-einkabonkum)
* [visir.is](http://www.visir.is/g/2018181009087)
