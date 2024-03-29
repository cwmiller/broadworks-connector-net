using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseCommonPhoneListGetListRequest.
    /// The response contains the enterprise's common phone list.
    /// <see cref="EnterpriseCommonPhoneListGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:136""}]")]
    public class EnterpriseCommonPhoneListGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.PhoneListEntry> _entry = new List<BroadWorksConnector.Ocip.Models.PhoneListEntry>();

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:136")]
        public List<BroadWorksConnector.Ocip.Models.PhoneListEntry> Entry
        {
            get => _entry;
            set
            {
                EntrySpecified = true;
                _entry = value;
            }
        }

        [XmlIgnore]
        protected bool EntrySpecified { get; set; }

    }
}
