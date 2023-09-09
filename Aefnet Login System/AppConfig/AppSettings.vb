Imports System.IO

Module AppSettings

    Public AppYol As String = New FileInfo(Application.ExecutablePath).DirectoryName 'klasör yolu alma
    'Public ExeName As String = Process.GetCurrentProcess().MainModule.FileName ' çalışan exe adı
    'AefnetUpdate Forms
    Public AefnetDownloadURL As String = ""
    Public AefnetVersionURL As String = ""
    Public AefnetVersion As String
    Public AefnetDownloadFileName As String = "\Updatess.zip"
    Public Const AefnetVersion_Yol = "UpdateVersion"

    Public Const LastVersion = "1.0.0.0"

    Public Const DefYol As String = "\wapp"
    Public Const DefStatus As String = "Aktif"

    'AefnetClientUpdaterURL
    Public ClientUpdateConfig As String = AppYol & "\updateconfig.ini"


    'LoginSystemRun
    Public FullUpdaterRun As String = AppYol & "\AefnetUpdater.exe"
    Public AppRun As String = AppYol & "\Aefnet.exe"

    'AppUpdater Forms
    Public AppDownloadURL As String = "http://gitlab.com/fural007/autoupdate/-/raw/AefnetUpdaters/AppUpdaterURL"
    Public AppVersionURL As String = "http://downloads.aefnet.com/AppUpdate/AppVersion"
    Public AppLoginNumberVersion As String
    Public Const AppVersion_Yol = "LoginVersion"
    Public DownloadFileName As String = "\AppUpdater.zip"
    Public FileUpdater As String = AppYol & "\AefnetUpdater"
    Public ToolsRun As String = AppYol & "\AefnetUpdaterTools.exe"

    'AppLibraryRun
    Public UpdaterToolsFile_Yol As String = AppYol & "\AefnetUpdaterTools.exe"
    Public UpdaterToolsMix_Yol As String = AppYol & "\AefnetUpdaterTools.mix"

    Public UpdaterToolsFile As String = "AefnetUpdaterTools.exe"
    Public UpdaterToolsMix As String = "AefnetUpdaterTools.mix"

    'GameExeYol
    Public DTA_Yol As String = AppYol & "\zdta.exe"
    Public Clientdx_Yol As String = AppYol & "\Resources\clientdx.exe"
    Public Clientogl_Yol As String = AppYol & "\Resources\clientogl.exe"
    Public Clientxna_Yol As String = AppYol & "\Resources\clientxna.exe"
    'GameExeName
    Public DTA As String = "zdta.exe"
    Public Clientdx As String = "clientdx.exe"
    Public Clientogl As String = "clientogl.exe"
    Public Clientxna As String = "clientxna.exe"

    'MixYol
    Public DTAMix_Yol As String = AppYol & "\zdta.mix"
    Public ClientdxMix_Yol As String = AppYol & "\Resources\clientdx.mix"
    Public ClientoglMix_Yol As String = AppYol & "\Resources\clientogl.mix"
    Public ClientxnaMix_Yol As String = AppYol & "\Resources\clientxna.mix"

    'MixName
    Public DTAMix As String = "zdta.mix"
    Public ClientdxMix As String = "Clientdx.mix"
    Public ClientoglMix As String = "Clientogl.mix"
    Public ClientxnaMix As String = "Clientxna.mix"


End Module
