using System;
using System.Xml.Serialization;
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
     
    public class ServiceProviderAccessDeviceCustomTagModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        public string DeviceName {
            get => _deviceName;
            set {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        public bool DeviceNameSpecified { get; set; }
        
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
        
        private string _tagValue;

        [XmlElement(ElementName = "tagValue", IsNullable = true, Namespace = "")]
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

        [XmlElement(ElementName = "tagValueToEncrypt", IsNullable = true, Namespace = "")]
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
