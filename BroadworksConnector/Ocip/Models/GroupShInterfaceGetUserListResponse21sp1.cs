using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupShInterfaceGetUserListRequest21sp1.
    /// The response contains the Sh Non Transparent data and associated Public User Identity
    /// information for every Public User Identity in the group.
    /// <see cref="GroupShInterfaceGetUserListRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:8284""}]")]
    public class GroupShInterfaceGetUserListResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.ShInterfaceUserListEntry21sp1> _entry = new List<BroadWorksConnector.Ocip.Models.ShInterfaceUserListEntry21sp1>();

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8284")]
        public List<BroadWorksConnector.Ocip.Models.ShInterfaceUserListEntry21sp1> Entry
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
