using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a sip device type.
    /// See Also: SystemDeviceTypeGetRequest
    /// The response is either SystemSIPDeviceTypeGetResponse19 or ErrorResponse.
    /// Replaced by: SystemSIPDeviceTypeGetRequest19sp1
    /// <see cref="SystemDeviceTypeGetRequest"/>
    /// <see cref="SystemSIPDeviceTypeGetResponse19"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSIPDeviceTypeGetRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:32060""}]")]
    public class SystemSIPDeviceTypeGetRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32060")]
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
        protected bool DeviceTypeSpecified { get; set; }

    }
}
