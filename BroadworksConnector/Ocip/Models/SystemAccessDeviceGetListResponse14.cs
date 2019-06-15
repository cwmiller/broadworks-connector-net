using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceGetListRequest14.
    /// Contains a table of devices defined at the System-level.
    /// The column headings are:
    /// "Device Name", "Device Type", "Available Ports", "Net Address" and "MAC Address", "Status", "Version".
        /// <see cref="SystemAccessDeviceGetListRequest14"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccessDeviceGetListResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
