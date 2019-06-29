using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserBroadWorksAnywhereGetAvailablePortalListRequest.
    /// Contains a table with column headings: "Portal ID", "Phone Number", "Extension", "Language".
    /// Replaced by UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1
    /// <see cref="UserBroadWorksAnywhereGetAvailablePortalListRequest"/>
    /// <see cref="UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:6974""}]")]
    public class UserBroadWorksAnywhereGetAvailablePortalListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _portalTable;

        [XmlElement(ElementName = "portalTable", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:6974")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PortalTable
        {
            get => _portalTable;
            set
            {
                PortalTableSpecified = true;
                _portalTable = value;
            }
        }

        [XmlIgnore]
        protected bool PortalTableSpecified { get; set; }

    }
}
