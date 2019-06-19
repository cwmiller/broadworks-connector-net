using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1170""}]")]
    public class UserCommunicationBarringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useGroupSetting;

        [XmlElement(ElementName = "useGroupSetting", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1170")]
        public bool UseGroupSetting
        {
            get => _useGroupSetting;
            set
            {
                UseGroupSettingSpecified = true;
                _useGroupSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseGroupSettingSpecified { get; set; }

        private string _profileName;

        [XmlElement(ElementName = "profileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1170")]
        [MinLength(1)]
        [MaxLength(40)]
        public string ProfileName
        {
            get => _profileName;
            set
            {
                ProfileNameSpecified = true;
                _profileName = value;
            }
        }

        [XmlIgnore]
        public bool ProfileNameSpecified { get; set; }

    }
}
