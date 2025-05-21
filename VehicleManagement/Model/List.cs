using DevExpress.ClipboardSource.SpreadsheetML;
using System.Data;

namespace Fahrzeugverwaltung.Model
{
    public class InDeUpList
    {
        public string ParameterName { get; set; }
        public SqlDbType DBType { get; set; }
        public object Value { get; set; }
    }

    //public class SelList
    //{
    //    public string ParameterName { get; set; }
    //    public SqlDbType DBType { get; set; }
    //    public object Value { get; set; }
    //}
}