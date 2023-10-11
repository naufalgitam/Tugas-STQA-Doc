; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Kafe Sixteen"
#define MyAppVersion "1.0"
#define MyAppPublisher "TI UMY"
#define MyAppURL "https://ti.umy.ac.id/"
#define MyAppExeName "CobaPAWUASNo2.exe"
#define MyAppAssocName MyAppName + " File"
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{CEB83019-39AC-42E4-9775-E445D53341D0}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=D:\COBA UAS PAW NO2 FINAL
OutputBaseFilename=Kafe Sixteen
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\ASUS\source\repos\CobaPAWUASNo2\CobaPAWUASNo2\bin\Debug\netcoreapp3.1\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ASUS\source\repos\CobaPAWUASNo2\CobaPAWUASNo2\bin\Debug\netcoreapp3.1\CobaPAWUASNo2.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ASUS\source\repos\CobaPAWUASNo2\CobaPAWUASNo2\bin\Debug\netcoreapp3.1\CobaPAWUASNo2.runtimeconfig.dev.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ASUS\source\repos\CobaPAWUASNo2\CobaPAWUASNo2\bin\Debug\netcoreapp3.1\CobaPAWUASNo2.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ASUS\source\repos\CobaPAWUASNo2\CobaPAWUASNo2\bin\Debug\netcoreapp3.1\CobaPAWUASNo2.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\ASUS\source\repos\CobaPAWUASNo2\CobaPAWUASNo2\bin\Debug\netcoreapp3.1\CobaPAWUASNo2.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKA; Subkey: "Software\Classes\Applications\{#MyAppExeName}\SupportedTypes"; ValueType: string; ValueName: ".myp"; ValueData: ""

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

