using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the fields for a configurable treatment.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// warnCode
    /// warnText
    /// accessSendWarningHeader
    /// networkSendWarningHeader
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:6979""}]")]
    public class SystemConfigurableTreatmentModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TreatmentId
        {
            get => _treatmentId;
            set
            {
                TreatmentIdSpecified = true;
                _treatmentId = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ChargeIndicator? _chargeIndicator;

        [XmlElement(ElementName = "chargeIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        public BroadWorksConnector.Ocip.Models.ChargeIndicator? ChargeIndicator
        {
            get => _chargeIndicator;
            set
            {
                ChargeIndicatorSpecified = (value != null);
                _chargeIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool ChargeIndicatorSpecified { get; set; }

        protected string _description;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        protected int? _accessSIPStatusCode;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "accessSIPStatusCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinInclusive(400)]
        [MaxInclusive(699)]
        public int? AccessSIPStatusCode
        {
            get => _accessSIPStatusCode;
            set
            {
                AccessSIPStatusCodeSpecified = true;
                _accessSIPStatusCode = value;
            }
        }

        [XmlIgnore]
        protected bool AccessSIPStatusCodeSpecified { get; set; }

        protected string _accessSIPStatusMessage;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "accessSIPStatusMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinLength(1)]
        [MaxLength(50)]
        public string AccessSIPStatusMessage
        {
            get => _accessSIPStatusMessage;
            set
            {
                AccessSIPStatusMessageSpecified = true;
                _accessSIPStatusMessage = value;
            }
        }

        [XmlIgnore]
        protected bool AccessSIPStatusMessageSpecified { get; set; }

        protected int? _networkSIPStatusCode;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "networkSIPStatusCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinInclusive(400)]
        [MaxInclusive(699)]
        public int? NetworkSIPStatusCode
        {
            get => _networkSIPStatusCode;
            set
            {
                NetworkSIPStatusCodeSpecified = true;
                _networkSIPStatusCode = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkSIPStatusCodeSpecified { get; set; }

        protected string _networkSIPStatusMessage;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "networkSIPStatusMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinLength(1)]
        [MaxLength(50)]
        public string NetworkSIPStatusMessage
        {
            get => _networkSIPStatusMessage;
            set
            {
                NetworkSIPStatusMessageSpecified = true;
                _networkSIPStatusMessage = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkSIPStatusMessageSpecified { get; set; }

        protected int? _q850CauseValue;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "q850CauseValue", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinInclusive(1)]
        [MaxInclusive(256)]
        public int? Q850CauseValue
        {
            get => _q850CauseValue;
            set
            {
                Q850CauseValueSpecified = true;
                _q850CauseValue = value;
            }
        }

        [XmlIgnore]
        protected bool Q850CauseValueSpecified { get; set; }

        protected string _q850Text;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "q850Text", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinLength(1)]
        [MaxLength(50)]
        public string Q850Text
        {
            get => _q850Text;
            set
            {
                Q850TextSpecified = true;
                _q850Text = value;
            }
        }

        [XmlIgnore]
        protected bool Q850TextSpecified { get; set; }

        protected string _accessTreatmentAudioFile;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "accessTreatmentAudioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AccessTreatmentAudioFile
        {
            get => _accessTreatmentAudioFile;
            set
            {
                AccessTreatmentAudioFileSpecified = true;
                _accessTreatmentAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool AccessTreatmentAudioFileSpecified { get; set; }

        protected string _accessTreatmentVideoFile;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "accessTreatmentVideoFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AccessTreatmentVideoFile
        {
            get => _accessTreatmentVideoFile;
            set
            {
                AccessTreatmentVideoFileSpecified = true;
                _accessTreatmentVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool AccessTreatmentVideoFileSpecified { get; set; }

        protected string _networkTreatmentAudioFile;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "networkTreatmentAudioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinLength(1)]
        [MaxLength(256)]
        public string NetworkTreatmentAudioFile
        {
            get => _networkTreatmentAudioFile;
            set
            {
                NetworkTreatmentAudioFileSpecified = true;
                _networkTreatmentAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkTreatmentAudioFileSpecified { get; set; }

        protected string _networkTreatmentVideoFile;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "networkTreatmentVideoFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinLength(1)]
        [MaxLength(256)]
        public string NetworkTreatmentVideoFile
        {
            get => _networkTreatmentVideoFile;
            set
            {
                NetworkTreatmentVideoFileSpecified = true;
                _networkTreatmentVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkTreatmentVideoFileSpecified { get; set; }

        protected string _cdrTerminationCause;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "cdrTerminationCause", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinLength(1)]
        [MaxLength(3)]
        public string CdrTerminationCause
        {
            get => _cdrTerminationCause;
            set
            {
                CdrTerminationCauseSpecified = true;
                _cdrTerminationCause = value;
            }
        }

        [XmlIgnore]
        protected bool CdrTerminationCauseSpecified { get; set; }

        protected bool? _routeAdvance;

        [XmlElement(ElementName = "routeAdvance", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        public bool? RouteAdvance
        {
            get => _routeAdvance;
            set
            {
                RouteAdvanceSpecified = (value != null);
                _routeAdvance = value;
            }
        }

        [XmlIgnore]
        protected bool RouteAdvanceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.InternalReleaseCause16? _internalReleaseCause;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "internalReleaseCause", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        public BroadWorksConnector.Ocip.Models.InternalReleaseCause16? InternalReleaseCause
        {
            get => _internalReleaseCause;
            set
            {
                InternalReleaseCauseSpecified = true;
                _internalReleaseCause = value;
            }
        }

        [XmlIgnore]
        protected bool InternalReleaseCauseSpecified { get; set; }

        protected bool? _accessSendReasonHeader;

        [XmlElement(ElementName = "accessSendReasonHeader", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        public bool? AccessSendReasonHeader
        {
            get => _accessSendReasonHeader;
            set
            {
                AccessSendReasonHeaderSpecified = (value != null);
                _accessSendReasonHeader = value;
            }
        }

        [XmlIgnore]
        protected bool AccessSendReasonHeaderSpecified { get; set; }

        protected bool? _networkSendReasonHeader;

        [XmlElement(ElementName = "networkSendReasonHeader", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        public bool? NetworkSendReasonHeader
        {
            get => _networkSendReasonHeader;
            set
            {
                NetworkSendReasonHeaderSpecified = (value != null);
                _networkSendReasonHeader = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkSendReasonHeaderSpecified { get; set; }

        protected int? _warnCode;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "warnCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinInclusive(300)]
        [MaxInclusive(399)]
        public int? WarnCode
        {
            get => _warnCode;
            set
            {
                WarnCodeSpecified = true;
                _warnCode = value;
            }
        }

        [XmlIgnore]
        protected bool WarnCodeSpecified { get; set; }

        protected string _warnText;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "warnText", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        [MinLength(1)]
        [MaxLength(50)]
        public string WarnText
        {
            get => _warnText;
            set
            {
                WarnTextSpecified = true;
                _warnText = value;
            }
        }

        [XmlIgnore]
        protected bool WarnTextSpecified { get; set; }

        protected bool? _accessSendWarningHeader;

        [XmlElement(ElementName = "accessSendWarningHeader", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        public bool? AccessSendWarningHeader
        {
            get => _accessSendWarningHeader;
            set
            {
                AccessSendWarningHeaderSpecified = (value != null);
                _accessSendWarningHeader = value;
            }
        }

        [XmlIgnore]
        protected bool AccessSendWarningHeaderSpecified { get; set; }

        protected bool? _networkSendWarningHeader;

        [XmlElement(ElementName = "networkSendWarningHeader", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6979")]
        public bool? NetworkSendWarningHeader
        {
            get => _networkSendWarningHeader;
            set
            {
                NetworkSendWarningHeaderSpecified = (value != null);
                _networkSendWarningHeader = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkSendWarningHeaderSpecified { get; set; }

    }
}
