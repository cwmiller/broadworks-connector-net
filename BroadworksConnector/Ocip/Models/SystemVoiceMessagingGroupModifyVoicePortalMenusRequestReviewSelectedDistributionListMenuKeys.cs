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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:28594""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestReviewSelectedDistributionListMenuKeys
    {

        private string _interruptPlaybackAndReturnToPreviousMenu;

        [XmlElement(ElementName = "interruptPlaybackAndReturnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28594")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string InterruptPlaybackAndReturnToPreviousMenu
        {
            get => _interruptPlaybackAndReturnToPreviousMenu;
            set
            {
                InterruptPlaybackAndReturnToPreviousMenuSpecified = true;
                _interruptPlaybackAndReturnToPreviousMenu = value;
            }
        }

        [XmlIgnore]
        public bool InterruptPlaybackAndReturnToPreviousMenuSpecified { get; set; }

    }
}
