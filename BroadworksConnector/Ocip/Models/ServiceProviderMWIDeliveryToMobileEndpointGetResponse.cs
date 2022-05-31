using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderMWIDeliveryToMobileEndpointGetRequest.
    /// 
    /// The templateActivationTable contains the list of templates defined for the service provider.
    /// The column headings are "Enable", "Language", "Type".
    /// <see cref="ServiceProviderMWIDeliveryToMobileEndpointGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""958b78cc2a785d78259c1e8a474eb40d:319""}]")]
    public class ServiceProviderMWIDeliveryToMobileEndpointGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _templateActivationTable;

        [XmlElement(ElementName = "templateActivationTable", IsNullable = false, Namespace = "")]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:319")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TemplateActivationTable
        {
            get => _templateActivationTable;
            set
            {
                TemplateActivationTableSpecified = true;
                _templateActivationTable = value;
            }
        }

        [XmlIgnore]
        protected bool TemplateActivationTableSpecified { get; set; }

    }
}
