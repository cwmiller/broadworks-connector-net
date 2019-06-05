using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumbersAssignmentTable;

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumbersAssignmentTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumbersAssignmentTable
        {
            get => _mobileSubscriberDirectoryNumbersAssignmentTable;
            set
            {
                MobileSubscriberDirectoryNumbersAssignmentTableSpecified = true;
                _mobileSubscriberDirectoryNumbersAssignmentTable = value;
            }
        }

        [XmlIgnore]
        public bool MobileSubscriberDirectoryNumbersAssignmentTableSpecified { get; set; }
    }
}
