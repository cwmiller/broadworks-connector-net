using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Maps a BroadWorks language to a device-equivalent language.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class DeviceManagementLanguageMapping 
    {

        
        private string _broadWorksLanguage;

        [XmlElement(ElementName = "broadWorksLanguage", IsNullable = false, Namespace = "")]
        public string BroadWorksLanguage {
            get => _broadWorksLanguage;
            set {
                BroadWorksLanguageSpecified = true;
                _broadWorksLanguage = value;
            }
        }

        [XmlIgnore]
        public bool BroadWorksLanguageSpecified { get; set; }
        
        private string _deviceLanguage;

        [XmlElement(ElementName = "deviceLanguage", IsNullable = true, Namespace = "")]
        public string DeviceLanguage {
            get => _deviceLanguage;
            set {
                DeviceLanguageSpecified = true;
                _deviceLanguage = value;
            }
        }

        [XmlIgnore]
        public bool DeviceLanguageSpecified { get; set; }
        
    }
}
