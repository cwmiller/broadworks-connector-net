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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4420""}]")]
    public class ReplacementDeviceList
    {

        protected List<BroadWorksConnector.Ocip.Models.AccessDevice> _device = new List<BroadWorksConnector.Ocip.Models.AccessDevice>();

        [XmlElement(ElementName = "device", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4420")]
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
        protected bool DeviceSpecified { get; set; }

    }
}
