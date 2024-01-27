using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserShInterfaceGetUserIdDataRequest.
    /// The response contains the Sh non-transparent data for the specified userId.
    /// The data also includes a userType, publicUserIdentity and endpointType.
    /// 
    /// Replaced by: UserShInterfaceGetUserIdDataResponse21sp1 in AS data mode.
    /// <see cref="UserShInterfaceGetUserIdDataRequest"/>
    /// <see cref="UserShInterfaceGetUserIdDataResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:18893""}]")]
    public class UserShInterfaceGetUserIdDataResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.ShInterfaceUserIdDataEntry> _entry = new List<BroadWorksConnector.Ocip.Models.ShInterfaceUserIdDataEntry>();

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18893")]
        public List<BroadWorksConnector.Ocip.Models.ShInterfaceUserIdDataEntry> Entry
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
