@echo off

Color 2
Netsh advfirewall set allprofiles state off

echo.
echo Firewall notifications deactivated. Press Yes on any prompts that may appear to turn notifications off too.
echo.
pause