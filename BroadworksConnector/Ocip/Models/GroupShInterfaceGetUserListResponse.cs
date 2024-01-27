using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupShInterfaceGetUserListRequest.
    /// The response contains the Sh Non Transparent data and associated Public User Identity
    /// information for every Public User Identity in the group.
    /// 
    /// Replaced by: GroupShInterfaceGetUserListResponse21sp1 in AS data mode.
    /// <see cref="GroupShInterfaceGetUserListRequest"/>
    /// <see cref="GroupShInterfaceGetUserListResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:4534""}]")]
    public class GroupShInterfaceGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.ShInterfaceUserListEntry> _entry = new List<BroadWorksConnector.Ocip.Models.ShInterfaceUserListEntry>();

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4534")]
        public List<BroadWorksConnector.Ocip.Models.ShInterfaceUserListEntry> Entry
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
