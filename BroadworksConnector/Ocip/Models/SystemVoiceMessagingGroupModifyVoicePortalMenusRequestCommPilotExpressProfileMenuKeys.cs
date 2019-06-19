using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:28390""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestCommPilotExpressProfileMenuKeys
    {

        private string _activateAvailableInOfficeProfile;

        [XmlElement(ElementName = "activateAvailableInOfficeProfile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28390")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ActivateAvailableInOfficeProfile
        {
            get => _activateAvailableInOfficeProfile;
            set
            {
                ActivateAvailableInOfficeProfileSpecified = true;
                _activateAvailableInOfficeProfile = value;
            }
        }

        [XmlIgnore]
        public bool ActivateAvailableInOfficeProfileSpecified { get; set; }

        private string _activateAvailableOutOfOfficeProfile;

        [XmlElement(ElementName = "activateAvailableOutOfOfficeProfile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28390")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ActivateAvailableOutOfOfficeProfile
        {
            get => _activateAvailableOutOfOfficeProfile;
            set
            {
                ActivateAvailableOutOfOfficeProfileSpecified = true;
                _activateAvailableOutOfOfficeProfile = value;
            }
        }

        [XmlIgnore]
        public bool ActivateAvailableOutOfOfficeProfileSpecified { get; set; }

        private string _activateBusyProfile;

        [XmlElement(ElementName = "activateBusyProfile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28390")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ActivateBusyProfile
        {
            get => _activateBusyProfile;
            set
            {
                ActivateBusyProfileSpecified = true;
                _activateBusyProfile = value;
            }
        }

        [XmlIgnore]
        public bool ActivateBusyProfileSpecified { get; set; }

        private string _activateUnavailableProfile;

        [XmlElement(ElementName = "activateUnavailableProfile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28390")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ActivateUnavailableProfile
        {
            get => _activateUnavailableProfile;
            set
            {
                ActivateUnavailableProfileSpecified = true;
                _activateUnavailableProfile = value;
            }
        }

        [XmlIgnore]
        public bool ActivateUnavailableProfileSpecified { get; set; }

        private string _noProfile;

        [XmlElement(ElementName = "noProfile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28390")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string NoProfile
        {
            get => _noProfile;
            set
            {
                NoProfileSpecified = true;
                _noProfile = value;
            }
        }

        [XmlIgnore]
        public bool NoProfileSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28390")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ReturnToPreviousMenu
        {
            get => _returnToPreviousMenu;
            set
            {
                ReturnToPreviousMenuSpecified = true;
                _returnToPreviousMenu = value;
            }
        }

        [XmlIgnore]
        public bool ReturnToPreviousMenuSpecified { get; set; }

        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28390")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RepeatMenu
        {
            get => _repeatMenu;
            set
            {
                RepeatMenuSpecified = true;
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        public bool RepeatMenuSpecified { get; set; }

    }
}
