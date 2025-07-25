using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using JSCoreLibRazor;

namespace DreamSmart.Shared
{
    public class Global
    {

        //public static string APIURL = "http://116.72.16.122:44332/api";
#if DEBUG
       public static string APIURL = "http://192.168.1.66:44333/api";
       //public static string APIURL = "http://115.96.27.178:44332/api";
#else
        public static string APIURL = "http://115.96.27.178:44332/api";
#endif

        public static string SfDialogMsg = CoreVars.APPMANAGER;//"Jupiter Data Manager";
        public static string AppType = "DREAMSMART";
        public static string DSAdminMob = "9998970699";
        public static string AdminMob = "8780178336";
        public static List<string> SumColNm = new List<string>();
        public static List<string> CntColNm = new List<string>();
        public static bool RptCriteria = false;
        public static string AppVersion = "1.5.9";
        public static bool lDetUserActLog = false;
        public static List<string> GrpColNm = new List<string>();
        public static bool lDashChart = false;
        public static string CompListNm = string.Empty;
        
        public static string UserName = "";
        public static string UserType = "";
        public static string MainDB = "";
        public static SQLConnStr PtyDBConnstr = new();
        public static SQLConnStr MainDBConnStr = new()
        {
            DBServer = "(local)\\SQL2016",
            DBName = "DreamSmart",
            UserName = "sa",
            Password = "Jupiter@304#",
            AppType = "DREAMSMART"
        };
        public static void ExitApp()
        {
            Environment.Exit(0);
        }
    }
    
    //public class ClsLogin
    //{
    //    public string? TblName { get; set; } = string.Empty;
    //    public string? UserNameFld { get; set; } = string.Empty;
    //    public string? PasswordFld { get; set; } = string.Empty;
    //    public string? UserRoleFld { get; set; } = string.Empty;
    //    public string? UserNameVal { get; set; } = string.Empty;
    //    public string? PasswordVal { get; set; } = string.Empty;
    //    public string? UserRoleVal { get; set; } = string.Empty;

    //}
    //public class RetJSON
    //{
    //    public string? Status { get; set; }
    //    public string? Data { get; set; } 
    //    public string? Msg { get; set; } 
    //    public string? ExError { get; set; } 
    //    public string? AdtData { get; set; } 
    //    public string? SaveTblName { get; set; } 
    //    public string? ModIdFld { get; set; } 
    //}

    //public class SQLConnStr
    //{
    //    public string ConnName { get; set; }
    //}

    //public class SQLTblFldDef
    //{
    //    public string FldName { get; set; }
    //    public string DataType { get; set; }
    //    public int Length { get; set; }
    //    public int Decimal { get; set; }
    //    public string IsPK { get; set; }
    //    public string FKTblName { get; set; }
    //    public string FKTblId { get; set; }
    //    public bool Hidden { get; set; }
    //    public int ColOrder { get; set; }
    //    public bool Mendatory { get; set; }
    //    public bool Remove { get; set; }
    //    public bool Edit { get; set; }
    //    public string ListOf { get; set; }
    //    public bool DBSave { get; set; }
    //    public bool Total { get; set; }
    //    public string Formula { get; set; }
    //    public string FormulaArea { get; set; }
    //    public bool Fire { get; set; }



    //    public SQLTblFldDef(string FldName, string DataType, int Length, int Decimal, string IsPK, string FKTblName, string FKTblId, bool Hidden, int ColOrder,
    //       bool Remove, bool Mendatory, bool Edit, string ListOf, bool DBSave, bool Total, string Formula, string FormulaArea, bool Fire)
    //    {
    //        this.FldName = FldName;
    //        this.DataType = DataType;
    //        this.Length = Length;
    //        this.Decimal = Decimal;
    //        this.IsPK = IsPK;
    //        this.FKTblName = FKTblName;
    //        this.FKTblId = FKTblId;
    //        this.Hidden = Hidden;
    //        this.ColOrder = ColOrder;
    //        this.Mendatory = Mendatory;
    //        this.Remove = Remove;
    //        this.Edit = Edit;
    //        this.ListOf = ListOf;
    //        this.DBSave = DBSave;
    //        this.Total = Total;
    //        this.Formula = Formula;
    //        this.FormulaArea = FormulaArea;
    //        this.Fire = Fire;

    //    }
    //}
    //public class ClsGetTableData
    //{
    //    public string TableName { get; set; } = string.Empty;
    //    public string WhereCond { get; set; } = string.Empty;
    //    public string SelectClause { get; set; } = string.Empty;
    //    public string Query { get; set; } = string.Empty;
    //    public bool GridExists { get; set; } = false;
    //    public string ModName { get; set; } = string.Empty;
    //    public string QueryType { get; set; } = string.Empty;
    //    public bool CheckRow { get; set; } = false;
    //    public string OrdBy { get; set; } = string.Empty;
    //}

    public class ParentMenu
    {
        public int Id { get; set; }
        public string? Parent { get; set; }
    }
    public class MenuObj
    {
        public string? MenuType { get; set; }
        public string? Menu { get; set; }
        public Type? TargetType { get; set; }
        public bool AutoGen { get; set; }
        public int Id { get; set; }
        public int ParentId { get; set; }
        public bool IsParent { get; set; }
        public bool HasSubItem { get; set; }
        public string? PageName { get; set; }
       
    }

    public class ModType
    {
        public string? Name { get; set; }
    }

    //public class DSRptDevDet
    //{
    //    public string DeviceId { get; set; }
    //    public string AppType { get; set; }
    //    public string ApprType { get; set; }
    //    public int ReportId { get; set; }
    //    public string ListColName { get; set; }
    //    public string CompIdList { get; set;}
    //    public string MainDB { get; set; }
    //    public string YearId { get; set; }
    //    public long PartyId { get; set; }
    //    public string QueryCond { get; set; }
    //    public string RptName { get; set; }
    //    public string MultiFirm { get; set; }
    //    public string Chart { get; set;}
    //    public string XAxis { get; set; }
    //    public string YAxis1 { get; set; }
    //    public string YAxis2 { get; set; }
    //    public string CompDB { get; set;}
    //    public string YrSel { get; set; }
    //    public string Party { get; set; }
    //    public string CPerson { get; set; }
    //    public string MobileNo { get; set;}
    //}
    //[RegularExpression(@"^([0 - 9]*|\d*\d{1}?\d*)$", ErrorMessage = "Please enter valid number.")]
    public class DevRegDet
    {
        //[Required, Display(Name = "Details: CompName")]
        [Required(ErrorMessage = "Enter Company name.")]
        [MinLength(2, ErrorMessage = "Company Name should have more than 2 characters.")]
        public string? CompName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter Contact person.")]
        [MinLength(2, ErrorMessage = "Name should have more than 2 characters.")]
        public string? CPerson { get; set; } = string.Empty;

        [Required]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Please enter valid number.")]
        public string? MobileNo { get; set; } = string.Empty;

        public string? Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select your business.")]
        public string? BusinessVal { get; set; } = string.Empty;

    }

    //public class SaveDataObj
    //{
    //    public string MstTable { get; set; }
    //    public List<AllRowValue> MstTblRowData { get; set; }

    //}

    public class ReportDet
    {
        public int ReportId { get; set; }
        public string? ReportName { get; set; }
        public string? MultiFirm { get; set; }
        public string? Chart { get; set; }
        public string? XAxis { get; set; }
        public string? YAxis1 { get; set; }
        public string? YAxis2 { get; set; }
        public string? CompDB { get; set; }
        public string? DeviceId { get; set; }
        public string? AppType { get; set; }
        public string? ApprType { get; set; }
        public string? ListColName { get; set; }
        public string? CompIdList { get; set; }
        public string? MainDB { get; set; }
        public string? YearId { get; set; }
        public long PartyId { get; set; }
        public string? QueryCond { get; set; }
        public string? YrSel { get; set; }
        public string? Business { get; set; }
    }

    public class ObjType
    {
        public string? FldName { get; set; }
        public string? FldType { get; set; }
        public string? Title { get; set; }
        public int Length { get; set; }
        public int Decimal { get; set; }

    }

    public class DropDownListObject
    {
        public string? ID { get; set; }
        public string? Text { get; set; }
    }

    public class ObjDet
    {
        public string? SqlFldName { get; set; }
        public string? ColName { get; set; }
        public string? DataType { get; set; }
        public string? CriType { get; set; }
        public string? StrVal { get; set; }
        public string[]? ComboVal { get; set; }
        public DateTime? DateVal { get; set; }
        //public DateOnly? DateVal { get; set; }
        public decimal? NumVal { get; set; }
        public string? Alias { get; set; }
    }
    public class ChartDataItem
    {
        public string XValue { get; set; } = string.Empty;
        public double YValue { get; set; }
        public string RptName { get; set; } = string.Empty;

    }

    public class AllChartDataItem
    {
        public List<ChartDataItem>? allChartDatas { get; set; }
    }
    public class MyStateContainer
    {
        public DSRptDevDet? Value { get; set; }
        public event Action OnStateChange;
        public void SetValue(DSRptDevDet value)
        {
            Value = value;
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnStateChange?.Invoke();
    }


}
