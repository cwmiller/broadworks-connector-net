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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:38290""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20GreetingsMenuKeys
    {

        private string _personalizedName;

        [XmlElement(ElementName = "personalizedName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38290")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PersonalizedName
        {
            get => _personalizedName;
            set
            {
                PersonalizedNameSpecified = true;
                _personalizedName = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalizedNameSpecified { get; set; }

        private string _conferenceGreeting;

        [XmlElement(ElementName = "conferenceGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38290")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ConferenceGreeting
        {
            get => _conferenceGreeting;
            set
            {
                ConferenceGreetingSpecified = true;
                _conferenceGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceGreetingSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38290")]
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

        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38290")]
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
