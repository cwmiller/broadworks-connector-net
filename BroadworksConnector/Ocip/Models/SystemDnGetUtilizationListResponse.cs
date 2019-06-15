using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDnUtilizationGetListRequest.
    /// The table columns are: "Service Provider Id", "Phone Numbers", "Assigned to Groups",
    /// "Percentage Assigned", "Is Enterprise", "Activated on Groups", "Reseller Id".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
        /// <see cref="SystemDnUtilizationGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDnGetUtilizationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _dnUtilizationTable;

        [XmlElement(ElementName = "dnUtilizationTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnUtilizationTable {
            get => _dnUtilizationTable;
            set {
                DnUtilizationTableSpecified = true;
                _dnUtilizationTable = value;
            }
        }

        [XmlIgnore]
        public bool DnUtilizationTableSpecified { get; set; }
        
    }
}
