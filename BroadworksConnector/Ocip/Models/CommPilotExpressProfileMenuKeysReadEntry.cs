using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal commPilot express profile menu keys.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:2457""}]")]
    public class CommPilotExpressProfileMenuKeysReadEntry
    {

        protected string _activateAvailableInOfficeProfile;

        [XmlElement(ElementName = "activateAvailableInOfficeProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2457")]
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
        protected bool ActivateAvailableInOfficeProfileSpecified { get; set; }

        protected string _activateAvailableOutOfOfficeProfile;

        [XmlElement(ElementName = "activateAvailableOutOfOfficeProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2457")]
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
        protected bool ActivateAvailableOutOfOfficeProfileSpecified { get; set; }

        protected string _activateBusyProfile;

        [XmlElement(ElementName = "activateBusyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2457")]
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
        protected bool ActivateBusyProfileSpecified { get; set; }

        protected string _activateUnavailableProfile;

        [XmlElement(ElementName = "activateUnavailableProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2457")]
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
        protected bool ActivateUnavailableProfileSpecified { get; set; }

        protected string _noProfile;

        [XmlElement(ElementName = "noProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2457")]
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
        protected bool NoProfileSpecified { get; set; }

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2457")]
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
        protected bool ReturnToPreviousMenuSpecified { get; set; }

        protected string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2457")]
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
        protected bool RepeatMenuSpecified { get; set; }

    }
}
