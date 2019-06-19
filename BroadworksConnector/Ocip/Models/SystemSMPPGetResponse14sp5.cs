using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSMPPGetRequest14sp5.
    /// 
    /// Replaced by: SystemSMPPGetResponse21 in AS data mode
    /// <see cref="SystemSMPPGetRequest14sp5"/>
    /// <see cref="SystemSMPPGetResponse21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:3312""}]")]
    public class SystemSMPPGetResponse14sp5 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _primarySMPPServerNetAddress;

        [XmlElement(ElementName = "primarySMPPServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3312")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PrimarySMPPServerNetAddress
        {
            get => _primarySMPPServerNetAddress;
            set
            {
                PrimarySMPPServerNetAddressSpecified = true;
                _primarySMPPServerNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool PrimarySMPPServerNetAddressSpecified { get; set; }

        private int _primarySMPPPort;

        [XmlElement(ElementName = "primarySMPPPort", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3312")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int PrimarySMPPPort
        {
            get => _primarySMPPPort;
            set
            {
                PrimarySMPPPortSpecified = true;
                _primarySMPPPort = value;
            }
        }

        [XmlIgnore]
        public bool PrimarySMPPPortSpecified { get; set; }

        private string _secondarySMPPServerNetAddress;

        [XmlElement(ElementName = "secondarySMPPServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3312")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SecondarySMPPServerNetAddress
        {
            get => _secondarySMPPServerNetAddress;
            set
            {
                SecondarySMPPServerNetAddressSpecified = true;
                _secondarySMPPServerNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool SecondarySMPPServerNetAddressSpecified { get; set; }

        private int _secondarySMPPPort;

        [XmlElement(ElementName = "secondarySMPPPort", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3312")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int SecondarySMPPPort
        {
            get => _secondarySMPPPort;
            set
            {
                SecondarySMPPPortSpecified = true;
                _secondarySMPPPort = value;
            }
        }

        [XmlIgnore]
        public bool SecondarySMPPPortSpecified { get; set; }

        private string _systemId;

        [XmlElement(ElementName = "systemId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3312")]
        [MinLength(1)]
        [MaxLength(16)]
        public string SystemId
        {
            get => _systemId;
            set
            {
                SystemIdSpecified = true;
                _systemId = value;
            }
        }

        [XmlIgnore]
        public bool SystemIdSpecified { get; set; }

        private string _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3312")]
        [MinLength(1)]
        [MaxLength(8)]
        public string Password
        {
            get => _password;
            set
            {
                PasswordSpecified = true;
                _password = value;
            }
        }

        [XmlIgnore]
        public bool PasswordSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SMPPVersion _version;

        [XmlElement(ElementName = "version", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3312")]
        public BroadWorksConnector.Ocip.Models.SMPPVersion Version
        {
            get => _version;
            set
            {
                VersionSpecified = true;
                _version = value;
            }
        }

        [XmlIgnore]
        public bool VersionSpecified { get; set; }

        private string _systemType;

        [XmlElement(ElementName = "systemType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3312")]
        [MinLength(1)]
        [MaxLength(12)]
        public string SystemType
        {
            get => _systemType;
            set
            {
                SystemTypeSpecified = true;
                _systemType = value;
            }
        }

        [XmlIgnore]
        public bool SystemTypeSpecified { get; set; }

    }
}
