using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSMDIParametersGetListRequest.
    /// Contains a list of system SMDI parameters.
    /// <see cref="SystemSMDIParametersGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17716""}]")]
    public class SystemSMDIParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableSMDI;

        [XmlElement(ElementName = "enableSMDI", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17716")]
        public bool EnableSMDI
        {
            get => _enableSMDI;
            set
            {
                EnableSMDISpecified = true;
                _enableSMDI = value;
            }
        }

        [XmlIgnore]
        protected bool EnableSMDISpecified { get; set; }

        private int _listeningPort;

        [XmlElement(ElementName = "listeningPort", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17716")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int ListeningPort
        {
            get => _listeningPort;
            set
            {
                ListeningPortSpecified = true;
                _listeningPort = value;
            }
        }

        [XmlIgnore]
        protected bool ListeningPortSpecified { get; set; }

        private int _maxConnections;

        [XmlElement(ElementName = "maxConnections", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17716")]
        [MinInclusive(0)]
        [MaxInclusive(64)]
        public int MaxConnections
        {
            get => _maxConnections;
            set
            {
                MaxConnectionsSpecified = true;
                _maxConnections = value;
            }
        }

        [XmlIgnore]
        protected bool MaxConnectionsSpecified { get; set; }

    }
}
