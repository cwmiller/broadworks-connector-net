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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2372""}]")]
    public class DeviceManagementLanguageMapping
    {

        protected string _broadWorksLanguage;

        [XmlElement(ElementName = "broadWorksLanguage", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2372")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2372")]
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
