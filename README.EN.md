# RemcosDetector
[íslenska](README.md)

Last weekend (Okt 5-7 2018) a phishing attack was executed via an email that was sent in the name of the Police. This email was an attack vector for installation of a trojan on PCs running the Windows operating system. This tool can detect whether the Remcos shadesoul trojan has been installed.

## Detection
Usually we would not recommend running an executable from the internet, not even from us. That is why we want to be fully transparent about this tool. What this tool does is detects whether three files are on the file system. The files we search for are the following:
* %userprofile%\AppData\Local\Temp\Windows 93.exe
* %userprofile%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\PrivatacyCleanzer.vbs
* %userprofile%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\UniMP Softwares.vbs

## News
News about the phishing attack has been reported in the Icelandic media.
* [mbl.is](https://www.mbl.is/frettir/innlent/2018/10/07/svikapostur_sem_bodar_folk_i_skyrslutoku/)
* [frettabladid.is](https://www.frettabladid.is/frettir/folk-boa-i-skrslutoeku-i-svikaposti)
* [ruv.is](http://www.ruv.is/frett/nota-thjodskra-og-hafa-augastad-a-einkabonkum)
* [visir.is](http://www.visir.is/g/2018181009087)