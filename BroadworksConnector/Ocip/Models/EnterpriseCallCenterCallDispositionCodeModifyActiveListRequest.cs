using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to set the active status of Call Center Call Disposition Codes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1062""}]")]
    public class EnterpriseCallCenterCallDispositionCodeModifyActiveListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1062")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CallDispositionCodeActivation> _callDispositionCodeActivation = new List<BroadWorksConnector.Ocip.Models.CallDispositionCodeActivation>();

        [XmlElement(ElementName = "callDispositionCodeActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1062")]
        public List<BroadWorksConnector.Ocip.Models.CallDispositionCodeActivation> CallDispositionCodeActivation
        {
            get => _callDispositionCodeActivation;
            set
            {
                CallDispositionCodeActivationSpecified = true;
                _callDispositionCodeActivation = value;
            }
        }

        [XmlIgnore]
        protected bool CallDispositionCodeActivationSpecified { get; set; }

    }
}
