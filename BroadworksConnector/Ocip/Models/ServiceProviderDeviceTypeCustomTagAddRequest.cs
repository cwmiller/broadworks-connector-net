using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a static configuration tag for an access device type used in a service provider.
    /// 
    /// The following elements are only used in XS data mode:
    /// isTagValueEncrypted, use value "false" in AS data mode
    /// 
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// tagValueToEncrypt
    /// 
    /// The tagValueToEncrypt element can only be used by a system administrator.
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderDeviceTypeCustomTagAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        public string DeviceType {
            get => _deviceType;
            set {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeSpecified { get; set; }
        
        private string _tagName;

        [XmlElement(ElementName = "tagName", IsNullable = false, Namespace = "")]
        public string TagName {
            get => _tagName;
            set {
                TagNameSpecified = true;
                _tagName = value;
            }
        }

        [XmlIgnore]
        public bool TagNameSpecified { get; set; }
        
        private bool _isTagValueEncrypted;

        [XmlElement(ElementName = "isTagValueEncrypted", IsNullable = false, Namespace = "")]
        public bool IsTagValueEncrypted {
            get => _isTagValueEncrypted;
            set {
                IsTagValueEncryptedSpecified = true;
                _isTagValueEncrypted = value;
            }
        }

        [XmlIgnore]
        public bool IsTagValueEncryptedSpecified { get; set; }
        
        private string _tagValue;

        [XmlElement(ElementName = "tagValue", IsNullable = false, Namespace = "")]
        public string TagValue {
            get => _tagValue;
            set {
                TagValueSpecified = true;
                _tagValue = value;
            }
        }

        [XmlIgnore]
        public bool TagValueSpecified { get; set; }
        
        private string _tagValueToEncrypt;

        [XmlElement(ElementName = "tagValueToEncrypt", IsNullable = false, Namespace = "")]
        public string TagValueToEncrypt {
            get => _tagValueToEncrypt;
            set {
                TagValueToEncryptSpecified = true;
                _tagValueToEncrypt = value;
            }
        }

        [XmlIgnore]
        public bool TagValueToEncryptSpecified { get; set; }
        
    }
}
