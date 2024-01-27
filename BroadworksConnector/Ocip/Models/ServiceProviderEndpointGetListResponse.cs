using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderEndpointGetListRequest.
    /// The column headings for the endpointTable are:
    /// "Group Id", "Line/Port", "Last Name", "First Name",  "User Id", "User Type", "Phone Number", "Extension", "Device Type", "Device Name", "Net Address", "MAC Address", "Department", "Email Address".
    /// Possible values for User Type are "User", "CCBasic", "CCStandard", "CCPremium", "RP", "MOH", "MOHVideo".
    /// <see cref="ServiceProviderEndpointGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4204""}]")]
    public class ServiceProviderEndpointGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _endpointTable;

        [XmlElement(ElementName = "endpointTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4204")]
        public BroadWorksConnector.Ocip.Models.C.OCITable EndpointTable
        {
            get => _endpointTable;
            set
            {
                EndpointTableSpecified = true;
                _endpointTable = value;
            }
        }

        [XmlIgnore]
        protected bool EndpointTableSpecified { get; set; }

    }
}
