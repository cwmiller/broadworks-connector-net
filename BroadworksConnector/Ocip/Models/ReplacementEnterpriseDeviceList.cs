using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of enterprise accessible devices that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementEnterpriseDeviceList 
    {

        
        private List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> _device;

        [XmlElement(ElementName = "device", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> Device {
            get => _device;
            set {
                DeviceSpecified = true;
                _device = value;
            }
        }

        [XmlIgnore]
        public bool DeviceSpecified { get; set; }
        
    }
}
