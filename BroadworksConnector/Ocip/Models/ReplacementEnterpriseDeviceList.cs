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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:1667""}]")]
    public class ReplacementEnterpriseDeviceList
    {

        protected List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> _device = new List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice>();

        [XmlElement(ElementName = "device", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1667")]
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
