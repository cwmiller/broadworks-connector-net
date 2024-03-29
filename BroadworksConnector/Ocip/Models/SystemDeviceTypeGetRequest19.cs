using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the information about the specified device type without regard to whether the
    /// type is SIP or MGCP.
    /// The response is either SystemDeviceTypeGetResponse19 or ErrorResponse.
    /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
    /// 
    /// Replaced by: SystemSIPDeviceTypeGetRequest21sp1.
    /// <see cref="SystemDeviceTypeGetResponse19"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSIPDeviceTypeGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:26461""}]")]
    public class SystemDeviceTypeGetRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetResponse19>
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:26461")]
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
