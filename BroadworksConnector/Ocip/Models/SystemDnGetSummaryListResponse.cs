using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDnGetSummaryListRequest.
    /// The column headings are "Phone Numbers, "Service Provider Id", "Is Enterprise" and "Reseller Id".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
        /// <see cref="SystemDnGetSummaryListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDnGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _dnSummaryTable;

        [XmlElement(ElementName = "dnSummaryTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnSummaryTable {
            get => _dnSummaryTable;
            set {
                DnSummaryTableSpecified = true;
                _dnSummaryTable = value;
            }
        }

        [XmlIgnore]
        public bool DnSummaryTableSpecified { get; set; }
        
    }
}
