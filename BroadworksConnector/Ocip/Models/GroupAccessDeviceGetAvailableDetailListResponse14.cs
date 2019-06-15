using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceGetAvailableDetailListRequest14.
        /// <see cref="GroupAccessDeviceGetAvailableDetailListRequest14"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAccessDeviceGetAvailableDetailListResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse14AvailableAccessDevice> _availableAccessDevice;

        [XmlElement(ElementName = "availableAccessDevice", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse14AvailableAccessDevice> AvailableAccessDevice {
            get => _availableAccessDevice;
            set {
                AvailableAccessDeviceSpecified = true;
                _availableAccessDevice = value;
            }
        }

        [XmlIgnore]
        public bool AvailableAccessDeviceSpecified { get; set; }
        
    }
}
