using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupBroadWorksAnywhereGetInstanceListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Phone Number", "Extension", "Department", "Is Active".
    /// The column value for "Is Active" can either be true, or false.
    /// <see cref="GroupBroadWorksAnywhereGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f39163d0e42e05c4a1692a62f625df9f:125""}]")]
    public class GroupBroadWorksAnywhereGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _broadWorksAnywhereTable;

        [XmlElement(ElementName = "broadWorksAnywhereTable", IsNullable = false, Namespace = "")]
        [Group(@"f39163d0e42e05c4a1692a62f625df9f:125")]
        public BroadWorksConnector.Ocip.Models.C.OCITable BroadWorksAnywhereTable
        {
            get => _broadWorksAnywhereTable;
            set
            {
                BroadWorksAnywhereTableSpecified = true;
                _broadWorksAnywhereTable = value;
            }
        }

        [XmlIgnore]
        protected bool BroadWorksAnywhereTableSpecified { get; set; }

    }
}
