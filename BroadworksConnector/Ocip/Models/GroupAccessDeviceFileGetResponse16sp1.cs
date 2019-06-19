using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceFileGetRequest16sp1.
    /// 
    /// Replaced by: GroupAccessDeviceFileGetResponse20
    /// <see cref="GroupAccessDeviceFileGetRequest16sp1"/>
    /// <see cref="GroupAccessDeviceFileGetResponse20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:40913""}]")]
    public class GroupAccessDeviceFileGetResponse16sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode _fileSource;

        [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40913")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode FileSource
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40913")]
        [MinLength(1)]
        [MaxLength(256)]
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

        private string _accessUrl;

        [XmlElement(ElementName = "accessUrl", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40913")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AccessUrl
        {
            get => _accessUrl;
            set
            {
                AccessUrlSpecified = true;
                _accessUrl = value;
            }
        }

        [XmlIgnore]
        public bool AccessUrlSpecified { get; set; }

        private string _repositoryUrl;

        [XmlElement(ElementName = "repositoryUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40913")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RepositoryUrl
        {
            get => _repositoryUrl;
            set
            {
                RepositoryUrlSpecified = true;
                _repositoryUrl = value;
            }
        }

        [XmlIgnore]
        public bool RepositoryUrlSpecified { get; set; }

        private string _templateUrl;

        [XmlElement(ElementName = "templateUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40913")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TemplateUrl
        {
            get => _templateUrl;
            set
            {
                TemplateUrlSpecified = true;
                _templateUrl = value;
            }
        }

        [XmlIgnore]
        public bool TemplateUrlSpecified { get; set; }

    }
}
