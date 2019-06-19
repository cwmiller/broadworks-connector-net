using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the BroadWorks Mobile Manager settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:372""}]")]
    public class EnterpriseBroadWorksMobileManagerModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:372")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _informationFile;

        [XmlElement(ElementName = "informationFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:372")]
        [MinLength(1)]
        public string InformationFile
        {
            get => _informationFile;
            set
            {
                InformationFileSpecified = true;
                _informationFile = value;
            }
        }

        [XmlIgnore]
        public bool InformationFileSpecified { get; set; }

        private string _certificateFile;

        [XmlElement(ElementName = "certificateFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:372")]
        [MinLength(1)]
        public string CertificateFile
        {
            get => _certificateFile;
            set
            {
                CertificateFileSpecified = true;
                _certificateFile = value;
            }
        }

        [XmlIgnore]
        public bool CertificateFileSpecified { get; set; }

        private bool _localToCarrier;

        [XmlElement(ElementName = "localToCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:372")]
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
        public bool LocalToCarrierSpecified { get; set; }

        private bool _maxTxPerSecondEnabled;

        [XmlElement(ElementName = "maxTxPerSecondEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:372")]
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
        public bool MaxTxPerSecondEnabledSpecified { get; set; }

        private int _maxTxPerSecond;

        [XmlElement(ElementName = "maxTxPerSecond", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:372")]
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
        public bool MaxTxPerSecondSpecified { get; set; }

        private bool _tldnEnabled;

        [XmlElement(ElementName = "tldnEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:372")]
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
        public bool TldnEnabledSpecified { get; set; }

        private bool _genericNumberEnabled;

        [XmlElement(ElementName = "genericNumberEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:372")]
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
        public bool GenericNumberEnabledSpecified { get; set; }

        private bool _mobileStateCheckEnabled;

        [XmlElement(ElementName = "mobileStateCheckEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:372")]
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
        public bool MobileStateCheckEnabledSpecified { get; set; }

        private bool _locationBasedServicesEnabled;

        [XmlElement(ElementName = "locationBasedServicesEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:372")]
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
        public bool LocationBasedServicesEnabledSpecified { get; set; }

    }
}
