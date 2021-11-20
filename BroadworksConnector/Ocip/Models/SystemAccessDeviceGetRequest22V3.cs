using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the configuration of a specified system access device.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// deviceExternalId
    /// 
    /// The response is either SystemAccessDeviceGetResponse22V3 or ErrorResponse.
    /// 
    /// Replaced By: SystemAccessDeviceGetRequest24
    /// <see cref="SystemAccessDeviceGetResponse22V3"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemAccessDeviceGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:6527"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:6528""}]}]")]
    public class SystemAccessDeviceGetRequest22V3 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAccessDeviceGetResponse22V3>
    {

        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:6528")]
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

        private string _deviceExternalId;

        [XmlElement(ElementName = "deviceExternalId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:6528")]
        [MaxLength(36)]
        public string DeviceExternalId
        {
            get => _deviceExternalId;
            set
            {
                DeviceExternalIdSpecified = true;
                _deviceExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceExternalIdSpecified { get; set; }

    }
}
