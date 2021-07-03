using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDeviceTypeFileGetRequest16sp1.
    /// <see cref="GroupDeviceTypeFileGetRequest16sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4401""}]")]
    public class GroupDeviceTypeFileGetResponse16sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode _fileSource;

        [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4401")]
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
        protected bool FileSourceSpecified { get; set; }

        private string _configurationFileName;

        [XmlElement(ElementName = "configurationFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4401")]
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
        protected bool ConfigurationFileNameSpecified { get; set; }

        private string _accessUrl;

        [XmlElement(ElementName = "accessUrl", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4401")]
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
        protected bool AccessUrlSpecified { get; set; }

        private string _repositoryUrl;

        [XmlElement(ElementName = "repositoryUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4401")]
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
        protected bool RepositoryUrlSpecified { get; set; }

        private string _templateUrl;

        [XmlElement(ElementName = "templateUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4401")]
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
        protected bool TemplateUrlSpecified { get; set; }

    }
}
