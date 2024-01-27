using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Maps a BroadWorks language to a device-equivalent language.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:2839""}]")]
    public class DeviceManagementLanguageMapping
    {

        protected string _broadWorksLanguage;

        [XmlElement(ElementName = "broadWorksLanguage", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2839")]
        [MinLength(1)]
        [MaxLength(40)]
        public string BroadWorksLanguage
        {
            get => _broadWorksLanguage;
            set
            {
                BroadWorksLanguageSpecified = true;
                _broadWorksLanguage = value;
            }
        }

        [XmlIgnore]
        protected bool BroadWorksLanguageSpecified { get; set; }

        protected string _deviceLanguage;

        [XmlElement(ElementName = "deviceLanguage", IsNullable = true, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2839")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceLanguage
        {
            get => _deviceLanguage;
            set
            {
                DeviceLanguageSpecified = true;
                _deviceLanguage = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceLanguageSpecified { get; set; }

    }
}
