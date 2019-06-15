using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest.
    /// The response contains a table with columns: "Mobile Number", "Mobile Network", "Service Provider Id",
    /// "Is Enterprise", "Group Id", "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", "Phone Number", "Extension" and "Reseller Id".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
        /// <see cref="SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumbersSummaryTable;

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumbersSummaryTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumbersSummaryTable {
            get => _mobileSubscriberDirectoryNumbersSummaryTable;
            set {
                MobileSubscriberDirectoryNumbersSummaryTableSpecified = true;
                _mobileSubscriberDirectoryNumbersSummaryTable = value;
            }
        }

        [XmlIgnore]
        public bool MobileSubscriberDirectoryNumbersSummaryTableSpecified { get; set; }
        
    }
}
