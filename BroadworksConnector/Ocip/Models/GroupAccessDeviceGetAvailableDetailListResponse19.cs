using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAccessDeviceGetAvailableDetailListResponse19 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private List<BroadworksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse19AvailableAccessDevice> _availableAccessDevice;

        [XmlElement(ElementName = "availableAccessDevice", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse19AvailableAccessDevice> AvailableAccessDevice
        {
            get => _availableAccessDevice;
            set
            {
                AvailableAccessDeviceSpecified = true;
                _availableAccessDevice = value;
            }
        }

        [XmlIgnore]
        public bool AvailableAccessDeviceSpecified { get; set; }
    }
}
