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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:39774""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestReviewSelectedDistributionListMenuKeys
    {

        protected string _interruptPlaybackAndReturnToPreviousMenu;

        [XmlElement(ElementName = "interruptPlaybackAndReturnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39774")]
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
        protected bool InterruptPlaybackAndReturnToPreviousMenuSpecified { get; set; }

    }
}
