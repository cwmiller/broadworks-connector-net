using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceGetPagedSortedListRequest.
    /// Contains a table of devices configured in the group.
    /// The column headings are: "Device Name", "Device Type", "Available Ports", "Net Address", "MAC Address", "Status" and "Version".
        /// <see cref="GroupAccessDeviceGetPagedSortedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAccessDeviceGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _accessDeviceTable;

        [XmlElement(ElementName = "accessDeviceTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AccessDeviceTable {
            get => _accessDeviceTable;
            set {
                AccessDeviceTableSpecified = true;
                _accessDeviceTable = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceTableSpecified { get; set; }
        
    }
}
