using System;
using System.Xml.Serialization;
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
     
    public class ServiceProviderMWIDeliveryToMobileEndpointGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _templateActivationTable;

        [XmlElement(ElementName = "templateActivationTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TemplateActivationTable {
            get => _templateActivationTable;
            set {
                TemplateActivationTableSpecified = true;
                _templateActivationTable = value;
            }
        }

        [XmlIgnore]
        public bool TemplateActivationTableSpecified { get; set; }
        
    }
}
