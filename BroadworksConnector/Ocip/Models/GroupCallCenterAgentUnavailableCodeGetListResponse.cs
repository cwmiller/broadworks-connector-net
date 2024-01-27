using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterAgentUnavailableCodeGetListRequest.
    /// Contains a table with column headings: "Is Active", "Code", "Description".
    /// <see cref="GroupCallCenterAgentUnavailableCodeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:2581""}]")]
    public class GroupCallCenterAgentUnavailableCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _unavailableCodesTable;

        [XmlElement(ElementName = "unavailableCodesTable", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2581")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UnavailableCodesTable
        {
            get => _unavailableCodesTable;
            set
            {
                UnavailableCodesTableSpecified = true;
                _unavailableCodesTable = value;
            }
        }

        [XmlIgnore]
        protected bool UnavailableCodesTableSpecified { get; set; }

    }
}
