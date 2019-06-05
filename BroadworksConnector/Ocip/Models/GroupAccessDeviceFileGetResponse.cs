using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAccessDeviceFileGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode _fileSource;

        [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode FileSource
        {
            get => _fileSource;
            set
            {
                FileSourceSpecified = true;
                _fileSource = value;
            }
        }

        [XmlIgnore]
        public bool FileSourceSpecified { get; set; }
        private string _configurationFileName;

        [XmlElement(ElementName = "configurationFileName", IsNullable = false, Namespace = "")]
        public string ConfigurationFileName
        {
            get => _configurationFileName;
            set
            {
                ConfigurationFileNameSpecified = true;
                _configurationFileName = value;
            }
        }

        [XmlIgnore]
        public bool ConfigurationFileNameSpecified { get; set; }
    }
}
