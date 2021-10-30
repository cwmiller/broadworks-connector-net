using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's sequential ring service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6a83dcd7b5697b78acbf42324c2dbe67:182""}]")]
    public class UserSequentialRingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"6a83dcd7b5697b78acbf42324c2dbe67:182")]
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

        private bool _ringBaseLocationFirst;

        [XmlElement(ElementName = "ringBaseLocationFirst", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6a83dcd7b5697b78acbf42324c2dbe67:182")]
        public bool RingBaseLocationFirst
        {
            get => _ringBaseLocationFirst;
            set
            {
                RingBaseLocationFirstSpecified = true;
                _ringBaseLocationFirst = value;
            }
        }

        [XmlIgnore]
        protected bool RingBaseLocationFirstSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SequentialRingNumberOfRings _baseLocationNumberOfRings;

        [XmlElement(ElementName = "baseLocationNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6a83dcd7b5697b78acbf42324c2dbe67:182")]
        public BroadWorksConnector.Ocip.Models.SequentialRingNumberOfRings BaseLocationNumberOfRings
        {
            get => _baseLocationNumberOfRings;
            set
            {
                BaseLocationNumberOfRingsSpecified = true;
                _baseLocationNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool BaseLocationNumberOfRingsSpecified { get; set; }

        private bool _continueIfBaseLocationIsBusy;

        [XmlElement(ElementName = "continueIfBaseLocationIsBusy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6a83dcd7b5697b78acbf42324c2dbe67:182")]
        public bool ContinueIfBaseLocationIsBusy
        {
            get => _continueIfBaseLocationIsBusy;
            set
            {
                ContinueIfBaseLocationIsBusySpecified = true;
                _continueIfBaseLocationIsBusy = value;
            }
        }

        [XmlIgnore]
        protected bool ContinueIfBaseLocationIsBusySpecified { get; set; }

        private bool _callerMayStopSearch;

        [XmlElement(ElementName = "callerMayStopSearch", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6a83dcd7b5697b78acbf42324c2dbe67:182")]
        public bool CallerMayStopSearch
        {
            get => _callerMayStopSearch;
            set
            {
                CallerMayStopSearchSpecified = true;
                _callerMayStopSearch = value;
            }
        }

        [XmlIgnore]
        protected bool CallerMayStopSearchSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SequentialRingLocationModify _location01;

        [XmlElement(ElementName = "Location01", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6a83dcd7b5697b78acbf42324c2dbe67:182")]
        public BroadWorksConnector.Ocip.Models.SequentialRingLocationModify Location01
        {
            get => _location01;
            set
            {
                Location01Specified = true;
                _location01 = value;
            }
        }

        [XmlIgnore]
        protected bool Location01Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.SequentialRingLocationModify _location02;

        [XmlElement(ElementName = "Location02", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6a83dcd7b5697b78acbf42324c2dbe67:182")]
        public BroadWorksConnector.Ocip.Models.SequentialRingLocationModify Location02
        {
            get => _location02;
            set
            {
                Location02Specified = true;
                _location02 = value;
            }
        }

        [XmlIgnore]
        protected bool Location02Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.SequentialRingLocationModify _location03;

        [XmlElement(ElementName = "Location03", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6a83dcd7b5697b78acbf42324c2dbe67:182")]
        public BroadWorksConnector.Ocip.Models.SequentialRingLocationModify Location03
        {
            get => _location03;
            set
            {
                Location03Specified = true;
                _location03 = value;
            }
        }

        [XmlIgnore]
        protected bool Location03Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.SequentialRingLocationModify _location04;

        [XmlElement(ElementName = "Location04", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6a83dcd7b5697b78acbf42324c2dbe67:182")]
        public BroadWorksConnector.Ocip.Models.SequentialRingLocationModify Location04
        {
            get => _location04;
            set
            {
                Location04Specified = true;
                _location04 = value;
            }
        }

        [XmlIgnore]
        protected bool Location04Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.SequentialRingLocationModify _location05;

        [XmlElement(ElementName = "Location05", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6a83dcd7b5697b78acbf42324c2dbe67:182")]
        public BroadWorksConnector.Ocip.Models.SequentialRingLocationModify Location05
        {
            get => _location05;
            set
            {
                Location05Specified = true;
                _location05 = value;
            }
        }

        [XmlIgnore]
        protected bool Location05Specified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation = new List<BroadWorksConnector.Ocip.Models.CriteriaActivation>();

        [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6a83dcd7b5697b78acbf42324c2dbe67:182")]
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
