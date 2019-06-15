using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Reorder the lines of a System device. You can not add or delete line ports, only
    /// re-ordering the list is allowed. The ordered list of line ports can be obtained
    /// with the SystemAccessDeviceGetRequest16 command.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SystemAccessDeviceGetRequest16"/>
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCPEConfigReorderDeviceLinePortsRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        public string DeviceName {
            get => _deviceName;
            set {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        public bool DeviceNameSpecified { get; set; }
        
        private List<string> _orderedLinePortList;

        [XmlElement(ElementName = "orderedLinePortList", IsNullable = false, Namespace = "")]
        public List<string> OrderedLinePortList {
            get => _orderedLinePortList;
            set {
                OrderedLinePortListSpecified = true;
                _orderedLinePortList = value;
            }
        }

        [XmlIgnore]
        public bool OrderedLinePortListSpecified { get; set; }
        
    }
}
