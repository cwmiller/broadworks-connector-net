using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of enterprise accessible devices that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:1327""}]")]
    public class ReplacementEnterpriseDeviceList
    {

        protected List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> _device = new List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice>();

        [XmlElement(ElementName = "device", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1327")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> Device
        {
            get => _device;
            set
            {
                DeviceSpecified = true;
                _device = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceSpecified { get; set; }

    }
}
