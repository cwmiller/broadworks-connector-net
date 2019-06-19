using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderDialableCallerIDGetRequest.
    /// The criteria table?s column headings are ?Active?, "Name", "Description", ?Prefix Digits?, and ?Priority?.
    /// <see cref="ServiceProviderDialableCallerIDGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2854""}]")]
    public class ServiceProviderDialableCallerIDGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useServiceProviderCriteria;

        [XmlElement(ElementName = "useServiceProviderCriteria", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2854")]
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
        public bool UseServiceProviderCriteriaSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.NsScreeningFailurePolicy _nsScreeningFailurePolicy;

        [XmlElement(ElementName = "nsScreeningFailurePolicy", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2854")]
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
        public bool NsScreeningFailurePolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2854")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CriteriaTable
        {
            get => _criteriaTable;
            set
            {
                CriteriaTableSpecified = true;
                _criteriaTable = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaTableSpecified { get; set; }

    }
}
