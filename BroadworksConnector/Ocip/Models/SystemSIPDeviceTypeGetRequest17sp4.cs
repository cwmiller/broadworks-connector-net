using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replaced by: SystemSIPDeviceTypeGetRequest18.
    /// Request to get a sip device type.
    /// See Also: SystemDeviceTypeGetRequest
    /// The response is either SystemSIPDeviceTypeGetResponse17sp4 or ErrorResponse.
    /// Replaced by: SystemSIPDeviceTypeGetRequest18
    /// <see cref="SystemSIPDeviceTypeGetRequest18"/>
    /// <see cref="SystemDeviceTypeGetRequest"/>
    /// <see cref="SystemSIPDeviceTypeGetResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSIPDeviceTypeGetRequest18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:22416""}]")]
    public class SystemSIPDeviceTypeGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22416")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceType
        {
            get => _deviceType;
            set
            {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeSpecified { get; set; }

    }
}
