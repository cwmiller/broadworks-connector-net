using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the filtering setting for an executive user.
    /// Both executive and the executive assistant can run this command.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9a6dbade05624033cf7fe782b7c9a9a7:373""}]")]
    public class UserExecutiveModifyFilteringRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:373")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected bool _enableFiltering;

        [XmlElement(ElementName = "enableFiltering", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:373")]
        public bool EnableFiltering
        {
            get => _enableFiltering;
            set
            {
                EnableFilteringSpecified = true;
                _enableFiltering = value;
            }
        }

        [XmlIgnore]
        protected bool EnableFilteringSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringMode _filteringMode;

        [XmlElement(ElementName = "filteringMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:373")]
        public BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringMode FilteringMode
        {
            get => _filteringMode;
            set
            {
                FilteringModeSpecified = true;
                _filteringMode = value;
            }
        }

        [XmlIgnore]
        protected bool FilteringModeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringSimpleFilterType _simpleFilterType;

        [XmlElement(ElementName = "simpleFilterType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:373")]
        public BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringSimpleFilterType SimpleFilterType
        {
            get => _simpleFilterType;
            set
            {
                SimpleFilterTypeSpecified = true;
                _simpleFilterType = value;
            }
        }

        [XmlIgnore]
        protected bool SimpleFilterTypeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation = new List<BroadWorksConnector.Ocip.Models.CriteriaActivation>();

        [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:373")]
        public List<BroadWorksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation
        {
            get => _criteriaActivation;
            set
            {
                CriteriaActivationSpecified = true;
                _criteriaActivation = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaActivationSpecified { get; set; }

    }
}
