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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:38077""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SelectDistributionListMenuKeys
    {

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:38077")]
        [Length(1)]
        [RegularExpression(@"\*|#")]
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

        protected string _repeatMenuOrFinishEnteringDistributionListNumber;

        [XmlElement(ElementName = "repeatMenuOrFinishEnteringDistributionListNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:38077")]
        [Length(1)]
        [RegularExpression(@"\*|#")]
        public string RepeatMenuOrFinishEnteringDistributionListNumber
        {
            get => _repeatMenuOrFinishEnteringDistributionListNumber;
            set
            {
                RepeatMenuOrFinishEnteringDistributionListNumberSpecified = true;
                _repeatMenuOrFinishEnteringDistributionListNumber = value;
            }
        }

        [XmlIgnore]
        protected bool RepeatMenuOrFinishEnteringDistributionListNumberSpecified { get; set; }

    }
}
