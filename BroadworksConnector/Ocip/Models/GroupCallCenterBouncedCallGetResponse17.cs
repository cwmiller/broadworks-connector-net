using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterBouncedCallGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
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
        public bool IsActiveSpecified { get; set; }
        private int _numberOfRingsBeforeBouncingCall;

        [XmlElement(ElementName = "numberOfRingsBeforeBouncingCall", IsNullable = false, Namespace = "")]
        public int NumberOfRingsBeforeBouncingCall
        {
            get => _numberOfRingsBeforeBouncingCall;
            set
            {
                NumberOfRingsBeforeBouncingCallSpecified = true;
                _numberOfRingsBeforeBouncingCall = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfRingsBeforeBouncingCallSpecified { get; set; }
        private bool _enableTransfer;

        [XmlElement(ElementName = "enableTransfer", IsNullable = false, Namespace = "")]
        public bool EnableTransfer
        {
            get => _enableTransfer;
            set
            {
                EnableTransferSpecified = true;
                _enableTransfer = value;
            }
        }

        [XmlIgnore]
        public bool EnableTransferSpecified { get; set; }
        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        public string TransferPhoneNumber
        {
            get => _transferPhoneNumber;
            set
            {
                TransferPhoneNumberSpecified = true;
                _transferPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool TransferPhoneNumberSpecified { get; set; }
        private bool _bounceCallWhenAgentUnavailable;

        [XmlElement(ElementName = "bounceCallWhenAgentUnavailable", IsNullable = false, Namespace = "")]
        public bool BounceCallWhenAgentUnavailable
        {
            get => _bounceCallWhenAgentUnavailable;
            set
            {
                BounceCallWhenAgentUnavailableSpecified = true;
                _bounceCallWhenAgentUnavailable = value;
            }
        }

        [XmlIgnore]
        public bool BounceCallWhenAgentUnavailableSpecified { get; set; }
        private bool _alertCallCenterCallOnHold;

        [XmlElement(ElementName = "alertCallCenterCallOnHold", IsNullable = false, Namespace = "")]
        public bool AlertCallCenterCallOnHold
        {
            get => _alertCallCenterCallOnHold;
            set
            {
                AlertCallCenterCallOnHoldSpecified = true;
                _alertCallCenterCallOnHold = value;
            }
        }

        [XmlIgnore]
        public bool AlertCallCenterCallOnHoldSpecified { get; set; }
        private int _alertCallCenterCallOnHoldSeconds;

        [XmlElement(ElementName = "alertCallCenterCallOnHoldSeconds", IsNullable = false, Namespace = "")]
        public int AlertCallCenterCallOnHoldSeconds
        {
            get => _alertCallCenterCallOnHoldSeconds;
            set
            {
                AlertCallCenterCallOnHoldSecondsSpecified = true;
                _alertCallCenterCallOnHoldSeconds = value;
            }
        }

        [XmlIgnore]
        public bool AlertCallCenterCallOnHoldSecondsSpecified { get; set; }
        private bool _bounceCallCenterCallOnHold;

        [XmlElement(ElementName = "bounceCallCenterCallOnHold", IsNullable = false, Namespace = "")]
        public bool BounceCallCenterCallOnHold
        {
            get => _bounceCallCenterCallOnHold;
            set
            {
                BounceCallCenterCallOnHoldSpecified = true;
                _bounceCallCenterCallOnHold = value;
            }
        }

        [XmlIgnore]
        public bool BounceCallCenterCallOnHoldSpecified { get; set; }
        private int _bounceCallCenterCallOnHoldSeconds;

        [XmlElement(ElementName = "bounceCallCenterCallOnHoldSeconds", IsNullable = false, Namespace = "")]
        public int BounceCallCenterCallOnHoldSeconds
        {
            get => _bounceCallCenterCallOnHoldSeconds;
            set
            {
                BounceCallCenterCallOnHoldSecondsSpecified = true;
                _bounceCallCenterCallOnHoldSeconds = value;
            }
        }

        [XmlIgnore]
        public bool BounceCallCenterCallOnHoldSecondsSpecified { get; set; }
    }
}
