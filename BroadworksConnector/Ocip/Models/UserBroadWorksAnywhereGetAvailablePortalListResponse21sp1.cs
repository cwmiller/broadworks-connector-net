using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1.
    /// Contains a table with column headings: "Portal ID", "Portal Name", "Phone Number", "Extension", "Language".
    /// <see cref="UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:364""}]")]
    public class UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _portalTable;

        [XmlElement(ElementName = "portalTable", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:364")]
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
