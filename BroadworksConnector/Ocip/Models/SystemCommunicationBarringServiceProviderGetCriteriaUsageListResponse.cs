using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCommunicationBarringServiceProviderGetCriteriaUsageListRequest.
    /// The response contains a table of all Service Providers that use the specific Communication Barring criteria. The column headings are "Service Provider Id", "Service Provider Name" and "Is Enterprise"
    /// <see cref="SystemCommunicationBarringServiceProviderGetCriteriaUsageListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6549""}]")]
    public class SystemCommunicationBarringServiceProviderGetCriteriaUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderTable;

        [XmlElement(ElementName = "serviceProviderTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6549")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderTable
        {
            get => _serviceProviderTable;
            set
            {
                ServiceProviderTableSpecified = true;
                _serviceProviderTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderTableSpecified { get; set; }

    }
}
