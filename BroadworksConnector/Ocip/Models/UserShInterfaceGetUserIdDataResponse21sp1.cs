using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserShInterfaceGetUserIdDataRequest21sp1.
    /// The response contains the Sh non-transparent data for the specified userId.
    /// The data also includes a userType, publicUserIdentity and endpointType.
    /// The value Mobility in Endpoint Type is only applicable in AS data mode.
    /// <see cref="UserShInterfaceGetUserIdDataRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:4020""}]")]
    public class UserShInterfaceGetUserIdDataResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.ShInterfaceUserIdDataEntry21sp1> _entry = new List<BroadWorksConnector.Ocip.Models.ShInterfaceUserIdDataEntry21sp1>();

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4020")]
        public List<BroadWorksConnector.Ocip.Models.ShInterfaceUserIdDataEntry21sp1> Entry
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
