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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1388""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeCallForwardingDestinationMenuKeys
    {

        protected string _finishEnteringNewDestinationNumber;

        [XmlElement(ElementName = "finishEnteringNewDestinationNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1388")]
        [Length(1)]
        [RegularExpression(@"\*|#")]
        public string FinishEnteringNewDestinationNumber
        {
            get => _finishEnteringNewDestinationNumber;
            set
            {
                FinishEnteringNewDestinationNumberSpecified = true;
                _finishEnteringNewDestinationNumber = value;
            }
        }

        [XmlIgnore]
        protected bool FinishEnteringNewDestinationNumberSpecified { get; set; }

    }
}
