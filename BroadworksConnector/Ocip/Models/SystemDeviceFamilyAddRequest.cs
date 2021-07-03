using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a device family.
    /// When the optional element resellerId is specified, the device family created is at reseller level. Device family name
    /// should be unique throughout the system including all the reseller level device families.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in the XS data mode:
    /// resellerId
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7343""}]")]
    public class SystemDeviceFamilyAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceFamilyName;

        [XmlElement(ElementName = "deviceFamilyName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7343")]
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

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7343")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        private List<string> _assignDeviceType = new List<string>();

        [XmlElement(ElementName = "assignDeviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7343")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> AssignDeviceType
        {
            get => _assignDeviceType;
            set
            {
                AssignDeviceTypeSpecified = true;
                _assignDeviceType = value;
            }
        }

        [XmlIgnore]
        protected bool AssignDeviceTypeSpecified { get; set; }

        private List<string> _assignTagSet = new List<string>();

        [XmlElement(ElementName = "assignTagSet", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7343")]
        [MinLength(1)]
        [MaxLength(30)]
        public List<string> AssignTagSet
        {
            get => _assignTagSet;
            set
            {
                AssignTagSetSpecified = true;
                _assignTagSet = value;
            }
        }

        [XmlIgnore]
        protected bool AssignTagSetSpecified { get; set; }

    }
}
