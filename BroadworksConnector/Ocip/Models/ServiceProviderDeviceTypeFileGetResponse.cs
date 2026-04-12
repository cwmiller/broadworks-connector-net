using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDeviceTypeFileGetRequest.
    /// <see cref="ServiceProviderDeviceTypeFileGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:3354""}]")]
    public class ServiceProviderDeviceTypeFileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode? _fileSource;

        [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3354")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode? FileSource
        {
            get => _fileSource;
            set
            {
                FileSourceSpecified = (value != null);
                _fileSource = value;
            }
        }

        [XmlIgnore]
        protected bool FileSourceSpecified { get; set; }

        protected string _configurationFileName;

        [XmlElement(ElementName = "configurationFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3354")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ConfigurationFileName
        {
            get => _configurationFileName;
            set
            {
                ConfigurationFileNameSpecified = (value != null);
                _configurationFileName = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigurationFileNameSpecified { get; set; }

        protected string _accessUrl;

        [XmlElement(ElementName = "accessUrl", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3354")]
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

        protected string _repositoryUrl;

        [XmlElement(ElementName = "repositoryUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3354")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RepositoryUrl
        {
            get => _repositoryUrl;
            set
            {
                RepositoryUrlSpecified = (value != null);
                _repositoryUrl = value;
            }
        }

        [XmlIgnore]
        protected bool RepositoryUrlSpecified { get; set; }

        protected string _templateUrl;

        [XmlElement(ElementName = "templateUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3354")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TemplateUrl
        {
            get => _templateUrl;
            set
            {
                TemplateUrlSpecified = (value != null);
                _templateUrl = value;
            }
        }

        [XmlIgnore]
        protected bool TemplateUrlSpecified { get; set; }

    }
}
