using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointExternalSystemGetAssignedListRequest.
    /// Contains a table of all Route Point External Systems assigned to the
    /// group.  The column headings are: "Name" and "Description".
    /// <see cref="GroupRoutePointExternalSystemGetAssignedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:7198""}]")]
    public class GroupRoutePointExternalSystemGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _externalSystemTable;

        [XmlElement(ElementName = "externalSystemTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7198")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ExternalSystemTable
        {
            get => _externalSystemTable;
            set
            {
                ExternalSystemTableSpecified = true;
                _externalSystemTable = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalSystemTableSpecified { get; set; }

    }
}
