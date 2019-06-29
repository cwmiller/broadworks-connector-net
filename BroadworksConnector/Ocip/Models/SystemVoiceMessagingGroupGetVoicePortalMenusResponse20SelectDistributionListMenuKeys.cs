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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35524""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20SelectDistributionListMenuKeys
    {

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35524")]
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

        private string _repeatMenuOrFinishEnteringDistributionListNumber;

        [XmlElement(ElementName = "repeatMenuOrFinishEnteringDistributionListNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35524")]
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
