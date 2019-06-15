using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceGetAllRequest.
    /// Contains a table of devices configured in the entire system.
    /// The column headings are: "Service Provider Id", "Is Enterprise", "Group Id",
    /// "Device Name", "Device Type", "Net Address", "MAC Address", "Status", "Reseller Id".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
        /// <see cref="SystemAccessDeviceGetAllRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccessDeviceGetAllResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
