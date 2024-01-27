using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderRoutePointExternalSystemGetAssignedListRequest.
    /// Contains a table of all Route Point External Systems assigned to the
    /// service provider.  The column headings are: "Name" and "Description".
    /// <see cref="ServiceProviderRoutePointExternalSystemGetAssignedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:5630""}]")]
    public class ServiceProviderRoutePointExternalSystemGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _externalSystemTable;

        [XmlElement(ElementName = "externalSystemTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5630")]
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
