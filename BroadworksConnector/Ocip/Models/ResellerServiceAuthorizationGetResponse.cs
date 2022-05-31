using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ResellerServiceAuthorizationGetRequest.
    /// <see cref="ResellerServiceAuthorizationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:828""}]")]
    public class ResellerServiceAuthorizationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _serviceOffering;

        [XmlElement(ElementName = "serviceOffering", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:828")]
        public string ServiceOffering
        {
            get => _serviceOffering;
            set
            {
                ServiceOfferingSpecified = true;
                _serviceOffering = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceOfferingSpecified { get; set; }

    }
}
