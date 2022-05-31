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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5563""}]")]
    public class ServiceProviderRoutePointExternalSystemGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _externalSystemTable;

        [XmlElement(ElementName = "externalSystemTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5563")]
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
