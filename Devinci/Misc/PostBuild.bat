@ECHO OFF
ECHO ----------------------------------------------------------------------------------------------
ECHO Copying files 
ECHO from: %1
ECHO to: %2
ECHO.
ECHO Deleting files from %2...
DEL "%2\*.*" /q
COPY %1*.dll %2
COPY %1*.exe %2
COPY %1*.config %2
COPY %1*.json %2

ECHO ----------------------------------------------------------------------------------------------
