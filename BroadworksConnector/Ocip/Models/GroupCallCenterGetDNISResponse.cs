using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetDNISResponse.
    /// <see cref="GroupCallCenterGetDNISResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:4452""}]")]
    public class GroupCallCenterGetDNISResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _dnisPhoneNumber;

        [XmlElement(ElementName = "dnisPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4452")]
        [MinLength(1)]
        [MaxLength(23)]
        public string DnisPhoneNumber
        {
            get => _dnisPhoneNumber;
            set
            {
                DnisPhoneNumberSpecified = true;
                _dnisPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DnisPhoneNumberSpecified { get; set; }

        protected string _extension;

        [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4452")]
        [MinLength(2)]
        [MaxLength(20)]
        public string Extension
        {
            get => _extension;
            set
            {
                ExtensionSpecified = true;
                _extension = value;
            }
        }

        [XmlIgnore]
        protected bool ExtensionSpecified { get; set; }

        protected bool _useCustomCLIDSettings;

        [XmlElement(ElementName = "useCustomCLIDSettings", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4452")]
        public bool UseCustomCLIDSettings
        {
            get => _useCustomCLIDSettings;
            set
            {
                UseCustomCLIDSettingsSpecified = true;
                _useCustomCLIDSettings = value;
            }
        }

        [XmlIgnore]
        protected bool UseCustomCLIDSettingsSpecified { get; set; }

        protected string _callingLineIdPhoneNumber;

        [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4452")]
        [MinLength(1)]
        [MaxLength(23)]
        public string CallingLineIdPhoneNumber
        {
            get => _callingLineIdPhoneNumber;
            set
            {
                CallingLineIdPhoneNumberSpecified = true;
                _callingLineIdPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool CallingLineIdPhoneNumberSpecified { get; set; }

        protected string _callingLineIdLastName;

        [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4452")]
        [MinLength(1)]
        [MaxLength(30)]
        public string CallingLineIdLastName
        {
            get => _callingLineIdLastName;
            set
            {
                CallingLineIdLastNameSpecified = true;
                _callingLineIdLastName = value;
            }
        }

        [XmlIgnore]
        protected bool CallingLineIdLastNameSpecified { get; set; }

        protected string _callingLineIdFirstName;

        [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4452")]
        [MinLength(1)]
        [MaxLength(30)]
        public string CallingLineIdFirstName
        {
            get => _callingLineIdFirstName;
            set
            {
                CallingLineIdFirstNameSpecified = true;
                _callingLineIdFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool CallingLineIdFirstNameSpecified { get; set; }

        protected bool _useCustomDnisAnnouncementSettings;

        [XmlElement(ElementName = "useCustomDnisAnnouncementSettings", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4452")]
        public bool UseCustomDnisAnnouncementSettings
        {
            get => _useCustomDnisAnnouncementSettings;
            set
            {
                UseCustomDnisAnnouncementSettingsSpecified = true;
                _useCustomDnisAnnouncementSettings = value;
            }
        }

        [XmlIgnore]
        protected bool UseCustomDnisAnnouncementSettingsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DNISPriority _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4452")]
        public BroadWorksConnector.Ocip.Models.DNISPriority Priority
        {
            get => _priority;
            set
            {
                PrioritySpecified = true;
                _priority = value;
            }
        }

        [XmlIgnore]
        protected bool PrioritySpecified { get; set; }

        protected bool _allowOutgoingACDCall;

        [XmlElement(ElementName = "allowOutgoingACDCall", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4452")]
        public bool AllowOutgoingACDCall
        {
            get => _allowOutgoingACDCall;
            set
            {
                AllowOutgoingACDCallSpecified = true;
                _allowOutgoingACDCall = value;
            }
        }

        [XmlIgnore]
        protected bool AllowOutgoingACDCallSpecified { get; set; }

    }
}
