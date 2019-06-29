using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal calling menu keys modify entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:3332""}]")]
    public class VoicePortalCallingMenuKeysModifyEntry
    {

        private string _endCurrentCallAndGoBackToPreviousMenu;

        [XmlElement(ElementName = "endCurrentCallAndGoBackToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3332")]
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

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3332")]
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
