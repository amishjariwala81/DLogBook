//using Bumptech.Glide.Util;
using DLogBook.Data;
using JSCoreLibRazor;
using Microsoft.AspNetCore.Components;
using SQLite;
using Syncfusion.Blazor.Buttons;
using Syncfusion.Blazor.Calendars;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Inputs;
using Syncfusion.Blazor.Popups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DLogBook.Shared
{
    public class Global
    {
#if DEBUG
       // public static string APIURL = " http://localhost:55555/api";
        //"http://192.168.1.6:44333/api"; 
        //public static string APIURL = "http://192.168.1.66:44333/api";
       public static string APIURL = "http://115.96.27.178:44333/api";
#else
        public static string APIURL = "http://115.96.27.178:44333/api";
#endif
        public static string MobileNo = String.Empty;
        public static string AppType = "DLogBook";
        public static string SYSAdminMob = "9998970699";
        public static string Sheet = String.Empty;
        public static string Shift = String.Empty;
        public static string SheetGrp = String.Empty;
        public static string AppVersion = "1.0.4";
        public static string RPtyName = String.Empty;
        public static bool lDetUserActLog = false;
        public static string QueryCond = string.Empty;
        public static int AddEditMode = 0;
        public static string GetDetailById = string.Empty;

        public static string UserName = String.Empty;
        public static string UserType = "";
        public static string MainDB = "";
        public static bool IsInterNetConnected = false;
        public static string PtyAPIURL = string.Empty;
        public static bool IsReadOnly = true;
        public static bool ShowPendTask = false;
        public static string SOperator = string.Empty;
        public static string SLoginDate = string.Empty;
        public static string PtyName = string.Empty;
        public static string SheetId = string.Empty;
        public static int ReadingCnt = 0;
        public static int SelLogNo = 0;
        public static SQLConnStr MainDBConnStr = new()
        {
            AppType = "DLogBook",
            DBServer = "(local)\\SQL2016",
            DBName = "DreamSmart",
            UserName = "sa",
            Password = "Jupiter@304#"
        };
        public static SQLConnStr PtyDBConnStr = new();
        public static void ExitApp()
        {
            Environment.Exit(0);
        }
        
    }

    public class SheetDet
    {
        [PrimaryKey]
        public int? Id { get; set; }
        public string? Sheet { get; set; }
    }
    public class UserDet
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Module { get; set; }
        public string? Sheet { get; set; }
        public string? Operator { get; set; }

    }
    public class DevParamDet
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string? Sheet { get; set; }
        public string? GrpName { get; set; }
        public string? SubParam { get; set; }
        public string? SubDetId { get; set; }
        public string? Shift { get; set; }
        public string? Unit { get; set; }
        public string? Range { get; set; }
        public string MinVal { get; set; }
        public string MaxVal { get; set; }
        public string? FixVal { get; set; }
        public string? ParamData { get; set; }
        public string? DataType { get; set; }
        public string? Operator { get; set; }
        public string? PDispName { get; set; }
        public string? GDispName { get; set; }
        public string? RowNo { get; set; }
        public string? ColNo { get; set; }
        public string? SNAME { get; set; }
        public string? SSHIFT { get; set; }
        public string? SDATE { get; set; }
        public string? SUSER { get; set; }
        public string? LogDate { get; set; }
        public string? LogTime { get; set; }
        public string SheetId { get; set; } = string.Empty;
        public string? QRCodePattern { get; set; } = "0";
    }

    public class LogModel
    {

        public int Id { get; set; }
        public string? Sheet { get; set; }
        public string? GrpName { get; set; }
        public string? SubParam { get; set; }
        public string? SubDetId { get; set; }
        public string? Shift { get; set; }
        public string? Unit { get; set; }
        public string? Range { get; set; }
        public string? MinVal { get; set; }
        public string? MaxVal { get; set; }
        public string? FixVal { get; set; }
        public string? ParamData { get; set; }
        public string? DataType { get; set; }
        public string? Operator { get; set; }
        public string? PDispName { get; set; }
        public string? GDispName { get; set; }
        public int RowNo { get; set; }
        public int ColNo { get; set; }
        public string? SNAME { get; set; }
        public string? SSHIFT { get; set; }
        public string? SDATE { get; set; }
        public string? SUSER { get; set; }
        public string? LogDate { get; set; }
        public string? LogTime { get; set; }
        public string? DispName { get; set; }
        public string ComboLst { get; set; } = "";
        public string StrVal { get; set; } = "";
        public int IntVal { get; set; } = 0;
        public double DoubleVal { get; set; } = 0;
        public bool CheckVal { get; set; } = false;
        public TimeOnly TimeVal { get; set; }
        public DateTime DateVal { get; set; } = DateTime.Now.Date;
        public string DropDownVal { get; set; } = "";

        public SfTextBox TextCtrl { get; set; }
        public SfNumericTextBox<int> IntNumbeCtrl { get; set; }
        public SfNumericTextBox<double> DoubleNumberCtrl { get; set; }
        public SfDatePicker<DateTime> DateCtrl { get; set; }
        public SfTimePicker<TimeOnly> TimeCtrl { get; set; }
        public SfCheckBox<bool> CheckBoxCtrl { get; set; }
        public SfDropDownList<string, string> DropdownCtrl { get; set; }


        // To remove following
        public string CtrlType { get; set; } = string.Empty;
        public string CellTag { get; set; } = string.Empty;
        public string CellNote { get; set; } = string.Empty;
        public string CellVal { get; set; } = string.Empty;

        public bool Bold { get; set; } = false;
        public bool Italic { get; set; } = false;
        public bool Underline { get; set; } = false;
        public bool Strikeout { get; set; } = false;
        public string Font { get; set; } = string.Empty;
        public int Size { get; set; } = 10;
        public string BC { get; set; } = string.Empty;
        public string FC { get; set; } = string.Empty;
        public string FormatStr { get; set; } = string.Empty;

        public bool IsAttached = false;

        public bool IsTask = false;
        public string LogLabel = string.Empty;
        public bool LogShow { get; set; } = true;
        public bool OptionShow { get; set; } = true;
        public string QRCodePattern { get; set; } = string.Empty;
        public string SheetId { get; set; } = string.Empty;
    }

    public class LogSave
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string? DropDownVal { get; set; }
        public string? StrVal { get; set; }
    }
    public class HelpTopics
    {
        public int HelpId { get; set; }
        public string AppType { get; set; }
        public string Topic { get; set; }
        public string IOSURL { get; set; }
        public string AndrURL { get; set; }
        public string ViewURL { get; set; }

    }

    public class TaskMst
    {
        [PrimaryKey]
        public string TaskId { get; set; }
        public string Task { get; set; }
        public string Operator { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Status { get; set; }
    }

    public class TaskDet
    {
        public string TaskId { get; set; }
        public string Action { get; set; }
        public string Operator { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Status { get; set; }
    }
    public class JSEmailSetUp
    {
        public string EmailAdd { get; set; }
        public string DispName { get; set; }
        public string Password { get; set; }
        public string MailServer { get; set; }
        public string PortNo { get; set; }
        public string SSL { get; set; }
        public string EmailAuth { get; set; }
        public string ToEmailAdd { get; set; }
    }
    //public static class ProjFunc
    //{
    //    #nullable disable
    //    [InjectAttribute]
    //    public static SfDialogService sfDialog { get; set; }
    //    [Inject]
    //    public static NavigationManager navigationManager { get; set; }
    //    public static async void ScanQRCode()
    //    {
    //        try
    //        {
    //            DatabaseContext _context1 = new DatabaseContext();
    //            string SheetGrpName;
    //            SheetGrpName = await sfDialog.PromptAsync("Enter Group Name:", CoreVars.APPMANAGER);
    //            if (!string.IsNullOrEmpty(SheetGrpName))
    //            {
    //                var parts = SheetGrpName.Split('_', 2);
    //                if (parts.Length > 0)
    //                {
    //                    Global.Sheet = parts[0];
    //                }
    //                if (parts.Length > 1)
    //                {
    //                    Global.SheetGrp = parts[1];
    //                }

    //                if (!string.IsNullOrEmpty(Global.Sheet) && !string.IsNullOrEmpty(Global.SheetGrp))
    //                {
    //                    Expression<Func<DevParamDet, bool>> predicare2 = GrpData => (GrpData.Sheet == Global.Sheet && GrpData.GrpName == Global.SheetGrp);
    //                    var GrpNameData = await _context1.GetFileteredAsync(predicare2);
    //                    int EmptyPrmCnt = GrpNameData.Count();
    //                    if (EmptyPrmCnt > 0)
    //                    {
    //                        navigationManager.NavigateTo("/parameter");
    //                    }
    //                    else
    //                    {
    //                        await sfDialog.AlertAsync("Group Not Found.", CoreVars.EXERROR);
    //                    }
    //                }
    //                else
    //                {
    //                    await sfDialog.AlertAsync("Group is Empty.", CoreVars.EXERROR);
    //                }
    //            }

    //        }
    //        catch (Exception ex)
    //        {
    //            await sfDialog.AlertAsync("GroupScanner => " + ex.Message, CoreVars.EXERROR);

    //        }

    //    }
    //}
}

