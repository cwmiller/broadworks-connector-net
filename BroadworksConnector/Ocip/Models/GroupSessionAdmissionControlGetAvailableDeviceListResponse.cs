using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupSessionAdmissionControlGetAvailableDeviceListRequest.
    /// Contains a table of devices can be assigned to session admission control group in the group.
        /// <see cref="GroupSessionAdmissionControlGetAvailableDeviceListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupSessionAdmissionControlGetAvailableDeviceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.AccessDevice> _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.AccessDevice> AccessDevice {
            get => _accessDevice;
            set {
                AccessDeviceSpecified = true;
                _accessDevice = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceSpecified { get; set; }
        
    }
}
