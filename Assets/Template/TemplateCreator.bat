::�л�����ǰbatĿ¼
cd /d %~dp0

set path=%cd%\

::����ģ���
db.exe -c sqlTableConfig.json -o %path%ky203 -n sqlTableConfig.json -l
pause