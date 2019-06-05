using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumberTable;

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumberTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumberTable
        {
            get => _mobileSubscriberDirectoryNumberTable;
            set
            {
                MobileSubscriberDirectoryNumberTableSpecified = true;
                _mobileSubscriberDirectoryNumberTable = value;
            }
        }

        [XmlIgnore]
        public bool MobileSubscriberDirectoryNumberTableSpecified { get; set; }
    }
}
