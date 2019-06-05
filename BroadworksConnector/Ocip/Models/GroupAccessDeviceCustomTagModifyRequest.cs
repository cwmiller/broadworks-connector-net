using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAccessDeviceCustomTagModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
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
        public bool ServiceProviderIdSpecified { get; set; }
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
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
        public bool DeviceNameSpecified { get; set; }
        private string _tagName;

        [XmlElement(ElementName = "tagName", IsNullable = false, Namespace = "")]
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
        public bool TagNameSpecified { get; set; }
        private string _tagValue;

        [XmlElement(ElementName = "tagValue", IsNullable = true, Namespace = "")]
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
        public bool TagValueSpecified { get; set; }
        private string _tagValueToEncrypt;

        [XmlElement(ElementName = "tagValueToEncrypt", IsNullable = true, Namespace = "")]
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
        public bool TagValueToEncryptSpecified { get; set; }
    }
}
