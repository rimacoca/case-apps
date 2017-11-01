#define MyAppName "CASE Apps"
#define MyAppVersion "17.11.1"
#define MyAppPublisher "CASE"
#define MyAppURL "https://github.com/WeConnect/case-apps"

#define RevitAppName  "Case.Apps"
#define RevitAddinFolder "{userappdata}\Autodesk\REVIT\Addins"
#define RevitFolder16 RevitAddinFolder+"\2016\"+RevitAppName
#define RevitAddin16  RevitAddinFolder+"\2016\"
#define RevitFolder17 RevitAddinFolder+"\2017\"+RevitAppName
#define RevitAddin17  RevitAddinFolder+"\2017\"
#define RevitFolder18 RevitAddinFolder+"\2018\"+RevitAppName
#define RevitAddin18  RevitAddinFolder+"\2018\"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{1AE796B6-5B97-4CC7-848A-C3F44956FB90}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableDirPage=yes
DefaultGroupName=CASE Design, Inc\{#MyAppName}
DisableProgramGroupPage=yes
LicenseFile=.\LICENSE
OutputDir=.
OutputBaseFilename=CASEApps-installer
SetupIconFile=assets\logo.ico
WizardImageFile=assets\banner.bmp
Compression=lzma
SolidCompression=yes
;info: http://revolution.screenstepslive.com/s/revolution/m/10695/l/95041-signing-installers-you-create-with-inno-setup
;comment/edit the line below if you are not signing the exe with the CASE pfx
;SignTool=signtoolcase

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Components]
Name: revit16; Description: CASE Apps for Autodesk Revit 2016;  Types: full
Name: revit17; Description: CASE Apps for Autodesk Revit 2017;  Types: full
Name: revit18; Description: CASE Apps for Autodesk Revit 2018;  Types: full

[Files]

;REVIT 2016 ~~~~~~~~~~~~~~~~~~~
Source: "deploy\2016\*"; DestDir: "{#RevitFolder16}"; Excludes: "*.pdb,*.xml,*.config,*.addin,*.tmp"; Flags: ignoreversion recursesubdirs createallsubdirs; Components: revit16 
Source: "deploy\{#RevitAppName}.addin"; DestDir: "{#RevitAddin16}"; Flags: ignoreversion; Components: revit16

;REVIT 2017 ~~~~~~~~~~~~~~~~~~~
Source: "deploy\2017\*"; DestDir: "{#RevitFolder17}"; Excludes: "*.pdb,*.xml,*.config,*.addin,*.tmp"; Flags: ignoreversion recursesubdirs createallsubdirs; Components: revit17 
Source: "deploy\{#RevitAppName}.addin"; DestDir: "{#RevitAddin17}"; Flags: ignoreversion; Components: revit17

;REVIT 2018 ~~~~~~~~~~~~~~~~~~~
Source: "deploy\2018\*"; DestDir: "{#RevitFolder18}"; Excludes: "*.pdb,*.xml,*.config,*.addin,*.tmp"; Flags: ignoreversion recursesubdirs createallsubdirs; Components: revit18 
Source: "deploy\{#RevitAppName}.addin"; DestDir: "{#RevitAddin18}"; Flags: ignoreversion; Components: revit18

; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
