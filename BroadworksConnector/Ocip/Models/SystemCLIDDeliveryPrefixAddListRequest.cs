using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add one or more prefixes to the list of prefixes to be matched.
    /// Matched prefixes will result in CLID delivery for Korea.
    /// Prefix 00X must be sent using uppercase X.
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:4961""}]")]
    public class SystemCLIDDeliveryPrefixAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private List<BroadWorksConnector.Ocip.Models.CLIDDeliveryPrefix> _prefix = new List<BroadWorksConnector.Ocip.Models.CLIDDeliveryPrefix>();

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4961")]
        public List<BroadWorksConnector.Ocip.Models.CLIDDeliveryPrefix> Prefix
        {
            get => _prefix;
            set
            {
                PrefixSpecified = true;
                _prefix = value;
            }
        }

        [XmlIgnore]
        public bool PrefixSpecified { get; set; }

    }
}
