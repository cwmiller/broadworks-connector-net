using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupDnGetSummaryListRequest.
    /// The response contains a table with columns: "Phone Numbers", "Assigned".
    /// The "Phone Numbers" column contains either a single DN or a range of DNs.
    /// The "Assigned" column contains a boolean flag indicating if the DN(s) are
    /// currently assigned to a user or service instance.
    /// The "Activated" column indicates if the DN or DN range has been activated.
    /// Only has a value if the DN(s) is assigned to a user or if "Group Enable Activation
    /// Mode" is enabled.
    /// <see cref="GroupDnGetSummaryListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4470""}]")]
    public class GroupDnGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _dnTable;

        [XmlElement(ElementName = "dnTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4470")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnTable
        {
            get => _dnTable;
            set
            {
                DnTableSpecified = true;
                _dnTable = value;
            }
        }

        [XmlIgnore]
        public bool DnTableSpecified { get; set; }

    }
}
