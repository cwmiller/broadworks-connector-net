using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of devices that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3305""}]")]
    public class ReplacementDeviceList
    {

        private List<BroadWorksConnector.Ocip.Models.AccessDevice> _device = new List<BroadWorksConnector.Ocip.Models.AccessDevice>();

        [XmlElement(ElementName = "device", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3305")]
        public List<BroadWorksConnector.Ocip.Models.AccessDevice> Device
        {
            get => _device;
            set
            {
                DeviceSpecified = true;
                _device = value;
            }
        }

        [XmlIgnore]
        public bool DeviceSpecified { get; set; }

    }
}
