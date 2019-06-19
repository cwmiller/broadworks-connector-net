using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCLIDDeliveryPrefixGetListRequest.
    /// <see cref="SystemCLIDDeliveryPrefixGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5008""}]")]
    public class SystemCLIDDeliveryPrefixGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.CLIDDeliveryPrefix> _prefix = new List<BroadWorksConnector.Ocip.Models.CLIDDeliveryPrefix>();

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5008")]
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
