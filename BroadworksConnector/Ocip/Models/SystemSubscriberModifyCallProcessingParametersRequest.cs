using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system call processing configuration for all subscribers.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in the XS data mode:
    /// userCallingLineIdSelection
    /// isExtendedCallingLineIdActive
    /// isRingTimeOutActive
    /// ringTimeoutSeconds
    /// allowEmergencyRemoteOfficeOriginations
    /// Replaced By: SystemSubscriberModifyCallProcessingParametersRequest14sp7
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSubscriberModifyCallProcessingParametersRequest14sp7"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:36016""}]")]
    public class SystemSubscriberModifyCallProcessingParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.SystemUserCallingLineIdSelection _userCallingLineIdSelection;

        [XmlElement(ElementName = "userCallingLineIdSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:36016")]
        public BroadWorksConnector.Ocip.Models.SystemUserCallingLineIdSelection UserCallingLineIdSelection
        {
            get => _userCallingLineIdSelection;
            set
            {
                UserCallingLineIdSelectionSpecified = true;
                _userCallingLineIdSelection = value;
            }
        }

        [XmlIgnore]
        protected bool UserCallingLineIdSelectionSpecified { get; set; }

        protected bool _isExtendedCallingLineIdActive;

        [XmlElement(ElementName = "isExtendedCallingLineIdActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:36016")]
        public bool IsExtendedCallingLineIdActive
        {
            get => _isExtendedCallingLineIdActive;
            set
            {
                IsExtendedCallingLineIdActiveSpecified = true;
                _isExtendedCallingLineIdActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsExtendedCallingLineIdActiveSpecified { get; set; }

        protected bool _isRingTimeOutActive;

        [XmlElement(ElementName = "isRingTimeOutActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:36016")]
        public bool IsRingTimeOutActive
        {
            get => _isRingTimeOutActive;
            set
            {
                IsRingTimeOutActiveSpecified = true;
                _isRingTimeOutActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsRingTimeOutActiveSpecified { get; set; }

        protected int _ringTimeoutSeconds;

        [XmlElement(ElementName = "ringTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:36016")]
        [MinInclusive(1)]
        [MaxInclusive(180)]
        public int RingTimeoutSeconds
        {
            get => _ringTimeoutSeconds;
            set
            {
                RingTimeoutSecondsSpecified = true;
                _ringTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RingTimeoutSecondsSpecified { get; set; }

        protected bool _allowEmergencyRemoteOfficeOriginations;

        [XmlElement(ElementName = "allowEmergencyRemoteOfficeOriginations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:36016")]
        public bool AllowEmergencyRemoteOfficeOriginations
        {
            get => _allowEmergencyRemoteOfficeOriginations;
            set
            {
                AllowEmergencyRemoteOfficeOriginationsSpecified = true;
                _allowEmergencyRemoteOfficeOriginations = value;
            }
        }

        [XmlIgnore]
        protected bool AllowEmergencyRemoteOfficeOriginationsSpecified { get; set; }

        protected int _maxNoAnswerNumberOfRings;

        [XmlElement(ElementName = "maxNoAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:36016")]
        [MinInclusive(6)]
        [MaxInclusive(20)]
        public int MaxNoAnswerNumberOfRings
        {
            get => _maxNoAnswerNumberOfRings;
            set
            {
                MaxNoAnswerNumberOfRingsSpecified = true;
                _maxNoAnswerNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool MaxNoAnswerNumberOfRingsSpecified { get; set; }

    }
}
