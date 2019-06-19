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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1620""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19GreetingOnlyForwardingDestinationMenuKeys
    {

        private string _greetingOnlyForwardingDestination;

        [XmlElement(ElementName = "greetingOnlyForwardingDestination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1620")]
        [Length(1)]
        [RegularExpression(@"\*|#")]
        public string GreetingOnlyForwardingDestination
        {
            get => _greetingOnlyForwardingDestination;
            set
            {
                GreetingOnlyForwardingDestinationSpecified = true;
                _greetingOnlyForwardingDestination = value;
            }
        }

        [XmlIgnore]
        public bool GreetingOnlyForwardingDestinationSpecified { get; set; }

    }
}
