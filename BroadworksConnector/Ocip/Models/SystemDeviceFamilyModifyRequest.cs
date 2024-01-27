using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a device family.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7706""}]")]
    public class SystemDeviceFamilyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceFamilyName;

        [XmlElement(ElementName = "deviceFamilyName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7706")]
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

        protected string _newDeviceFamilyName;

        [XmlElement(ElementName = "newDeviceFamilyName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7706")]
        [MinLength(1)]
        [MaxLength(30)]
        public string NewDeviceFamilyName
        {
            get => _newDeviceFamilyName;
            set
            {
                NewDeviceFamilyNameSpecified = true;
                _newDeviceFamilyName = value;
            }
        }

        [XmlIgnore]
        protected bool NewDeviceFamilyNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementDeviceTypeList _deviceTypeList;

        [XmlElement(ElementName = "deviceTypeList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7706")]
        public BroadWorksConnector.Ocip.Models.ReplacementDeviceTypeList DeviceTypeList
        {
            get => _deviceTypeList;
            set
            {
                DeviceTypeListSpecified = true;
                _deviceTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementTagSetList _tagSetList;

        [XmlElement(ElementName = "tagSetList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7706")]
        public BroadWorksConnector.Ocip.Models.ReplacementTagSetList TagSetList
        {
            get => _tagSetList;
            set
            {
                TagSetListSpecified = true;
                _tagSetList = value;
            }
        }

        [XmlIgnore]
        protected bool TagSetListSpecified { get; set; }

    }
}
