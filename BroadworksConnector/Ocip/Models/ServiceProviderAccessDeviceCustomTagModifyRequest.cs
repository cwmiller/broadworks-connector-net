using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a static configuration tag for a service provider access device.
    /// 
    /// The tagValueToEncrypt element can only be used by a system administrator.
    /// 
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// tagValueToEncrypt
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:403"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:407""}]}]")]
    public class ServiceProviderAccessDeviceCustomTagModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:403")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:403")]
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

        private string _tagName;

        [XmlElement(ElementName = "tagName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:403")]
        [MinLength(1)]
        [MaxLength(64)]
        public string TagName
        {
            get => _tagName;
            set
            {
                TagNameSpecified = true;
                _tagName = value;
            }
        }

        [XmlIgnore]
        protected bool TagNameSpecified { get; set; }

        private string _tagValue;

        [XmlElement(ElementName = "tagValue", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:407")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TagValue
        {
            get => _tagValue;
            set
            {
                TagValueSpecified = true;
                _tagValue = value;
            }
        }

        [XmlIgnore]
        protected bool TagValueSpecified { get; set; }

        private string _tagValueToEncrypt;

        [XmlElement(ElementName = "tagValueToEncrypt", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:407")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TagValueToEncrypt
        {
            get => _tagValueToEncrypt;
            set
            {
                TagValueToEncryptSpecified = true;
                _tagValueToEncrypt = value;
            }
        }

        [XmlIgnore]
        protected bool TagValueToEncryptSpecified { get; set; }

    }
}
