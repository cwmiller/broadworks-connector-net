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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:900""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PasscodeMenuKeys
    {

        protected string _finishEnteringOrReenteringPasscode;

        [XmlElement(ElementName = "finishEnteringOrReenteringPasscode", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:900")]
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
        protected bool FinishEnteringOrReenteringPasscodeSpecified { get; set; }

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:900")]
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

    }
}
