using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the service provider?s Dialable Caller ID settings and criteria list.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:3521""}]")]
    public class ServiceProviderDialableCallerIDModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3521")]
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

        private bool _useServiceProviderCriteria;

        [XmlElement(ElementName = "useServiceProviderCriteria", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3521")]
        public bool UseServiceProviderCriteria
        {
            get => _useServiceProviderCriteria;
            set
            {
                UseServiceProviderCriteriaSpecified = true;
                _useServiceProviderCriteria = value;
            }
        }

        [XmlIgnore]
        protected bool UseServiceProviderCriteriaSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.NsScreeningFailurePolicy _nsScreeningFailurePolicy;

        [XmlElement(ElementName = "nsScreeningFailurePolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3521")]
        public BroadWorksConnector.Ocip.Models.NsScreeningFailurePolicy NsScreeningFailurePolicy
        {
            get => _nsScreeningFailurePolicy;
            set
            {
                NsScreeningFailurePolicySpecified = true;
                _nsScreeningFailurePolicy = value;
            }
        }

        [XmlIgnore]
        protected bool NsScreeningFailurePolicySpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder> _criteriaPriorityOrder = new List<BroadWorksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder>();

        [XmlElement(ElementName = "criteriaPriorityOrder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3521")]
        public List<BroadWorksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder> CriteriaPriorityOrder
        {
            get => _criteriaPriorityOrder;
            set
            {
                CriteriaPriorityOrderSpecified = true;
                _criteriaPriorityOrder = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaPriorityOrderSpecified { get; set; }

    }
}
