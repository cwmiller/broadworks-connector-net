using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceFileGetRequest.
    /// Replaced By: GroupAccessDeviceFileGetResponse14sp8
    /// <see cref="GroupAccessDeviceFileGetRequest"/>
    /// <see cref="GroupAccessDeviceFileGetResponse14sp8"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:582""}]")]
    public class GroupAccessDeviceFileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode _fileSource;

        [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:582")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:582")]
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

    }
}
