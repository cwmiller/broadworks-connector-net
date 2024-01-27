using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest.
    /// Contains a table of Service Providers that have the Network Class of Service
    /// assigned. The column headings are: "Service Provider Id" and "Service Provider Name".
    /// <see cref="ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:767""}]")]
    public class ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _spTable;

        [XmlElement(ElementName = "spTable", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:767")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SpTable
        {
            get => _spTable;
            set
            {
                SpTableSpecified = true;
                _spTable = value;
            }
        }

        [XmlIgnore]
        protected bool SpTableSpecified { get; set; }

    }
}
