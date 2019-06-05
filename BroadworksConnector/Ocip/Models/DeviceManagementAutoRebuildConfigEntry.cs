using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class DeviceManagementAutoRebuildConfigEntry
    {
        private string _ociRequestPrefix;

        [XmlElement(ElementName = "ociRequestPrefix", IsNullable = false, Namespace = "")]
        public string OciRequestPrefix
        {
            get => _ociRequestPrefix;
            set
            {
                OciRequestPrefixSpecified = true;
                _ociRequestPrefix = value;
            }
        }

        [XmlIgnore]
        public bool OciRequestPrefixSpecified { get; set; }
        private bool _autoRebuildEnabled;

        [XmlElement(ElementName = "autoRebuildEnabled", IsNullable = false, Namespace = "")]
        public bool AutoRebuildEnabled
        {
            get => _autoRebuildEnabled;
            set
            {
                AutoRebuildEnabledSpecified = true;
                _autoRebuildEnabled = value;
            }
        }

        [XmlIgnore]
        public bool AutoRebuildEnabledSpecified { get; set; }
    }
}
