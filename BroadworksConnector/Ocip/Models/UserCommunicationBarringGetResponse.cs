using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCommunicationBarringGetRequest.
    /// This command only applies to users in an Enterprise.
        /// <see cref="UserCommunicationBarringGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCommunicationBarringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _useGroupSetting;

        [XmlElement(ElementName = "useGroupSetting", IsNullable = false, Namespace = "")]
        public bool UseGroupSetting {
            get => _useGroupSetting;
            set {
                UseGroupSettingSpecified = true;
                _useGroupSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseGroupSettingSpecified { get; set; }
        
        private string _profileName;

        [XmlElement(ElementName = "profileName", IsNullable = false, Namespace = "")]
        public string ProfileName {
            get => _profileName;
            set {
                ProfileNameSpecified = true;
                _profileName = value;
            }
        }

        [XmlIgnore]
        public bool ProfileNameSpecified { get; set; }
        
    }
}
