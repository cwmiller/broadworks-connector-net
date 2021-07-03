using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupBroadWorksMobileManagerGetRequest
    /// <see cref="GroupBroadWorksMobileManagerGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:2435""}]")]
    public class GroupBroadWorksMobileManagerGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _mobileManagerId;

        [XmlElement(ElementName = "mobileManagerId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2435")]
        [MinLength(1)]
        [MaxLength(100)]
        public string MobileManagerId
        {
            get => _mobileManagerId;
            set
            {
                MobileManagerIdSpecified = true;
                _mobileManagerId = value;
            }
        }

        [XmlIgnore]
        protected bool MobileManagerIdSpecified { get; set; }

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2435")]
        [MinLength(1)]
        [MaxLength(45)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2435")]
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

        private bool _localToCarrier;

        [XmlElement(ElementName = "localToCarrier", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2435")]
        public bool LocalToCarrier
        {
            get => _localToCarrier;
            set
            {
                LocalToCarrierSpecified = true;
                _localToCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool LocalToCarrierSpecified { get; set; }

        private string _deactivationReason;

        [XmlElement(ElementName = "deactivationReason", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2435")]
        [MinLength(1)]
        [MaxLength(100)]
        public string DeactivationReason
        {
            get => _deactivationReason;
            set
            {
                DeactivationReasonSpecified = true;
                _deactivationReason = value;
            }
        }

        [XmlIgnore]
        protected bool DeactivationReasonSpecified { get; set; }

        private bool _maxTxPerSecondEnabled;

        [XmlElement(ElementName = "maxTxPerSecondEnabled", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2435")]
        public bool MaxTxPerSecondEnabled
        {
            get => _maxTxPerSecondEnabled;
            set
            {
                MaxTxPerSecondEnabledSpecified = true;
                _maxTxPerSecondEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool MaxTxPerSecondEnabledSpecified { get; set; }

        private int _maxTxPerSecond;

        [XmlElement(ElementName = "maxTxPerSecond", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2435")]
        [MinInclusive(1)]
        [MaxInclusive(1000)]
        public int MaxTxPerSecond
        {
            get => _maxTxPerSecond;
            set
            {
                MaxTxPerSecondSpecified = true;
                _maxTxPerSecond = value;
            }
        }

        [XmlIgnore]
        protected bool MaxTxPerSecondSpecified { get; set; }

        private bool _tldnEnabled;

        [XmlElement(ElementName = "tldnEnabled", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2435")]
        public bool TldnEnabled
        {
            get => _tldnEnabled;
            set
            {
                TldnEnabledSpecified = true;
                _tldnEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool TldnEnabledSpecified { get; set; }

        private bool _genericNumberEnabled;

        [XmlElement(ElementName = "genericNumberEnabled", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2435")]
        public bool GenericNumberEnabled
        {
            get => _genericNumberEnabled;
            set
            {
                GenericNumberEnabledSpecified = true;
                _genericNumberEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool GenericNumberEnabledSpecified { get; set; }

        private bool _mobileStateCheckEnabled;

        [XmlElement(ElementName = "mobileStateCheckEnabled", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2435")]
        public bool MobileStateCheckEnabled
        {
            get => _mobileStateCheckEnabled;
            set
            {
                MobileStateCheckEnabledSpecified = true;
                _mobileStateCheckEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool MobileStateCheckEnabledSpecified { get; set; }

        private bool _locationBasedServicesEnabled;

        [XmlElement(ElementName = "locationBasedServicesEnabled", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2435")]
        public bool LocationBasedServicesEnabled
        {
            get => _locationBasedServicesEnabled;
            set
            {
                LocationBasedServicesEnabledSpecified = true;
                _locationBasedServicesEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool LocationBasedServicesEnabledSpecified { get; set; }

    }
}
