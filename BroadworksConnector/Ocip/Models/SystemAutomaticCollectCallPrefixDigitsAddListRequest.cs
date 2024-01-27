using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a system automatic collect call prefix digits entry.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d5db1a19a0aeda6f13d1f1c609efa0a:96""}]")]
    public class SystemAutomaticCollectCallPrefixDigitsAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected List<BroadWorksConnector.Ocip.Models.AutomaticCollectCallPrefixDigitsEntry> _prefixDigitsEntry = new List<BroadWorksConnector.Ocip.Models.AutomaticCollectCallPrefixDigitsEntry>();

        [XmlElement(ElementName = "prefixDigitsEntry", IsNullable = false, Namespace = "")]
        [Group(@"0d5db1a19a0aeda6f13d1f1c609efa0a:96")]
        public List<BroadWorksConnector.Ocip.Models.AutomaticCollectCallPrefixDigitsEntry> PrefixDigitsEntry
        {
            get => _prefixDigitsEntry;
            set
            {
                PrefixDigitsEntrySpecified = true;
                _prefixDigitsEntry = value;
            }
        }

        [XmlIgnore]
        protected bool PrefixDigitsEntrySpecified { get; set; }

    }
}
