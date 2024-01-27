using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to unassign a list of Device Types to a device family. Device family name
    /// should be unique through out the system including all the reseller level device families.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in the XS data mode:
    /// resellerId
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7729""}]")]
    public class SystemDeviceFamilyUnassignDeviceTypeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceFamilyName;

        [XmlElement(ElementName = "deviceFamilyName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7729")]
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

        protected List<string> _deviceTypeName = new List<string>();

        [XmlElement(ElementName = "deviceTypeName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7729")]
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
