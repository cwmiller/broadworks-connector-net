using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest.
    /// The column headings are "Phone Number", "Group Id" and "Mobile Network".
        /// <see cref="ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
