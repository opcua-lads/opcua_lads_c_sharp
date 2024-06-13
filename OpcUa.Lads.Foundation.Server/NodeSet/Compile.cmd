ECHO off
ECHO Generate NodeSet code

REM Make output directories
MKDIR .\output

set modelCompilerPath="..\..\Externals\Opc.Ua.ModelCompiler 2.4.0\Opc.Ua.ModelCompiler.exe"

REM Generate Opc.Ua.Di
ECHO Generate Opc.Ua.Di

%modelCompilerPath% ^
compile -d2 .\Opc.Ua.DI.NodeSet2.xml,Opc.Ua.Di,DI ^
-version v105 ^
-o2 .\output


REM Generate Opc.Ua.AMB
ECHO Generate Opc.Ua.AMB

%modelCompilerPath% ^
compile -d2 .\Opc.Ua.AMB.NodeSet2.xml,Opc.Ua.AMB,AMB ^
-d2 .\Opc.Ua.Di.NodeSet2.xml,Opc.Ua.Di,DI ^
-version v105 ^
-o2 .\output


REM Generate Opc.Ua.Machinery
ECHO Generate Opc.Ua.Machinery

%modelCompilerPath% ^
compile -d2 .\Opc.Ua.Machinery.NodeSet2.xml,Opc.Ua.Machinery,MBBB ^
-d2 .\Opc.Ua.AMB.NodeSet2.xml,Opc.Ua.AMB,AMB ^
-d2 .\Opc.Ua.DI.NodeSet2.xml,Opc.Ua.Di,DI ^
-version v105 ^
-o2 .\output

 
REM Generate Opc.Ua.LADS
ECHO Generate Opc.Ua.LADS

%modelCompilerPath% ^
compile -d2 .\Opc.Ua.LADS.NodeSet2.xml,Opc.Ua.LADS,LADS ^
-d2 .\Opc.Ua.Machinery.NodeSet2.xml,Opc.Ua.Machinery,MBBB ^
-d2 .\Opc.Ua.AMB.NodeSet2.xml,Opc.Ua.AMB,AMB ^
-d2 .\Opc.Ua.DI.NodeSet2.xml,Opc.Ua.Di,DI ^
-version v105 ^
-o2 .\output


REM Generate LuminescenceReader
ECHO Generate LuminescenceReader

%modelCompilerPath% ^
compile -d2 .\LuminescenceReader.xml,Spectaris.LuminescenceReader,LuminescenceReader ^
-d2 .\Opc.Ua.LADS.NodeSet2.xml,Opc.Ua.LADS,LADS ^
-d2 .\Opc.Ua.Machinery.NodeSet2.xml,Opc.Ua.Machinery,MBBB ^
-d2 .\Opc.Ua.AMB.NodeSet2.xml,Opc.Ua.AMB,AMB ^
-d2 .\Opc.Ua.DI.NodeSet2.xml,Opc.Ua.Di,DI ^
-version v105 ^
-o2 .\output