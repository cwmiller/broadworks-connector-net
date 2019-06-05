using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _availableMobileSubscriberDirectoryNumberTable;

        [XmlElement(ElementName = "availableMobileSubscriberDirectoryNumberTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable AvailableMobileSubscriberDirectoryNumberTable
        {
            get => _availableMobileSubscriberDirectoryNumberTable;
            set
            {
                AvailableMobileSubscriberDirectoryNumberTableSpecified = true;
                _availableMobileSubscriberDirectoryNumberTable = value;
            }
        }

        [XmlIgnore]
        public bool AvailableMobileSubscriberDirectoryNumberTableSpecified { get; set; }
    }
}
