using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to assign a list of Device Types to a device family.
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7363""}]")]
    public class SystemDeviceFamilyAssignDeviceTypeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceFamilyName;

        [XmlElement(ElementName = "deviceFamilyName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7363")]
        [MinLength(1)]
        [MaxLength(30)]
        public string DeviceFamilyName
        {
            get => _deviceFamilyName;
            set
            {
                DeviceFamilyNameSpecified = true;
                _deviceFamilyName = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceFamilyNameSpecified { get; set; }

        private List<string> _deviceTypeName = new List<string>();

        [XmlElement(ElementName = "deviceTypeName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7363")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> DeviceTypeName
        {
            get => _deviceTypeName;
            set
            {
                DeviceTypeNameSpecified = true;
                _deviceTypeName = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeNameSpecified { get; set; }

    }
}
