using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Communication Barring settings for a user. If useDefaultServiceProviderProfile is set to false, a profile name must be present.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// This command only applies to groups in an Enterprise. This command will fail for groups in a Service Provider.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCommunicationBarringModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
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

        [XmlElement(ElementName = "profileName", IsNullable = true, Namespace = "")]
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
