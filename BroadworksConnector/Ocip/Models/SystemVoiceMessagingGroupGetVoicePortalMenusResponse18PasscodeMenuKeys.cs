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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:36832""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18PasscodeMenuKeys
    {

        private string _finishEnteringOrReenteringPasscode;

        [XmlElement(ElementName = "finishEnteringOrReenteringPasscode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:36832")]
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

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:36832")]
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
