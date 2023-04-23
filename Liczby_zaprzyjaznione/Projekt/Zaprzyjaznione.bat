@echo off
:menu
cls
echo -------------Menu-------------
echo 1. Uruchom program          
echo 2. Wyswietl informacje      
echo 3. Backup                   
echo 4. Zakoncz 
echo ------------------------------  
echo:
set /p wybierz="Wybierz numer polecenia (1,2,3,4) "
IF %wybierz%==1 GOTO opcja1
IF %wybierz%==2 GOTO opcja2
IF %wybierz%==3 GOTO opcja3
IF %wybierz%==4 GOTO exit
:opcja1
cd /d C:\Users\kogut\Desktop\Projekt
lp.py
backup.py
raport.html
pause
goto menu

:opcja2
echo Program dla zadanych liczb naturalnych sprawdza czy te liczby sa "zaprzyjaznione".
echo Liczby zaprzyjaznione to para liczb ktorych suma dzielnikow pierwszej liczby rowna sie drugiej liczbie,
echo a suma dzielnikow drugiej liczby rowna sie pierwszej.
echo:
echo Program zwraca komunikat w zaleznosci czy liczby sa zaprzyjaznione czy tez nie.
echo:
echo Autor projektu: Marcin Ryt grupa 4/8
echo:
pause
goto menu

:opcja3
rmdir /s /q Backup
mkdir Backup
xcopy dane.txt Backup
xcopy raport.html Backup
pause
goto menu

:exit
