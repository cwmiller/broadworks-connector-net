using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a mgcp device type.
    /// See Also: SystemDeviceTypeGetRequest
    /// The response is either SystemMGCPDeviceTypeGetResponse or ErrorResponse.
    /// <see cref="SystemDeviceTypeGetRequest"/>
    /// <see cref="SystemMGCPDeviceTypeGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12325""}]")]
    public class SystemMGCPDeviceTypeGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMGCPDeviceTypeGetResponse>
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12325")]
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
