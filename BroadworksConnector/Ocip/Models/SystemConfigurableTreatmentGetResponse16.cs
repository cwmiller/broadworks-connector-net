using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemConfigurableTreatmentGetRequest16.
    /// The response contains the treatment configurable information.
    /// <see cref="SystemConfigurableTreatmentGetRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9796""}]")]
    public class SystemConfigurableTreatmentGetResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
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

        protected BroadWorksConnector.Ocip.Models.ChargeIndicator _chargeIndicator;

        [XmlElement(ElementName = "chargeIndicator", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
        public BroadWorksConnector.Ocip.Models.ChargeIndicator ChargeIndicator
        {
            get => _chargeIndicator;
            set
            {
                ChargeIndicatorSpecified = true;
                _chargeIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool ChargeIndicatorSpecified { get; set; }

        protected int _accessSIPStatusCode;

        [XmlElement(ElementName = "accessSIPStatusCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
        [MinInclusive(400)]
        [MaxInclusive(699)]
        public int AccessSIPStatusCode
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

        [XmlElement(ElementName = "accessSIPStatusMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
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

        protected int _networkSIPStatusCode;

        [XmlElement(ElementName = "networkSIPStatusCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
        [MinInclusive(400)]
        [MaxInclusive(699)]
        public int NetworkSIPStatusCode
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

        [XmlElement(ElementName = "networkSIPStatusMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
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

        protected int _q850CauseValue;

        [XmlElement(ElementName = "q850CauseValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
        [MinInclusive(1)]
        [MaxInclusive(256)]
        public int Q850CauseValue
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

        [XmlElement(ElementName = "q850Text", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
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

        [XmlElement(ElementName = "accessTreatmentAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
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

        [XmlElement(ElementName = "accessTreatmentVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
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

        [XmlElement(ElementName = "networkTreatmentAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
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

        [XmlElement(ElementName = "networkTreatmentVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
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

        [XmlElement(ElementName = "cdrTerminationCause", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
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

        protected bool _routeAdvance;

        [XmlElement(ElementName = "routeAdvance", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
        public bool RouteAdvance
        {
            get => _routeAdvance;
            set
            {
                RouteAdvanceSpecified = true;
                _routeAdvance = value;
            }
        }

        [XmlIgnore]
        protected bool RouteAdvanceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.InternalReleaseCause16 _internalReleaseCause;

        [XmlElement(ElementName = "internalReleaseCause", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
        public BroadWorksConnector.Ocip.Models.InternalReleaseCause16 InternalReleaseCause
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

        protected bool _accessSendReasonHeader;

        [XmlElement(ElementName = "accessSendReasonHeader", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
        public bool AccessSendReasonHeader
        {
            get => _accessSendReasonHeader;
            set
            {
                AccessSendReasonHeaderSpecified = true;
                _accessSendReasonHeader = value;
            }
        }

        [XmlIgnore]
        protected bool AccessSendReasonHeaderSpecified { get; set; }

        protected bool _networkSendReasonHeader;

        [XmlElement(ElementName = "networkSendReasonHeader", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9796")]
        public bool NetworkSendReasonHeader
        {
            get => _networkSendReasonHeader;
            set
            {
                NetworkSendReasonHeaderSpecified = true;
                _networkSendReasonHeader = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkSendReasonHeaderSpecified { get; set; }

    }
}
