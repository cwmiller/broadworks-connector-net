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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:38348""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoicePortalCallingMenuKeys
    {

        protected string _endCurrentCallAndGoBackToPreviousMenu;

        [XmlElement(ElementName = "endCurrentCallAndGoBackToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:38348")]
        [MinLength(1)]
        [MaxLength(3)]
        [RegularExpression(@"([0-9]|\*|#){0,3}")]
        public string EndCurrentCallAndGoBackToPreviousMenu
        {
            get => _endCurrentCallAndGoBackToPreviousMenu;
            set
            {
                EndCurrentCallAndGoBackToPreviousMenuSpecified = true;
                _endCurrentCallAndGoBackToPreviousMenu = value;
            }
        }

        [XmlIgnore]
        protected bool EndCurrentCallAndGoBackToPreviousMenuSpecified { get; set; }

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:38348")]
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

    }
}
