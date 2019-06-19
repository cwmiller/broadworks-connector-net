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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:999""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SelectDistributionListMenuKeys
    {

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:999")]
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
        public bool ReturnToPreviousMenuSpecified { get; set; }

        private string _repeatMenuOrFinishEnteringDistributionListNumber;

        [XmlElement(ElementName = "repeatMenuOrFinishEnteringDistributionListNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:999")]
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
        public bool RepeatMenuOrFinishEnteringDistributionListNumberSpecified { get; set; }

    }
}
