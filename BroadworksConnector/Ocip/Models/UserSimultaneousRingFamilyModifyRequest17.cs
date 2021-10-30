using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's simultaneous ring family service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""239d22a382d3190a183f2ff4efdc404f:177""}]")]
    public class UserSimultaneousRingFamilyModifyRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"239d22a382d3190a183f2ff4efdc404f:177")]
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

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"239d22a382d3190a183f2ff4efdc404f:177")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        private bool _doNotRingIfOnCall;

        [XmlElement(ElementName = "doNotRingIfOnCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"239d22a382d3190a183f2ff4efdc404f:177")]
        public bool DoNotRingIfOnCall
        {
            get => _doNotRingIfOnCall;
            set
            {
                DoNotRingIfOnCallSpecified = true;
                _doNotRingIfOnCall = value;
            }
        }

        [XmlIgnore]
        protected bool DoNotRingIfOnCallSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SimultaneousRingReplacementNumberList _simultaneousRingNumberList;

        [XmlElement(ElementName = "simultaneousRingNumberList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"239d22a382d3190a183f2ff4efdc404f:177")]
        public BroadWorksConnector.Ocip.Models.SimultaneousRingReplacementNumberList SimultaneousRingNumberList
        {
            get => _simultaneousRingNumberList;
            set
            {
                SimultaneousRingNumberListSpecified = true;
                _simultaneousRingNumberList = value;
            }
        }

        [XmlIgnore]
        protected bool SimultaneousRingNumberListSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation = new List<BroadWorksConnector.Ocip.Models.CriteriaActivation>();

        [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"239d22a382d3190a183f2ff4efdc404f:177")]
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
