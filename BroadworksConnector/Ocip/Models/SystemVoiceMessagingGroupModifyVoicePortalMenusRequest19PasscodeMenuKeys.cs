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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1417""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PasscodeMenuKeys
    {

        private string _finishEnteringOrReenteringPasscode;

        [XmlElement(ElementName = "finishEnteringOrReenteringPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1417")]
        [Length(1)]
        [RegularExpression(@"\*|#")]
        public string FinishEnteringOrReenteringPasscode
        {
            get => _finishEnteringOrReenteringPasscode;
            set
            {
                FinishEnteringOrReenteringPasscodeSpecified = true;
                _finishEnteringOrReenteringPasscode = value;
            }
        }

        [XmlIgnore]
        public bool FinishEnteringOrReenteringPasscodeSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1417")]
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

    }
}
