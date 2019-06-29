using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemBroadWorksMobileManagerGetRequest
    /// <see cref="SystemBroadWorksMobileManagerGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2158""}]")]
    public class SystemBroadWorksMobileManagerGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _scfApiNetAddress1;

        [XmlElement(ElementName = "scfApiNetAddress1", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2158")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ScfApiNetAddress1
        {
            get => _scfApiNetAddress1;
            set
            {
                ScfApiNetAddress1Specified = true;
                _scfApiNetAddress1 = value;
            }
        }

        [XmlIgnore]
        protected bool ScfApiNetAddress1Specified { get; set; }

        private string _scfApiNetAddress2;

        [XmlElement(ElementName = "scfApiNetAddress2", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2158")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ScfApiNetAddress2
        {
            get => _scfApiNetAddress2;
            set
            {
                ScfApiNetAddress2Specified = true;
                _scfApiNetAddress2 = value;
            }
        }

        [XmlIgnore]
        protected bool ScfApiNetAddress2Specified { get; set; }

        private string _userName;

        [XmlElement(ElementName = "userName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2158")]
        [MinLength(1)]
        [MaxLength(32)]
        public string UserName
        {
            get => _userName;
            set
            {
                UserNameSpecified = true;
                _userName = value;
            }
        }

        [XmlIgnore]
        protected bool UserNameSpecified { get; set; }

        private string _emailFromAddress;

        [XmlElement(ElementName = "emailFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2158")]
        [MinLength(1)]
        [MaxLength(80)]
        public string EmailFromAddress
        {
            get => _emailFromAddress;
            set
            {
                EmailFromAddressSpecified = true;
                _emailFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool EmailFromAddressSpecified { get; set; }

        private bool _scfIMSOnly;

        [XmlElement(ElementName = "scfIMSOnly", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2158")]
        public bool ScfIMSOnly
        {
            get => _scfIMSOnly;
            set
            {
                ScfIMSOnlySpecified = true;
                _scfIMSOnly = value;
            }
        }

        [XmlIgnore]
        protected bool ScfIMSOnlySpecified { get; set; }

        private string _signalingIPAddress;

        [XmlElement(ElementName = "signalingIPAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2158")]
        [MinLength(1)]
        [MaxLength(39)]
        public string SignalingIPAddress
        {
            get => _signalingIPAddress;
            set
            {
                SignalingIPAddressSpecified = true;
                _signalingIPAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SignalingIPAddressSpecified { get; set; }

        private int _signalingPort;

        [XmlElement(ElementName = "signalingPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2158")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int SignalingPort
        {
            get => _signalingPort;
            set
            {
                SignalingPortSpecified = true;
                _signalingPort = value;
            }
        }

        [XmlIgnore]
        protected bool SignalingPortSpecified { get; set; }

    }
}
