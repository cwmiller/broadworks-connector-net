using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Activates or deactivates a device configured at the System level. It is only possible for this request to
    /// activate a device which is deactivated. Trying to activate a device in the activating state will result in an error response
    /// since only the DAS is allowed to execute this operation.
    /// Returns a SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:936""}]")]
    public class SystemAccessDeviceDeviceActivationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:936")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceName
        {
            get => _deviceName;
            set
            {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceNameSpecified { get; set; }

        protected bool _activateDevice;

        [XmlElement(ElementName = "activateDevice", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:936")]
        public bool ActivateDevice
        {
            get => _activateDevice;
            set
            {
                ActivateDeviceSpecified = true;
                _activateDevice = value;
            }
        }

        [XmlIgnore]
        protected bool ActivateDeviceSpecified { get; set; }

    }
}
