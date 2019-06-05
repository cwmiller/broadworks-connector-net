using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseSessionAdmissionControlGetAvailableDeviceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private List<BroadworksConnector.Ocip.Models.EnterpriseAccessDevice> _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.EnterpriseAccessDevice> AccessDevice
        {
            get => _accessDevice;
            set
            {
                AccessDeviceSpecified = true;
                _accessDevice = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceSpecified { get; set; }
    }
}
